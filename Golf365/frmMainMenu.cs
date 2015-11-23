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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Terminate application
            System.Environment.Exit(1);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void mnuRatesCreate_Click(object sender, EventArgs e)
        {
            frmMemTypeCreate frmNext = new frmMemTypeCreate();
            this.Hide();
            frmNext.Show();
        }

    

        private void mnuMemList_Click(object sender, EventArgs e)
        {
            frmLstMem frmNext = new frmLstMem();
            this.Hide();
            frmNext.Show();
        }

        private void mnuMemReg_Click(object sender, EventArgs e)
        {
            frmRegMem frmNext = new frmRegMem();
            this.Hide();
            frmNext.Show();
        }

        private void mnuMemDeReg_Click(object sender, EventArgs e)
        {
            frmDeReg frmNext = new frmDeReg();
            this.Hide();
            frmNext.Show();
        }

        private void mnuMemAmd_Click(object sender, EventArgs e)
        {
            frmAmdMem frmNext = new frmAmdMem();
            this.Hide();
            frmNext.Show();
        }

        private void mnuRatesChange_Click(object sender, EventArgs e)
        {
            frmMemTypeChange frmNext = new frmMemTypeChange();
            this.Hide();
            frmNext.Show();
        }

        private void issueMemberInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemInv frmNext = new frmMemInv();
            this.Hide();
            frmNext.Show();
        }

        private void issueRenewalNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRnlNot frmNext = new frmRnlNot();
            this.Hide();
            frmNext.Show();
        }

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRcdPay frmNext = new frmRcdPay();
            this.Hide();
            frmNext.Show();
        }

        private void incomeAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInAnl frmNext = new frmInAnl();
            this.Hide();
            frmNext.Show();
        }

        private void memberAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemAnl frmNext = new frmMemAnl();
            this.Hide();
            frmNext.Show();
        }

        private void listLateFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLstFee frmNext = new frmLstFee();
            this.Hide();
            frmNext.Show();
        }     
    }
}
