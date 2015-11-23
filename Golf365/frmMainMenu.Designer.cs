namespace Golf365
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMainPic = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.mmName = new System.Windows.Forms.MenuStrip();
            this.mnuRates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRatesCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRatesChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemAmd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemDeReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMemberInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueRenewalNoticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listLateFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPic)).BeginInit();
            this.mmName.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainPic
            // 
            this.picMainPic.Image = ((System.Drawing.Image)(resources.GetObject("picMainPic.Image")));
            this.picMainPic.Location = new System.Drawing.Point(22, 27);
            this.picMainPic.Name = "picMainPic";
            this.picMainPic.Size = new System.Drawing.Size(334, 288);
            this.picMainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainPic.TabIndex = 0;
            this.picMainPic.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(463, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mmName
            // 
            this.mmName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRates,
            this.mnuMembers,
            this.mnuFinance,
            this.mnuAdmin,
            this.mnuExit});
            this.mmName.Location = new System.Drawing.Point(0, 0);
            this.mmName.Name = "mmName";
            this.mmName.Size = new System.Drawing.Size(559, 24);
            this.mmName.TabIndex = 2;
            this.mmName.Text = "menuStrip1";
            // 
            // mnuRates
            // 
            this.mnuRates.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRatesCreate,
            this.mnuRatesChange});
            this.mnuRates.Name = "mnuRates";
            this.mnuRates.Size = new System.Drawing.Size(47, 20);
            this.mnuRates.Text = "Rates";
            // 
            // mnuRatesCreate
            // 
            this.mnuRatesCreate.Name = "mnuRatesCreate";
            this.mnuRatesCreate.Size = new System.Drawing.Size(192, 22);
            this.mnuRatesCreate.Text = "Create Member Type";
            this.mnuRatesCreate.Click += new System.EventHandler(this.mnuRatesCreate_Click);
            // 
            // mnuRatesChange
            // 
            this.mnuRatesChange.Name = "mnuRatesChange";
            this.mnuRatesChange.Size = new System.Drawing.Size(192, 22);
            this.mnuRatesChange.Text = "Change Member Type";
            this.mnuRatesChange.Click += new System.EventHandler(this.mnuRatesChange_Click);
            // 
            // mnuMembers
            // 
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMemReg,
            this.mnuMemAmd,
            this.mnuMemDeReg,
            this.mnuMemList});
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(69, 20);
            this.mnuMembers.Text = "Members";
            // 
            // mnuMemReg
            // 
            this.mnuMemReg.Name = "mnuMemReg";
            this.mnuMemReg.Size = new System.Drawing.Size(183, 22);
            this.mnuMemReg.Text = "Register Member";
            this.mnuMemReg.Click += new System.EventHandler(this.mnuMemReg_Click);
            // 
            // mnuMemAmd
            // 
            this.mnuMemAmd.Name = "mnuMemAmd";
            this.mnuMemAmd.Size = new System.Drawing.Size(183, 22);
            this.mnuMemAmd.Text = "Amend Member";
            this.mnuMemAmd.Click += new System.EventHandler(this.mnuMemAmd_Click);
            // 
            // mnuMemDeReg
            // 
            this.mnuMemDeReg.Name = "mnuMemDeReg";
            this.mnuMemDeReg.Size = new System.Drawing.Size(183, 22);
            this.mnuMemDeReg.Text = "De-Register Member";
            this.mnuMemDeReg.Click += new System.EventHandler(this.mnuMemDeReg_Click);
            // 
            // mnuMemList
            // 
            this.mnuMemList.Name = "mnuMemList";
            this.mnuMemList.Size = new System.Drawing.Size(183, 22);
            this.mnuMemList.Text = "List Members";
            this.mnuMemList.Click += new System.EventHandler(this.mnuMemList_Click);
            // 
            // mnuFinance
            // 
            this.mnuFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueMemberInvoiceToolStripMenuItem,
            this.issueRenewalNoticeToolStripMenuItem,
            this.recordPaymentToolStripMenuItem});
            this.mnuFinance.Name = "mnuFinance";
            this.mnuFinance.Size = new System.Drawing.Size(60, 20);
            this.mnuFinance.Text = "Finance";
            // 
            // issueMemberInvoiceToolStripMenuItem
            // 
            this.issueMemberInvoiceToolStripMenuItem.Name = "issueMemberInvoiceToolStripMenuItem";
            this.issueMemberInvoiceToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.issueMemberInvoiceToolStripMenuItem.Text = "Issue Member Invoice";
            this.issueMemberInvoiceToolStripMenuItem.Click += new System.EventHandler(this.issueMemberInvoiceToolStripMenuItem_Click);
            // 
            // issueRenewalNoticeToolStripMenuItem
            // 
            this.issueRenewalNoticeToolStripMenuItem.Name = "issueRenewalNoticeToolStripMenuItem";
            this.issueRenewalNoticeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.issueRenewalNoticeToolStripMenuItem.Text = "Issue Renewal Notice";
            this.issueRenewalNoticeToolStripMenuItem.Click += new System.EventHandler(this.issueRenewalNoticeToolStripMenuItem_Click);
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeAnalysisToolStripMenuItem,
            this.memberAnalysisToolStripMenuItem,
            this.listLateFeesToolStripMenuItem});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // incomeAnalysisToolStripMenuItem
            // 
            this.incomeAnalysisToolStripMenuItem.Name = "incomeAnalysisToolStripMenuItem";
            this.incomeAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.incomeAnalysisToolStripMenuItem.Text = "Income Analysis";
            this.incomeAnalysisToolStripMenuItem.Click += new System.EventHandler(this.incomeAnalysisToolStripMenuItem_Click);
            // 
            // memberAnalysisToolStripMenuItem
            // 
            this.memberAnalysisToolStripMenuItem.Name = "memberAnalysisToolStripMenuItem";
            this.memberAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.memberAnalysisToolStripMenuItem.Text = "Member Analysis";
            this.memberAnalysisToolStripMenuItem.Click += new System.EventHandler(this.memberAnalysisToolStripMenuItem_Click);
            // 
            // listLateFeesToolStripMenuItem
            // 
            this.listLateFeesToolStripMenuItem.Name = "listLateFeesToolStripMenuItem";
            this.listLateFeesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listLateFeesToolStripMenuItem.Text = "List Late Fees";
            this.listLateFeesToolStripMenuItem.Click += new System.EventHandler(this.listLateFeesToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(559, 325);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picMainPic);
            this.Controls.Add(this.mmName);
            this.MainMenuStrip = this.mmName;
            this.Name = "frmMainMenu";
            this.Text = "Golf365-(Main Menu)";
            ((System.ComponentModel.ISupportInitialize)(this.picMainPic)).EndInit();
            this.mmName.ResumeLayout(false);
            this.mmName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMainPic;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip mmName;
        private System.Windows.Forms.ToolStripMenuItem mnuRates;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuFinance;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRatesCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuRatesChange;
        private System.Windows.Forms.ToolStripMenuItem mnuMemReg;
        private System.Windows.Forms.ToolStripMenuItem mnuMemAmd;
        private System.Windows.Forms.ToolStripMenuItem mnuMemDeReg;
        private System.Windows.Forms.ToolStripMenuItem mnuMemList;
        private System.Windows.Forms.ToolStripMenuItem issueMemberInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueRenewalNoticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listLateFeesToolStripMenuItem;
    }
}

