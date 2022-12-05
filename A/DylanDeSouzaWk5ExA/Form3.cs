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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lstSquares.Items.Add("Numbers Squares");
            for (double dblNumber = 0.5D; dblNumber < 5.1D; dblNumber += 0.5D)
            {
                lstSquares.Items.Add(dblNumber.ToString() + "\t" + Math.Pow(dblNumber, 2));
            }
        }

        private void lstSquares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
