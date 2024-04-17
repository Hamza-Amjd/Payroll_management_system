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
    public partial class Searchemployee : Form
    {
        public Searchemployee()
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

                SqlCommand cmd = new SqlCommand("select* from employee where employeeid=@employeeid", con);
                cmd.Parameters.AddWithValue("@employeeid", int.Parse(textBox6.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                searchdataGridView.DataSource = dt;;

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
