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
            lstDivisibleNumbers.Items.Add("Divisible Numbers");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int int_num = 0;
            try
            {
                int_num = int.Parse(txtNumber.Text);
                errorProvider1.Dispose();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNumber, ex.ToString());
            }
            finally
            {
                txtNumber.Clear();
                txtNumber.Focus();
            }
            
            for (uint counter = 1; counter < (int_num + 1); counter++)
            {
                if (int_num % counter == 0)
                {
                    lstDivisibleNumbers.Items.Add(counter.ToString());
                }
            }
        }
    }
}
