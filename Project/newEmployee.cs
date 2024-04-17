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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class newEmployee : Form
    {
        public newEmployee()
        {
            InitializeComponent();
        }

        private void newEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
        }
        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=hamza-hp;Initial Catalog=companypayrolldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from employee where employeeid=@employeeid", con);
            cmd.Parameters.AddWithValue("@employeeid", textBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=hamza-hp;Initial Catalog=companypayrolldb;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into employee values(@employeename,@EmployeeAddress ,@contactno ,@EmployeeDesignation ,@department_id)", con);
            cmd.Parameters.AddWithValue("@employeename", textBox1.Text);
            cmd.Parameters.AddWithValue("@EmployeeAddress", textBox2.Text);
            cmd.Parameters.AddWithValue("@contactno", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@EmployeeDesignation", textBox4.Text);
            cmd.Parameters.AddWithValue("@department_id", int.Parse(textBox5.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");

            ResetFormControls();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {   
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
