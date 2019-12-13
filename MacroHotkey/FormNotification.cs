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

        public FormNotification()
        {
            InitializeComponent();

            int initialStyle = (int)GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        public void ShowNotification()
        {
            Screen screen = Screen.PrimaryScreen;
            this.Left = (screen.Bounds.Location.X + screen.Bounds.Width / 2) - (this.Width / 2);
            this.Top = screen.Bounds.Location.Y;

            progressBar1.Maximum = TotalTime;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            startTime = DateTime.Now;
            timer1.Start();

            FadeInAsync();
        }

        public void HideNotification()
        {
            timer1.Stop();
            FadeOutAsync();
        }

        private async Task FadeInAsync()
        {
            this.Opacity = 0;
            this.Show();

            for (double i = 0.0; i <= setOpacity; i += setFadeSpeed)
            {
                //Thread.Sleep(10);
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
                //Thread.Sleep(10);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            int value = (int)elapsed.TotalMilliseconds;
            
            if (value > progressBar1.Maximum) value = progressBar1.Maximum;
            else if (value < 0) value = 0;
            
            progressBar1.Value = value;
        }
    }
}
