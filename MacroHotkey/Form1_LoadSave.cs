using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1
    {
        private void SaveSettings()
        {
            if (this.Width >= this.MinimumSize.Width) settings.SaveSetting("Width", this.Width.ToString());
            if (this.Height >= this.MinimumSize.Height) settings.SaveSetting("Height", this.Height.ToString());
            settings.SaveSetting("ColumnNameWidth", ClmName.Width.ToString());
            settings.SaveSetting("ColumnHotkeyWidth", ClmHotkey.Width.ToString());
            settings.SaveSetting("ColumnActionWidth", ClmAction.Width.ToString());
            settings.SaveSetting("HotkeysActive", CheckActive.Checked.ToString());
            settings.SaveSetting("StartInTray", TSStartInTray.Checked.ToString());
            settings.SaveSetting("CloseToTray", TSCloseToTray.Checked.ToString());
        }

        private void LoadSettings()
        {
            this.Width = settings.LoadSetting("Width", "int", "600");
            this.Height = settings.LoadSetting("Height", "int", "400");
            ClmName.Width = settings.LoadSetting("ColumnNameWidth", "int", "150");
            ClmHotkey.Width = settings.LoadSetting("ColumnHotkeyWidth", "int", "105");
            ClmAction.Width = settings.LoadSetting("ColumnActionWidth", "int", "250");
            CheckActive.Checked = settings.LoadSetting("HotkeysActive", "bool", "true");
            TSStartInTray.Checked = settings.LoadSetting("StartInTray", "bool", "false");
            TSCloseToTray.Checked = settings.LoadSetting("CloseToTray", "bool", "false");
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
