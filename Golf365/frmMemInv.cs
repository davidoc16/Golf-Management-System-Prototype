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
    public partial class frmMemInv : Form
    {
        public frmMemInv()
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

        private void button2_Click(object sender, EventArgs e)
        {
            // generate invoice

            //send invoice to printer

            //display confirmation message
            MessageBox.Show("Invoice Printing", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
