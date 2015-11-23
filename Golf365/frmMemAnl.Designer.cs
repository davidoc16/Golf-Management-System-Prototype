namespace Golf365
{
    partial class frmMemAnl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberList = new System.Windows.Forms.GroupBox();
            this.lstSurname = new System.Windows.Forms.ListBox();
            this.lstMemId = new System.Windows.Forms.ListBox();
            this.lstForeName = new System.Windows.Forms.ListBox();
            this.Print = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.MemberList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 21;
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
            // MemberList
            // 
            this.MemberList.Controls.Add(this.lstSurname);
            this.MemberList.Controls.Add(this.lstMemId);
            this.MemberList.Controls.Add(this.lstForeName);
            this.MemberList.Location = new System.Drawing.Point(86, 106);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(384, 168);
            this.MemberList.TabIndex = 24;
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
            this.lstSurname.Location = new System.Drawing.Point(17, 19);
            this.lstSurname.Name = "lstSurname";
            this.lstSurname.Size = new System.Drawing.Size(349, 134);
            this.lstSurname.TabIndex = 26;
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
            this.lstMemId.Location = new System.Drawing.Point(17, 19);
            this.lstMemId.Name = "lstMemId";
            this.lstMemId.Size = new System.Drawing.Size(349, 134);
            this.lstMemId.TabIndex = 7;
            this.lstMemId.Visible = false;
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
            this.lstForeName.Location = new System.Drawing.Point(17, 19);
            this.lstForeName.Name = "lstForeName";
            this.lstForeName.Size = new System.Drawing.Size(349, 134);
            this.lstForeName.TabIndex = 25;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(377, 283);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 23;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(86, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 58);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Order";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(215, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Forename";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(142, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Surname";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Membership Id";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmMemAnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 335);
            this.Controls.Add(this.MemberList);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMemAnl";
            this.Text = "Golf 365 - Member Analysis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MemberList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.GroupBox MemberList;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox lstMemId;
        private System.Windows.Forms.ListBox lstForeName;
        private System.Windows.Forms.ListBox lstSurname;
    }
}