using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Generatepayslip : Form
    {
        public Generatepayslip()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void GEtstudentrecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=hamza-hp;Initial Catalog=companypayrolldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT employee.employeeID, employee.employeeName, payroll.pay_date,salary.Amount,salary.BankDetails,payroll.AccountNO FROM payroll INNER JOIN employee ON payroll.employeeID = employee.employeeID INNER JOIN salary ON payroll.salary_ID = salary.salary_ID", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            richTextBox1.Clear();
            richTextBox1.Text += "                                                     Pay Slip\n\n";
            richTextBox1.Text += "Date: " +DateTime.Now;
            richTextBox1.Text += "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            richTextBox1.Text += " ";
            richTextBox1.Text += "Signature____________________            ";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
