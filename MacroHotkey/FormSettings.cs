using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormSettings : Form
    {
        Settings settings = new Settings();

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            CheckStartInTray.Checked = settings.LoadSetting("StartInTray", "bool", "false");
            CheckCloseToTray.Checked = settings.LoadSetting("CloseToTray", "bool", "false");
            CheckMinimizeOnRun.Checked = settings.LoadSetting("MinimizeOnRun", "bool", "false");

            CheckRememberMainWindowSize.Checked = settings.LoadSetting("RememberMainWindowSize", "bool", "true");
            CheckRememberMainWindowPosition.Checked = settings.LoadSetting("RememberMainWindowPosition", "bool", "true");

            CheckRememberEditorWindowSize.Checked = settings.LoadSetting("RememberEditorWindowSize", "bool", "true");
            CheckRememberEditorWindowPosition.Checked = settings.LoadSetting("RememberEditorWindowPosition", "bool", "true");

            CheckReturnMouse.Checked = settings.LoadSetting("ReturnMouse", "bool", "true");

            ComboDelayStart.Text = settings.LoadSetting("DelayOnStart", "string", "500");
            ComboDelayBetween.Text = settings.LoadSetting("DelayBetweenCommands", "string", "100");
            ComboDelayBeforePaste.Text = settings.LoadSetting("DelayBeforePaste", "string", "300");
            ComboDelayAfterPaste.Text = settings.LoadSetting("DelayAfterPaste", "string", "100");
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            settings.SaveSetting("StartInTray", CheckStartInTray.Checked.ToString());
            settings.SaveSetting("CloseToTray", CheckCloseToTray.Checked.ToString());
            settings.SaveSetting("MinimizeOnRun", CheckMinimizeOnRun.Checked.ToString());

            settings.SaveSetting("RememberMainWindowSize", CheckRememberMainWindowSize.Checked.ToString());
            settings.SaveSetting("RememberMainWindowPosition", CheckRememberMainWindowPosition.Checked.ToString());

            settings.SaveSetting("RememberEditorWindowSize", CheckRememberEditorWindowSize.Checked.ToString());
            settings.SaveSetting("RememberEditorWindowPosition", CheckRememberEditorWindowPosition.Checked.ToString());

            settings.SaveSetting("ReturnMouse", CheckReturnMouse.Checked.ToString());

            settings.SaveSetting("DelayOnStart", ComboDelayStart.Text);
            settings.SaveSetting("DelayBetweenCommands", ComboDelayBetween.Text);
            settings.SaveSetting("DelayBeforePaste", ComboDelayBeforePaste.Text);
            settings.SaveSetting("DelayAfterPaste", ComboDelayAfterPaste.Text);

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
