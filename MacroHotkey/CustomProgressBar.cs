using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System;


namespace MacroHotkey
{
    public class NewProgressBar : ProgressBar
    {
        public NewProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public string ProgressText { get; set; }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                    SolidBrush blackBrush = new SolidBrush(Color.Black);

                    offscreen.FillRectangle(blackBrush, 0, 0, rect.Width, rect.Height);

                    rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                    if (rect.Width == 0) rect.Width = 1;

                    SolidBrush brushWhite = new SolidBrush(Color.White);

                    if (Value > 0)
                    {
                        offscreen.FillRectangle(brushWhite, 0, 1, rect.Width, rect.Height);
                    }

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                    offscreenImage.Dispose();
                }
            }
        }
    }
}
