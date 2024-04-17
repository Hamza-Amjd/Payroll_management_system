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
    public partial class paydetails : Form
    {
        public paydetails()
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
            SqlConnection con = new SqlConnection(@"Data Source=HP-HAMZA\SQLEXPRESS;Initial Catalog=payrolDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            SqlCommand cmd = new SqlCommand("SELECT Paygrade.paygrade,taxes.tax_rate, salary.pay_date,salary.Amount FROM salary INNER JOIN paygrade ON salary.paygrade_ID = Paygrade.paygrade_ID INNER JOIN taxes ON salary.tax_Id = taxes.tax_ID", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            paydetailsdataGridView.DataSource = dt;

        }
        private void GEtstudentrecord2()
        {
            

        }

        private void paydetailsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void paydetails_Load(object sender, EventArgs e)
        {
            GEtstudentrecord();
        }
    }
}
