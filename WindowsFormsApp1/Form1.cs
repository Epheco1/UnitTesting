using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StaffBenefits : Form
    {
        
        public StaffBenefits()
        {
            InitializeComponent();
        }

        private void StaffBenefits_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var basic = decimal.Parse(tbBasic.Text);
                var housing = decimal.Parse(tbHousing.Text);
                var transportation = decimal.Parse(tbTransportation.Text);
                var salary = SalaryCalc(basic, housing, transportation);

                tbSalary.Text = salary.ToString();
            }
            catch (Exception)
            {
                tbSalary.Text = "There was a problem";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static decimal SalaryCalc(decimal basic, decimal housing, decimal transportation)
        {
            return (basic + housing + transportation) * 2;

        }
        public static decimal LeaveAllowance(decimal basic, decimal housing, decimal transportation)
        {
            return (SalaryCalc(10, 15, 5) * 15 / 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var basic = decimal.Parse(tbBasic.Text);
                var housing = decimal.Parse(tbHousing.Text);
                var transportation = decimal.Parse(tbTransportation.Text);
                var leaveAllowance = LeaveAllowance(basic, housing, transportation);

                tbLeave.Text = leaveAllowance.ToString();
            }
            catch (Exception)
            {

                tbLeave.Text = "It seems there was an issue";
            }
        }

        private void tbHousing_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
