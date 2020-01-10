using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1
    {
        private bool setStartInTray;
        private bool setCloseToTray;
        private bool setMinimizeOnRun;

        private bool setRememberMainWindowSize;
        private bool setRememberMainWindowPosition;

        private void SaveSettings()
        {
            if (this.Width >= this.MinimumSize.Width && this.Height >= this.MinimumSize.Height)
            {
                if (setRememberMainWindowSize)
                {
                    settings.SaveSetting("Width", this.Width.ToString());
                    settings.SaveSetting("Height", this.Height.ToString());
                }

                if (setRememberMainWindowPosition)
                {
                    settings.SaveSetting("Left", this.Left.ToString());
                    settings.SaveSetting("Top", this.Top.ToString());
                }
            }
            
            settings.SaveSetting("ColumnNameWidth", ClmName.Width.ToString());
            settings.SaveSetting("ColumnHotkeyWidth", ClmHotkey.Width.ToString());
            settings.SaveSetting("ColumnActionWidth", ClmAction.Width.ToString());
        }

        private void LoadSettings(bool updateWindow)
        {
            setStartInTray = settings.LoadSetting("StartInTray", "bool", "false");
            setCloseToTray = settings.LoadSetting("CloseToTray", "bool", "false");
            setMinimizeOnRun = settings.LoadSetting("MinimizeOnRun", "bool", "false");

            setRememberMainWindowSize = settings.LoadSetting("RememberMainWindowSize", "bool", "true");
            setRememberMainWindowPosition = settings.LoadSetting("RememberMainWindowPosition", "bool", "false");

            if (setRememberMainWindowSize && updateWindow)
            {
                this.Width = settings.LoadSetting("Width", "int", "600");
                this.Height = settings.LoadSetting("Height", "int", "400");
            }

            if (setRememberMainWindowPosition && updateWindow)
            {
                int left = settings.LoadSetting("Left", "int", "-9999");
                int top = settings.LoadSetting("Top", "int", "-9999");

                if (left == -9999 || top == -9999) CenterForm();
                else
                {
                    this.Left = left;
                    this.Top = top;
                }
            }
            else if (updateWindow) CenterForm();

            if (updateWindow)
            {
                ClmName.Width = settings.LoadSetting("ColumnNameWidth", "int", "150");
                ClmHotkey.Width = settings.LoadSetting("ColumnHotkeyWidth", "int", "105");
                ClmAction.Width = settings.LoadSetting("ColumnActionWidth", "int", "250");
            }

            string delayOnStart = settings.LoadSetting("DelayOnStart", "string", "500");
            string delayBetween = settings.LoadSetting("DelayBetweenCommands", "string", "100");
            string delayPaste = settings.LoadSetting("DelayAfterPaste", "string", "200");

            int.TryParse(delayOnStart, out setDelayOnStart);
            int.TryParse(delayBetween, out setDelayBetween);
            int.TryParse(delayPaste, out setDelayPaste);
        }

        private void SaveList()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(listFile))
                {
                    if (LstActions.Items.Count > 0)
                    {
                        foreach (ListViewItem item in LstActions.Items)
                        {
                            string name = item.SubItems[LIST_NAME].Text.Replace("|", "");
                            string hotkey = item.SubItems[LIST_HOTKEY].Text.Replace("|", "");
                            string action = item.SubItems[LIST_ACTION].Text.Replace("|", "");
                            string str = name + "|" + hotkey + "|" + action;

                            sw.WriteLine(str);
                        }
                    }
                }
            }

            catch { }
        }

        private void LoadList()
        {
            try
            {
                LstActions.Items.Clear();

                if (File.Exists(listFile))
                {
                    using (StreamReader reader = File.OpenText(listFile))
                    {
                        LstActions.BeginUpdate();

                        while (reader.Peek() >= 0)
                        {
                            string line = reader.ReadLine();
                            List<string> list = line.Split('|').ToList<string>();

                            ListViewItem item = new ListViewItem(list[LIST_NAME]);
                            item.SubItems.Add(list[LIST_HOTKEY]);
                            item.SubItems.Add(list[LIST_ACTION]);

                            LstActions.Items.Add(item);
                        }

                        LstActions.EndUpdate();
                    }
                }
            }

            catch { }
        }
    }
}
