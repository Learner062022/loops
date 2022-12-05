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

        private void lstDivisibleNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lstDivisibleNumbers.Items.Add("Divisible Numbers");
            uint uintNumber;
            uintNumber = uint.Parse(txtPrompt.Text);
            for (uint counter = 1; counter < (uintNumber + 1); counter++)
            {
                if (uintNumber % counter == 0)
                {
                    lstDivisibleNumbers.Items.Add(counter.ToString());
                }
            }
        }

        private void txtPrompt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
