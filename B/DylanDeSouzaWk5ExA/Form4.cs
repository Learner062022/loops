using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaWk5ExA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int intNumber;
            uint uintCount = 0;

            intNumber = int.Parse(txtNumber.Text);

            while (intNumber > 1)
            {
                intNumber /= 2;
                uintCount += 1;

                txtAnswer.Text = uintCount.ToString();
            }
        }
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
