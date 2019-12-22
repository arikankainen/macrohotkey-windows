using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormNotification : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern long GetWindowLong(IntPtr hWnd, int nIndex);

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        private const int WS_EX_TOPMOST = 0x00000008;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOPMOST;
                return createParams;
            }
        }

        public int TotalTime { set; get; }

        private double setFadeSpeed = .1;
        private double setOpacity = .8;

        private DateTime startTime;

        private int elapsedTime;


        public FormNotification()
        {
            InitializeComponent();

            int initialStyle = (int)GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        public void ShowNotification()
        {
            LabelName.ForeColor = Color.White;
            LabelName.Text = " Running macro...";

            Screen screen = Screen.PrimaryScreen;
            this.Left = (screen.Bounds.Location.X + screen.Bounds.Width / 2) - (this.Width / 2);
            this.Top = screen.Bounds.Location.Y;

            progressBar1.Maximum = TotalTime;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            startTime = DateTime.Now;
            if (!timer1.Enabled) timer1.Start();

            FadeInAsync();
        }

        public void HideNotification()
        {
            timer1.Stop();
            FadeOutAsync();
        }

        public void PauseProgress()
        {
            LabelName.ForeColor = Color.Red;
            LabelName.Text = "Macro paused";
            timer1.Stop();
        }

        public void ContinueProgress()
        {
            startTime = DateTime.Now.AddMilliseconds(-elapsedTime);
            LabelName.ForeColor = Color.White;
            LabelName.Text = " Running macro...";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = (int)(DateTime.Now - startTime).TotalMilliseconds;
            if (elapsedTime < 0) elapsedTime = 0;
            if (elapsedTime > TotalTime) elapsedTime = TotalTime;

            progressBar1.Value = elapsedTime;
        }

        private async Task FadeInAsync()
        {
            this.Opacity = 0;
            this.Show();

            for (double i = 0.0; i <= setOpacity; i += setFadeSpeed)
            {
                await WaitMillisecondsAsync(10);
                this.Opacity = i;
                Application.DoEvents();
            }
        }

        private async Task FadeOutAsync()
        {
            double fade = setFadeSpeed / 100;

            for (double i = setOpacity; i >= 0.0; i -= setFadeSpeed)
            {
                await WaitMillisecondsAsync(10);
                this.Opacity = i;
                Application.DoEvents();
            }

            this.Hide();
        }

        private async Task WaitMillisecondsAsync(int ms)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(ms);
            });
        }

    }
}
