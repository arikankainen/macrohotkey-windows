using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class Form1
    {
        private int Scale(int i)
        {
            int dpi = (int)AutoScaleDimensions.Height;
            double factor = 1.0;
            if (dpi == 120) factor = 1.25;
            else if (dpi == 144) factor = 1.5;
            else if (dpi == 192) factor = 2.0;
            return (int)(i * factor);
        }

        private void AddLines()
        {
            Line(this.ClientRectangle.Height - Scale(51), (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left));
        }

        private void Line(int top, AnchorStyles a)
        {
            Label labelLine = new Label();
            labelLine.Top = top;
            labelLine.Left = 0;
            labelLine.AutoSize = false;
            labelLine.Height = 2;
            labelLine.Width = this.Width + 1;
            labelLine.BorderStyle = BorderStyle.Fixed3D;
            labelLine.Anchor = a;
            this.Controls.Add(labelLine);
            labelLine.BringToFront();
        }
    }
}
