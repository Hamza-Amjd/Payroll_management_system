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
    public partial class listemp : Form
    {
        public listemp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }
        private void GEtstudentrecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=hamza-hp;Initial Catalog=companypayrolldb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select *from employee", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            listdataGridView.DataSource = dt;

        }

        private void listemp_Load(object sender, EventArgs e)
        {
            GEtstudentrecord();
        }

        private void listdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
