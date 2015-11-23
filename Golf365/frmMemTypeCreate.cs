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
    public partial class frmMemTypeCreate : Form
    {
        public frmMemTypeCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
              //Validate the data
            //All fields are required
            if(txtType.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }


            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            //Double dblFee = Convert.ToDouble(txtFee.Text);
              
            
            decimal decFee = decimal.Parse(txtFee.Text);
            if (decFee <= 0)
            {
                MessageBox.Show("Fee must be greater than zero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFee.Focus();
                return;
            }

            //mock test for already created type
            if (txtType.Text.Equals("JN"))
            {
                MessageBox.Show("Type already created", "Error!¬", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }

            //Store the member type details

            //display a confirmation message
            MessageBox.Show("Member Type Created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset the UI
            txtType.Text = "";
            txtDescription.Text = "";
            txtFee.Text = "0.00";
            txtType.Focus();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpType_Enter(object sender, EventArgs e)
        {

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
