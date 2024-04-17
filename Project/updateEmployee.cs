using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class updateEmployee : Form
    {
        public updateEmployee()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void updateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetFormControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=hamza-hp;Initial Catalog=companypayrolldb;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("update employee set employeename=@employeename,EmployeeAddress=@EmployeeAddress ,contactno=@contactno ,EmployeeDesignation=@EmployeeDesignation ,department_id=@department_id where employeeid=@employeeid", con);
            cmd.Parameters.AddWithValue("@employeeid", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@employeename", textBox1.Text);
            cmd.Parameters.AddWithValue("@EmployeeAddress", textBox2.Text);
            cmd.Parameters.AddWithValue("@contactno", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@EmployeeDesignation", textBox4.Text);
            cmd.Parameters.AddWithValue("@department_id", int.Parse(textBox5.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");

            ResetFormControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }
    }
}
