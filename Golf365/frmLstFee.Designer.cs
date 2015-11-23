namespace Golf365
{
    partial class frmLstFee
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
            this.MemberList = new System.Windows.Forms.GroupBox();
            this.lstSurname = new System.Windows.Forms.ListBox();
            this.lstMemTyp = new System.Windows.Forms.ListBox();
            this.lstForeName = new System.Windows.Forms.ListBox();
            this.Print = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Forename = new System.Windows.Forms.RadioButton();
            this.Surname = new System.Windows.Forms.RadioButton();
            this.Mem_Type = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberList
            // 
            this.MemberList.Controls.Add(this.lstSurname);
            this.MemberList.Controls.Add(this.lstMemTyp);
            this.MemberList.Controls.Add(this.lstForeName);
            this.MemberList.Location = new System.Drawing.Point(139, 130);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(384, 168);
            this.MemberList.TabIndex = 8;
            this.MemberList.TabStop = false;
            this.MemberList.Text = "Member List";
            // 
            // lstSurname
            // 
            this.lstSurname.FormattingEnabled = true;
            this.lstSurname.Items.AddRange(new object[] {
            "0024 Barry, Johnathon                 FULL",
            "0147 Kelly, Anne                           FULL",
            "0104 Kelly, James                          STU",
            "0235 Moriarty, Peter                     FAM",
            "0236 Moriarty, Roisin                   FAM",
            "0111 Rahilly, Thomas                   FULL"});
            this.lstSurname.Location = new System.Drawing.Point(17, 28);
            this.lstSurname.Name = "lstSurname";
            this.lstSurname.Size = new System.Drawing.Size(349, 134);
            this.lstSurname.TabIndex = 27;
            // 
            // lstMemTyp
            // 
            this.lstMemTyp.FormattingEnabled = true;
            this.lstMemTyp.Items.AddRange(new object[] {
            "0024 Barry, Johnathon                 FULL",
            "0104 Kelly, James                          STU",
            "0111 Rahilly, Thomas                   FULL",
            "0147 Kelly, Anne                           FULL",
            "0235 Moriarty, Peter                     FAM",
            "0236 Moriarty, Roisin                   FAM"});
            this.lstMemTyp.Location = new System.Drawing.Point(17, 28);
            this.lstMemTyp.Name = "lstMemTyp";
            this.lstMemTyp.Size = new System.Drawing.Size(349, 134);
            this.lstMemTyp.TabIndex = 28;
            this.lstMemTyp.Visible = false;
            // 
            // lstForeName
            // 
            this.lstForeName.FormattingEnabled = true;
            this.lstForeName.Items.AddRange(new object[] {
            "0147 Kelly, Anne                           FULL",
            "0104 Kelly, James                          STU",
            "0024 Barry, Johnathon                 FULL",
            "0235 Moriarty, Peter                     FAM",
            "0236 Moriarty, Roisin                   FAM",
            "0111 Rahilly, Thomas                   FULL"});
            this.lstForeName.Location = new System.Drawing.Point(17, 28);
            this.lstForeName.Name = "lstForeName";
            this.lstForeName.Size = new System.Drawing.Size(349, 134);
            this.lstForeName.TabIndex = 26;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(430, 307);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 7;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Forename);
            this.groupBox1.Controls.Add(this.Surname);
            this.groupBox1.Controls.Add(this.Mem_Type);
            this.groupBox1.Location = new System.Drawing.Point(139, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Order";
            // 
            // Forename
            // 
            this.Forename.AutoSize = true;
            this.Forename.Location = new System.Drawing.Point(195, 13);
            this.Forename.Name = "Forename";
            this.Forename.Size = new System.Drawing.Size(72, 17);
            this.Forename.TabIndex = 2;
            this.Forename.TabStop = true;
            this.Forename.Text = "Forename";
            this.Forename.UseVisualStyleBackColor = true;
            this.Forename.CheckedChanged += new System.EventHandler(this.Forename_CheckedChanged);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(122, 13);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(67, 17);
            this.Surname.TabIndex = 1;
            this.Surname.TabStop = true;
            this.Surname.Text = "Surname";
            this.Surname.UseVisualStyleBackColor = true;
            this.Surname.CheckedChanged += new System.EventHandler(this.Surname_CheckedChanged);
            // 
            // Mem_Type
            // 
            this.Mem_Type.AutoSize = true;
            this.Mem_Type.Location = new System.Drawing.Point(27, 13);
            this.Mem_Type.Name = "Mem_Type";
            this.Mem_Type.Size = new System.Drawing.Size(78, 17);
            this.Mem_Type.TabIndex = 0;
            this.Mem_Type.TabStop = true;
            this.Mem_Type.Text = "Mem_Type";
            this.Mem_Type.UseVisualStyleBackColor = true;
            this.Mem_Type.CheckedChanged += new System.EventHandler(this.Mem_Type_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 19;
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
            // frmLstFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 447);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MemberList);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLstFee";
            this.Text = "Golf365 - List Late Fees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLstFee_FormClosed);
            this.MemberList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MemberList;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Surname;
        private System.Windows.Forms.RadioButton Mem_Type;
        private System.Windows.Forms.RadioButton Forename;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ListBox lstForeName;
        private System.Windows.Forms.ListBox lstSurname;
        private System.Windows.Forms.ListBox lstMemTyp;
    }
}