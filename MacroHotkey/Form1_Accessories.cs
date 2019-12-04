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
    public partial class Form1
    {
        //protected override void SetVisibleCore(bool value)
        //{
        //    if (!IsHandleCreated && value)
        //    {
        //        base.CreateHandle();
        //        value = false;
        //    }

        //    base.SetVisibleCore(value);
        //}

        private int scale(int i)
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
            line(panel1.Height, (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left));
            line(this.ClientRectangle.Height - scale(51), (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left));
        }

        private void line(int top, AnchorStyles a)
        {
            Label labelLine = new Label();
            labelLine.Top = top;
            labelLine.Left = 0;
            labelLine.AutoSize = false;
            labelLine.Height = 2;
            labelLine.Width = panel1.Width + 1;
            labelLine.BorderStyle = BorderStyle.Fixed3D;
            labelLine.Anchor = a;
            this.Controls.Add(labelLine);
            labelLine.BringToFront();
        }
    }
}
