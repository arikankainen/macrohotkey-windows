using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHotkey
{
    public partial class FormGetKey : Form
    {
        private bool updatingText = false;
        private bool updatingCheckbox = false;

        public string Keystring { get; set; }

        public DialogResult Result { get; set; }

        public FormGetKey()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
            Keystring = comboBox1.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            Keystring = "";
            this.Close();
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingCheckbox) CheckModifiers();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new ChangeTextDelegete(CheckModifiers));
        }

        private delegate void ChangeTextDelegete();

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            if (!updatingText) CheckCheckBoxes();
        }

        private void CheckModifiers()
        {
            updatingText = true;

            string first = GetFirst();
            string second = GetSecond();

            first = first.Replace("%", "").Replace("^", "").Replace("+", "");

            comboBox1.Text = first + second;

            if (ChkAlt.Checked) comboBox1.Text = "%" + comboBox1.Text;
            if (ChkCtrl.Checked) comboBox1.Text = "^" + comboBox1.Text;
            if (ChkShift.Checked) comboBox1.Text = "+" + comboBox1.Text;

            updatingText = false;
        }

        private void CheckCheckBoxes()
        {
            updatingCheckbox = true;

            string first = GetFirst();

            if (first.Contains("%")) ChkAlt.Checked = true;
            else ChkAlt.Checked = false;

            if (first.Contains("^")) ChkCtrl.Checked = true;
            else ChkCtrl.Checked = false;

            if (first.Contains("+")) ChkShift.Checked = true;
            else ChkShift.Checked = false;

            updatingCheckbox = false;
        }

        private string GetFirst()
        {
            string first = comboBox1.Text;
            if (comboBox1.Text.Contains("{")) first = Regex.Match(comboBox1.Text, "(.*?)(\\{.*)").Groups[1].Value;

            return first;
        }

        private string GetSecond()
        {
            string second = "";
            if (comboBox1.Text.Contains("{")) second = Regex.Match(comboBox1.Text, "(.*?)(\\{.*)").Groups[2].Value;

            return second;
        }

        private void FormGetKey_Shown(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }
    }
}
