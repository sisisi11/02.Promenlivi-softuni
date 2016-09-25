using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09.BGtoEU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var bgn = this.numericUpDownAmmount.Value;
            var factor = 1.95583m;
            var result = bgn * factor;
            this.labelResult.Text = Math.Round(result, 3).ToString();
        }
    }
}
