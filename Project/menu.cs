using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            newEmployee f1 = new newEmployee();
            f1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f1 = new login();
            f1.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void generatePaySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generatepayslip f1 = new Generatepayslip();
            f1.Show();
        }

        private void updateEmployeeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateEmployee f1 = new updateEmployee();
            f1.Show();
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searchemployee f1 = new Searchemployee();
            f1.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            delemp f1 = new delemp();
            f1.Show();
        }

        private void employeeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            listemp f1 = new listemp();
            f1.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            paydetails f1 = new paydetails();
            f1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login f1 = new login();
            f1.Show();
        }
    }
}
