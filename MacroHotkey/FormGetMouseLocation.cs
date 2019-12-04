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
    public partial class FormGetMouseLocation : Form
    {
        private Point position;

        public Point Position
        {
            get { return position; }
        }

        public FormGetMouseLocation()
        {
            InitializeComponent();
            btnLocation.Focus();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            position = new Point(Cursor.Position.X, Cursor.Position.Y);
            this.Close();
        }
    }
}
