using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        const short SWP_NOMOVE = 0X2;
        const short SWP_NOSIZE = 1;
        const short SWP_NOZORDER = 0X4;
        const int SWP_SHOWWINDOW = 0x0040;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        public static void PressKey(Keys key, bool up)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;

            if (up) keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            else keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_XDOWN = 0x0080;
        private const uint MOUSEEVENTF_XUP = 0x0100;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;
        private const uint MOUSEEVENTF_HWHEEL = 0x01000;

        public void DoMouseClick(MouseButtons mouseButton)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            if (mouseButton == MouseButtons.Left) mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            if (mouseButton == MouseButtons.Right) mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
            if (mouseButton == MouseButtons.Middle) mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
        }

        public void DoMouseDown(MouseButtons mouseButton)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            if (mouseButton == MouseButtons.Left) mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            if (mouseButton == MouseButtons.Right) mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 0, 0);
            if (mouseButton == MouseButtons.Middle) mouse_event(MOUSEEVENTF_MIDDLEDOWN, X, Y, 0, 0);
        }

        public void DoMouseUp(MouseButtons mouseButton)
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            if (mouseButton == MouseButtons.Left) mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            if (mouseButton == MouseButtons.Right) mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
            if (mouseButton == MouseButtons.Middle) mouse_event(MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0);
        }

        private void WindowPosition(string scr, int x, int y)
        {
            try
            {
                if (scr == null)
                {
                    IntPtr handle = GetForegroundWindow();
                    SetWindowPos(handle, 0, x, y, 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
                }
                else
                {
                    Screen screen = GetScreen(scr);

                    if (screen != null)
                    {
                        int relativeX = screen.Bounds.X + x;
                        int relativeY = screen.Bounds.Y + y;

                        IntPtr handle = GetForegroundWindow();
                        SetWindowPos(handle, 0, relativeX, relativeY, 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
                    }
                }
            }
            catch { }
        }

        private void SetCursor(string scr, int x, int y)
        {
            try
            {
                if (scr == null)
                {
                    Cursor.Position = new Point(x, y);
                }
                else
                {
                    Screen screen = GetScreen(scr);

                    if (screen != null)
                    {
                        int relativeX = screen.Bounds.X + x;
                        int relativeY = screen.Bounds.Y + y;

                        Cursor.Position = new Point(relativeX, relativeY);
                    }
                }
            }
            catch { }
        }

        private Screen GetScreen(string number)
        {
            try
            {
                foreach (Screen s in Screen.AllScreens)
                {
                    if (s.DeviceName.Contains(number)) return s;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        // ************************************************************************************************************* //

        private KeyboardHook hook = new KeyboardHook();

        private void ReloadHotkeys()
        {
            hook.DisposeAllKeys();

            foreach (ListViewItem item in LstActions.Items)
            {
                string key = item.SubItems[LIST_HOTKEY].Text;
                string keyList = Hotkeys.GetHotkeyKey(key);
                string modList = Hotkeys.GetHotkeyModifiers(key);

                HookKey(modList, keyList);
            }

            HookKey("Ctrl", "Cancel");
        }

        private void HookKey(string mod, string key)
        {
            //if (string.IsNullOrEmpty(mod) && !string.IsNullOrEmpty(key)) hook.RegisterHotKey((ModifierKeys)0, (Keys)Enum.Parse(typeof(Keys), key));
            //else if (!string.IsNullOrEmpty(mod) && !string.IsNullOrEmpty(key)) hook.RegisterHotKey((ModifierKeys)Hotkeys.GetGlobalHotkeyModNumber(mod), (Keys)Enum.Parse(typeof(Keys), key));

            int.TryParse(Hotkeys.GetValue(key), out int keycode);

            if (string.IsNullOrEmpty(mod) && !string.IsNullOrEmpty(key)) hook.RegisterHotKey((ModifierKeys)0, (Keys)keycode);
            else if (!string.IsNullOrEmpty(mod) && !string.IsNullOrEmpty(key)) hook.RegisterHotKey((ModifierKeys)Hotkeys.GetGlobalHotkeyModNumber(mod), (Keys)keycode);
        }

        private void hook_KeyPressedAsync(object sender, KeyPressedEventArgs e)
        {
            if (e.Modifier == MacroHotkey.ModifierKeys.Control && e.Key == Keys.Cancel) cancel = true;

            if (CheckActive.Checked && !running)
            {
                running = true;
                RunActionAsync(GetAction(e.Modifier.ToString(), e.Key.ToString()));
            }
        }

        private string GetAction(string modifier, string key)
        {
            if (modifier == "0") modifier = null;
            key = Hotkeys.GetKeyName(Hotkeys.GetValue(key));

            foreach (ListViewItem item in LstActions.Items)
            {
                string keyList = Hotkeys.GetHotkeyKey(item.SubItems[LIST_HOTKEY].Text);
                string modList = Hotkeys.GetHotkeyModifiersGlobal(item.SubItems[LIST_HOTKEY].Text);

                if (modifier == modList && key == keyList) return item.SubItems[LIST_ACTION].Text;
            }

            return null;
        }
    }
}
