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

        private void btnAscendBy1_Click(object sender, EventArgs e)
        {
            lstSquares.Items.Clear();
            lstSquares.Items.Add("Numbers Squares");
            for (uint uintNumber = 1U; uintNumber < 13U; uintNumber += 1U)
            {
                lstSquares.Items.Add(uintNumber.ToString() + "\t" + Math.Pow(uintNumber, 2));
            }

        }

        private void btnAscendBy2_Click(object sender, EventArgs e)
        {
            lstSquares.Items.Clear();
            lstSquares.Items.Add("Numbers Squares");
            for (uint uintNumber = 1U; uintNumber < 13U; uintNumber += 2U)
            {
                 
                lstSquares.Items.Add(uintNumber.ToString() + "\t" + Math.Pow(uintNumber, 2));
            
            }
        }

        private void btnAscendBy4_Click(object sender, EventArgs e)
        {
            lstSquares.Items.Clear();
            lstSquares.Items.Add("Numbers Squares");
            for (uint uintNumber = 12; uintNumber > 0U; uintNumber -= 4U)
            {
                lstSquares.Items.Add(uintNumber.ToString() + "\t" + Math.Pow(uintNumber, 2));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
