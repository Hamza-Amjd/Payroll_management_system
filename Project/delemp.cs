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
    public partial class delemp : Form
    {
        public delemp()
        {
            InitializeComponent();
        }
        private void ResetFormControls()
        {

                textBox6.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(@"Data Source=hamza-hp;Initial Catalog=companypayrolldb;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("delete from employee where employeeid=@employeeid", con);
                cmd.Parameters.AddWithValue("@employeeid", int.Parse(textBox6.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Deleted Employee with EmployeeID=" +textBox6.Text);

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
