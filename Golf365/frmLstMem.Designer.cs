namespace Golf365
{
    partial class frmLstMem
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
            this.radName = new System.Windows.Forms.RadioButton();
            this.radMemId = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.Print = new System.Windows.Forms.Button();
            this.MemberList = new System.Windows.Forms.GroupBox();
            this.lstMemId = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.MemberList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Checked = true;
            this.radName.Location = new System.Drawing.Point(27, 13);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(53, 17);
            this.radName.TabIndex = 0;
            this.radName.TabStop = true;
            this.radName.Text = "Name";
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radName_CheckedChanged);
            // 
            // radMemId
            // 
            this.radMemId.AutoSize = true;
            this.radMemId.Location = new System.Drawing.Point(122, 13);
            this.radMemId.Name = "radMemId";
            this.radMemId.Size = new System.Drawing.Size(75, 17);
            this.radMemId.TabIndex = 1;
            this.radMemId.Text = "Member Id";
            this.radMemId.UseVisualStyleBackColor = true;
            this.radMemId.CheckedChanged += new System.EventHandler(this.radMemId_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMemId);
            this.groupBox1.Controls.Add(this.radName);
            this.groupBox1.Location = new System.Drawing.Point(99, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Order";
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Items.AddRange(new object[] {
            "0024 Barry, Johnathon                 FULL",
            "0147 Kelly, Anne                           FULL",
            "0104 Kelly, James                          STU",
            "0235 Moriarty, Peter                     FAM",
            "0236 Moriarty, Roisin                   FAM",
            "0111 Rahilly, Thomas                   FULL"});
            this.lstName.Location = new System.Drawing.Point(16, 18);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(349, 134);
            this.lstName.TabIndex = 3;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(374, 289);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 4;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // MemberList
            // 
            this.MemberList.Controls.Add(this.lstMemId);
            this.MemberList.Controls.Add(this.lstName);
            this.MemberList.Location = new System.Drawing.Point(83, 112);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(384, 168);
            this.MemberList.TabIndex = 5;
            this.MemberList.TabStop = false;
            this.MemberList.Text = "Member List";
            this.MemberList.Enter += new System.EventHandler(this.MemberList_Enter);
            // 
            // lstMemId
            // 
            this.lstMemId.FormattingEnabled = true;
            this.lstMemId.Items.AddRange(new object[] {
            "0024 Barry, Johnathon                 FULL",
            "0104 Kelly, James                          STU",
            "0111 Rahilly, Thomas                   FULL",
            "0147 Kelly, Anne                           FULL",
            "0235 Moriarty, Peter                     FAM",
            "0236 Moriarty, Roisin                   FAM"});
            this.lstMemId.Location = new System.Drawing.Point(16, 18);
            this.lstMemId.Name = "lstMemId";
            this.lstMemId.Size = new System.Drawing.Size(349, 134);
            this.lstMemId.TabIndex = 6;
            this.lstMemId.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(80, 20);
            this.mnuMain.Text = "Main Menu";
            this.mnuMain.Click += new System.EventHandler(this.mnuMain_Click);
            // 
            // frmLstMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 324);
            this.Controls.Add(this.MemberList);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLstMem";
            this.Text = "Golf365 - List Members";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLstMem_FormClosed);
            this.Load += new System.EventHandler(this.frmLstMem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MemberList.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radMemId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.GroupBox MemberList;
        private System.Windows.Forms.ListBox lstMemId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
    }
}