using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf365
{
    public partial class frmMemAnl : Form
    {
        public frmMemAnl()
        {
            InitializeComponent();
        }

        private void mnuMain_Click(object sender, EventArgs e)
        {
            frmMainMenu frmNext = new frmMainMenu();
            this.Hide();
            frmNext.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lstMemId.Visible = true;
            lstForeName.Visible = false;
            lstSurname.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lstMemId.Visible = false;
            lstForeName.Visible = false;
            lstSurname.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lstMemId.Visible = false;
            lstForeName.Visible = true;
            lstSurname.Visible = false;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // generate print file

            //send print file to printer

            //display confirmation message
            MessageBox.Show("Member Analysis Printing", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }      
    }
}
