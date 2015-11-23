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
    public partial class frmInAnl : Form
    {
        public frmInAnl()
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

        private void Print_Click(object sender, EventArgs e)
        {
            // generate print file

            //send print file to printer

            //display confirmation message
            MessageBox.Show("Income Analysis Printing", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
