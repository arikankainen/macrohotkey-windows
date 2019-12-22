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
    }
}
