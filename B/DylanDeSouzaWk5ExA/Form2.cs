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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //Declare unsigned or signed variables or constants
            uint uintPrompt, uintCondition = 0, uintAnswer = 0;

            //Validate input
            if (!uint.TryParse(txtNumber.Text, out uintPrompt))
            {
                MessageBox.Show("A positive whole number must be entered - please enter the number again");
                txtNumber.Clear();
                txtNumber.Focus();
                return;
            }
            else
            {
            //write list box headings
            TimesTable.Items.Add("Multiplication\tAnswer");

            //Establish definite or indefinite loop and the loop's condition
            while (uintCondition < 13)
            {
                uintAnswer = uintCondition * uintPrompt;
                TimesTable.Items.Add(uintCondition.ToString() + " x " + uintPrompt.ToString() + "\t=\t" + uintAnswer.ToString());

                //Incrementation
                uintCondition += 1U;
            }
            }
        }
    }
}
