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
            //Declare unsigned or signed variables
            uint uintTimePeriodYears = 0;
            decimal decInterest, decInvestmentAmount, decAnnualInterestRate;

            //Convert text by establishing their data type and passing them into variables
            decInvestmentAmount = decimal.Parse(txtInvestmentAmount.Text);
            decAnnualInterestRate = decimal.Parse(txtAnnualInterestRate.Text);

            //List box column heading
            lstSimpleInterestEarned.Items.Add("Interest\tInvestment Amount\tAnnual Interest Rate\tTime in years");
        
            while (uintTimePeriodYears < 11)
            {
                decInterest = (decInvestmentAmount * decAnnualInterestRate * uintTimePeriodYears);

                //Display as string
                lstSimpleInterestEarned.Items.Add((decInterest.ToString("C") + "\t" + decInvestmentAmount.ToString("C") + "\t" + decAnnualInterestRate.ToString("C") + "\t" + uintTimePeriodYears.ToString()));
             
                //Incrementation
                uintTimePeriodYears += 1U;
            }
       
        }
    }
}
