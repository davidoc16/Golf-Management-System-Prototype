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
    public partial class frmLstMem : Form
    {
        public frmLstMem()
        {
            InitializeComponent();
        }
        private void MemberList_Enter(object sender, EventArgs e)
        {
            MemberList.Visible = true;
        }
        private void frmLstMem_Load(object sender, EventArgs e)
        {
            

            if (radName.Checked)
            {
                MemberList.Visible = true;
            }
            
            else if (radMemId.Checked)
            {
                MemberList.Visible = true;
            }

            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // generate print file

            //send print file to printer

            //display confirmation message
            MessageBox.Show("List of Members Printing", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void radMemId_CheckedChanged(object sender, EventArgs e)
        {
            lstName.Visible = false;
            lstMemId.Visible = true;
        }

        private void radName_CheckedChanged(object sender, EventArgs e)
        {
            lstMemId.Visible = false;
            lstName.Visible = true;

        }

        private void frmLstMem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMain_Click(object sender, EventArgs e)
        {
            frmMainMenu frmNext = new frmMainMenu();
            this.Hide();
            frmNext.Show();
            
        }    
        
    }
}
