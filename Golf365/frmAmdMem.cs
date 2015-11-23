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
    public partial class frmAmdMem : Form
    {
        public frmAmdMem()
        {
            InitializeComponent();
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpAmend.Visible = true;
        }

   
        private void btnAmd_Click(object sender, EventArgs e)
        {
            //Validate the data
            //All fields are required
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }

            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            //not required because some people may not have an email address
            /*if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }*/


            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            //save the date to the Member Types file

            //Display a confirmation Message
            MessageBox.Show("Member Details Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboTypes.Text = "";

            //reset the UI
            grpAmend.Visible = false;
            //reset the UI
            txtSurname.Text = "";
            txtForename.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            dtpDOB.Value = dtpDOB.MaxDate;
            txtSurname.Focus();
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
