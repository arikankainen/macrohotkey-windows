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
            if (this.Width > 0) settings.SaveSetting("Width", this.Width.ToString());
            if (this.Height > 0) settings.SaveSetting("Height", this.Height.ToString());
            settings.SaveSetting("ColumnNameWidth", clmName.Width.ToString());
            settings.SaveSetting("ColumnHotkeyWidth", clmHotkey.Width.ToString());
            settings.SaveSetting("ColumnActionWidth", clmAction.Width.ToString());
            settings.SaveSetting("HotkeysActive", checkActive.Checked.ToString());
        }

        private void LoadSettings()
        {
            this.Width = settings.LoadSetting("Width", "int", "600");
            this.Height = settings.LoadSetting("Height", "int", "400");
            clmName.Width = settings.LoadSetting("ColumnNameWidth", "int", "150");
            clmHotkey.Width = settings.LoadSetting("ColumnHotkeyWidth", "int", "105");
            clmAction.Width = settings.LoadSetting("ColumnActionWidth", "int", "250");
            checkActive.Checked = settings.LoadSetting("HotkeysActive", "bool", "true");
        }

        private void SaveList()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(listFile))
                {
                    if (lstActions.Items.Count > 0)
                    {
                        foreach (ListViewItem item in lstActions.Items)
                        {
                            string name = item.SubItems[LIST_NAME].Text;
                            string hotkey = item.SubItems[LIST_HOTKEY].Text;
                            string action = item.SubItems[LIST_ACTION].Text;
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
                lstActions.Items.Clear();

                if (File.Exists(listFile))
                {
                    using (StreamReader reader = File.OpenText(listFile))
                    {
                        lstActions.BeginUpdate();

                        while (reader.Peek() >= 0)
                        {
                            string line = reader.ReadLine();
                            List<string> list = line.Split('|').ToList<string>();

                            ListViewItem item = new ListViewItem(list[LIST_NAME]);
                            item.SubItems.Add(list[LIST_HOTKEY]);
                            item.SubItems.Add(list[LIST_ACTION]);

                            lstActions.Items.Add(item);
                        }

                        lstActions.EndUpdate();
                    }
                }
            }

            catch { }
        }
    }
}
