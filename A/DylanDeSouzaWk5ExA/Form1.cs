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

        private void btnAscendBy1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (uint uintNumber = 15U; uintNumber < 26U; uintNumber += 1U)
            {
                listBox1.Items.Add(uintNumber.ToString());
            }
        }

        private void btnAscendBy2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (uint uintNumber = 15U; uintNumber < 26U; uintNumber += 2U)
            {
                listBox1.Items.Add(uintNumber.ToString());
            }
        }

        private void btnAscendBy4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (uint uintNumber = 25; uintNumber > 14U; uintNumber -= 3U)
            {
                listBox1.Items.Add(uintNumber.ToString());
            }
        }
    }
}
