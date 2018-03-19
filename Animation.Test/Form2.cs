using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Animation.Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void _tbReplace_Click(object sender, EventArgs e)
        {
            String input = this._tbInput.Text.Trim();
            String pattern = this._tbPattern.Text.Trim();
            String replacement = this._tbReplacement.Text.Trim();
            try
            {
                this._tbOutput.Text = Regex.Replace(input, pattern, replacement);
            }
            catch (Exception exc)
            {
                this._tbOutput.Text = null;
                MessageBox.Show(exc.Message);
            }
          
         

        }
    }
}
