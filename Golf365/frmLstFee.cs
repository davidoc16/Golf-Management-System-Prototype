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
    public partial class frmLstFee : Form
    {
        public frmLstFee()
        {
            InitializeComponent();
        }

        private void frmLstFee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void Mem_Type_CheckedChanged(object sender, EventArgs e)
        {
            lstMemTyp.Visible = true;
            lstForeName.Visible = false;
            lstSurname.Visible = false;
        }

        private void Surname_CheckedChanged(object sender, EventArgs e)
        {
            lstMemTyp.Visible = false;
            lstForeName.Visible = false;
            lstSurname.Visible = true;
        }

        private void Forename_CheckedChanged(object sender, EventArgs e)
        {
            lstMemTyp.Visible = false;
            lstForeName.Visible = true;
            lstSurname.Visible = false;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // generate print file

            //send print file to printer

            //display confirmation message
            MessageBox.Show("List of Late Fees Printing", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

    }
}
