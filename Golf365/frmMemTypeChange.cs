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
    public partial class frmMemTypeChange : Form
    {
        public frmMemTypeChange()
        {
            InitializeComponent();
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpType.Visible = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //validate the input data

            //save the date to the Member Types file

            //Display a confirmation Message
            MessageBox.Show("Member Type Changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboTypes.Text = "";

            //reset the UI
            grpType.Visible = false;
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
    }
}
