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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //Declare unsigned or signed variables or constants
            const uint THREE = 3U;
            uint uintCondition = 0, uintAnswer = 0;

            //write list box headings
            lstThreeTimesTable.Items.Add("Multiplication\tAnswer"); // \t\t means two tabs

            //Establish definite or indefinite loop and the loop's condition
            while (uintCondition < 13)
            {
                uintAnswer = uintCondition * THREE; 
                lstThreeTimesTable.Items.Add(uintCondition.ToString() + " x " + THREE.ToString() + "\t=\t" + uintAnswer.ToString());

                //Incrementation
                uintCondition += 1U;
            }
        }
    }
}
