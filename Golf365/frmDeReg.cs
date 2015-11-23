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
    public partial class frmDeReg : Form
    {
        public frmDeReg()
        {
            InitializeComponent();
        }

        private void Golf365___De_Register_Member_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validate the data
            //All fields are required
            if (txtMem_Id.Text.Equals(""))
            {
                //Display an error Message
                MessageBox.Show("Please enter Mem_Id", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMem_Id.Focus();
                return;
            }

            //Display a confirmation message
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to De-Register Member", "Some Title", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //Display a confirmation message
                MessageBox.Show("Member De-Registered", "Some Title", MessageBoxButtons.OK);
            };

            if (dialogResult == DialogResult.No)
            {
                //Display a confirmation message
                MessageBox.Show("Member Not De-Registered", "Some Title", MessageBoxButtons.OK);
                txtMem_Id.Focus();
                return;
            }

            
           
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
