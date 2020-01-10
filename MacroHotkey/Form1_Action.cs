using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1
    {
        private async Task WaitMillisecondsAsync(int ms)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(ms);
            });
        }

        private void MacroTimerTick()
        {
            if (macroCancelled)
            {
                TimerMacro.Stop();
                MacroCompleted();
            }
            else if (actionDelayType == ActionDelayType.DelayInitial)
            {
                if ((DateTime.Now - macroRowCompletedTime).TotalMilliseconds > setDelayOnStart)
                {
                    TimerMacro.Stop();
                    RunRow(macroRows[macroRow]);
                }
            }
            else if (actionDelayType == ActionDelayType.DelayBetween)
            {
                if ((DateTime.Now - macroRowCompletedTime).TotalMilliseconds > setDelayBetween)
                {
                    TimerMacro.Stop();
                    RunRow(macroRows[macroRow]);
                }
            }
            else if (actionDelayType == ActionDelayType.DelayCustom)
            {
                if ((DateTime.Now - macroRowCompletedTime).TotalMilliseconds > actionDelay)
                {
                    TimerMacro.Stop();
                    RunRow(macroRows[macroRow]);
                }
            }
            else if (actionDelayType == ActionDelayType.None)
            {
                TimerMacro.Stop();
                RunRow(macroRows[macroRow]);
            }
        }

        private void MacroStarted(string action)
        {
            if (action != null)
            {
                macroRunning = true;
                CheckSelectedItems();
                originalMousePosition = Cursor.Position;

                macroCancelled = false;

                macroRowCompletedTime = DateTime.Now;
                macroRow = 0;

                macroRows.Clear();
                macroRows = action.Split(';').ToList();
                
                notification.TotalTime = CalculateMacroTotalTime(macroRows);
                notification.ShowNotification();

                timerIcon.Start();
                TimerMacro.Start();
            }
        }

        private void MacroCompleted()
        {
            TimerMacro.Stop();
            timerIcon.Stop();

            notification.HideNotification();
            NotifyIcon1.Icon = this.Icon = Properties.Resources.mh;

            macroRunning = false;

            CheckSelectedItems();
            
            if (setReturnMouse)
            {
                Cursor.Position = originalMousePosition;
                Cursor.Position = originalMousePosition;
            }
        }

        private void MacroRowCompleted()
        {
            macroRow++;
            macroRowCompletedTime = DateTime.Now;

            if (macroRows.Count <= macroRow) MacroCompleted();
            else TimerMacro.Start();
        }

        private int CalculateMacroTotalTime(List<string> rows)
        {
            int totalTime = setDelayOnStart;

            foreach (string row in rows)
            {
                if (row.Length > 0 && !row.StartsWith("#"))
                {
                    Regex regex = new Regex(@"(^.*?)\((.*)\)");
                    Match match = regex.Match(row.ToLower());

                    string command = match.Groups[1].Value;
                    string value = match.Groups[2].Value;

                    if (command == "delay")
                    {
                        int.TryParse(value, out int delay);
                        totalTime += delay;
                    }
                    else totalTime += setDelayBetween;

                    if (command.Contains("paste")) totalTime += setDelayPaste;
                }
            }

            return totalTime;
        }

        private void RunRow(string row)
        {
            Regex regex = new Regex(@"(^.*?)\((.*)\)");
            Match match = regex.Match(row);

            string command = match.Groups[1].Value.ToLower();
            string value = match.Groups[2].Value;

            if (command.StartsWith("#"))
            {
                command = null;
                actionDelayType = ActionDelayType.None;
            }
            else
            {
                actionDelayType = ActionDelayType.DelayBetween;
            }

            switch (command)
            {
                case "pause":
                    ActionPause();
                    break;

                case "delay":
                    ActionDelay(value);
                    break;

                case "key":
                    ActionKey(value);
                    break;

                case "pastetext":
                    ActionPasteText(value);
                    break;

                case "typetext":
                    ActionTypeText(value);
                    break;

                case "copy":
                    ActionCopy();
                    break;

                case "paste":
                    ActionPaste(value);
                    break;

                case "mousedown":
                    ActionMouseDown(value);
                    break;

                case "mouseup":
                    ActionMouseUp(value);
                    break;

                case "mouseclick":
                    ActionMouseClick(value);
                    break;

                case "mousemove":
                    ActionMouseMove(value);
                    break;

                case "mouseposition":
                    ActionMousePosition(value);
                    break;

                case "windowposition":
                    ActionWindowPosition(value);
                    break;

                case "windowsize":
                    ActionWindowSize(value);
                    break;

                case "activatewindow":
                    ActionActivateWindow(value);
                    break;

                default:
                    MacroRowCompleted();
                    break;
            }
        }

        private void ActionPause()
        {
            if (actionDelayType != ActionDelayType.Pause)
            {
                actionDelayType = ActionDelayType.Pause;
                notification.PauseProgress();
            }
            else
            {
                actionDelayType = ActionDelayType.DelayInitial;
                macroRowCompletedTime = DateTime.Now;
                notification.ContinueProgress();
            }
            
            MacroRowCompleted();
        }

        private void ActionDelay(string value)
        {
            try
            {
                int.TryParse(value, out int delay);

                if (delay > 0)
                {
                    actionDelayType = ActionDelayType.DelayCustom;
                    actionDelay = delay;
                }
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionKey(string value)
        {
            try
            {
                SendKeys.SendWait(value.ToLower());
            }
            catch { }

            MacroRowCompleted();
        }

        private async void ActionPasteText(string value)
        {
            try
            {
                string clipboard = null;
                if (Clipboard.ContainsText()) clipboard = Clipboard.GetText();

                Clipboard.SetDataObject(value);
                SendKeys.Send("^v");

                await WaitMillisecondsAsync(setDelayPaste);
                if (clipboard != null) Clipboard.SetText(clipboard);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionCopy()
        {
            try
            {
                SendKeys.Send("^c");
            }
            catch { }

            MacroRowCompleted();
        }

        private async void ActionPaste(string value)
        {
            try
            {
                string clipboard = null;
                if (Clipboard.ContainsText()) clipboard = Clipboard.GetText();

                int.TryParse(value, out int index);
                
                if (value != "") Clipboard.SetText(GetClipboardText(index - 1));
                SendKeys.Send("^v");

                await WaitMillisecondsAsync(setDelayPaste);
                if (clipboard != null && value != "") Clipboard.SetText(clipboard);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionTypeText(string value)
        {
            try
            {
                for (int i = 0; i < value.Length; i++)
                {
                    string str = value.Substring(i, 1);

                    str = str.Replace("{", "!!!_BRACE_OPEN_!!!");
                    str = str.Replace("}", "!!!_BRACE_CLOSE_!!!");
                    str = str.Replace("+", "{+}");
                    str = str.Replace("%", "{%}");
                    str = str.Replace("^", "{^}");
                    str = str.Replace("~", "{~}");
                    str = str.Replace("[", "{[}");
                    str = str.Replace("]", "{]}");
                    str = str.Replace("!!!_BRACE_OPEN_!!!", "{{}");
                    str = str.Replace("!!!_BRACE_CLOSE_!!!", "{}}");

                    SendKeys.Send(str);
                }
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionMouseDown(string value)
        {
            try
            {
                if (value.ToLower() == "left") DoMouseDown(MouseButtons.Left);
                else if (value.ToLower() == "right") DoMouseDown(MouseButtons.Right);
                else if (value.ToLower() == "middle") DoMouseDown(MouseButtons.Middle);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionMouseUp(string value)
        {
            try
            {
                if (value.ToLower() == "left") DoMouseUp(MouseButtons.Left);
                else if (value.ToLower() == "right") DoMouseUp(MouseButtons.Right);
                else if (value.ToLower() == "middle") DoMouseUp(MouseButtons.Middle);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionMouseClick(string value)
        {
            try
            {
                if (value.ToLower() == "left") DoMouseClick(MouseButtons.Left);
                else if (value.ToLower() == "right") DoMouseClick(MouseButtons.Right);
                else if (value.ToLower() == "middle") DoMouseClick(MouseButtons.Middle);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionMouseMove(string value)
        {
            try
            {
                List<string> position = value.Split(',').ToList();

                int.TryParse(position[0], out int x);
                int.TryParse(position[1], out int y);

                Cursor.Position = new Point(Cursor.Position.X + x, Cursor.Position.Y + y);
                Cursor.Position = new Point(Cursor.Position.X + x, Cursor.Position.Y + y);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionMousePosition(string value)
        {
            try
            {
                List<string> position = value.Split(',').ToList();

                int.TryParse(position[0], out int x);
                int.TryParse(position[1], out int y);

                string scr = position.Count > 2 ? position[2] : null;

                SetCursor(scr, x, y);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionWindowPosition(string value)
        {
            try
            {
                List<string> position = value.Split(',').ToList();

                int.TryParse(position[0], out int x);
                int.TryParse(position[1], out int y);

                string scr = position.Count > 2 ? position[2] : null;

                WindowPosition(scr, x, y);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionWindowSize(string value)
        {
            try
            {
                List<string> position = value.Split(',').ToList();

                int.TryParse(position[0], out int width);
                int.TryParse(position[1], out int height);

                WindowSize(width, height);
            }
            catch { }

            MacroRowCompleted();
        }

        private void ActionActivateWindow(string value)
        {
            try
            {
                List<string> list = value.Split(',').ToList();

                string process = list[0];
                string title = list[1];

                if (list.Count > 2)
                {
                    for (int i = 2; i < list.Count; i++)
                    {
                        title += "," + list[i];
                    }
                }

                process = process.Trim();
                title = title.Trim();

                ActivateWindow(process, title);
            }
            catch { }

            MacroRowCompleted();
        }
    }
}
