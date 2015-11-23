namespace Golf365
{
    partial class frmGolfCreate
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
            this.cmbCreate = new System.Windows.Forms.ComboBox();
            this.SelectMemberType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCreate
            // 
            this.cmbCreate.FormattingEnabled = true;
            this.cmbCreate.Items.AddRange(new object[] {
            "NR New Release  5.00",
            "OR Old Release    5.00"});
            this.cmbCreate.Location = new System.Drawing.Point(78, 65);
            this.cmbCreate.Name = "cmbCreate";
            this.cmbCreate.Size = new System.Drawing.Size(216, 21);
            this.cmbCreate.TabIndex = 0;
            // 
            // SelectMemberType
            // 
            this.SelectMemberType.AutoSize = true;
            this.SelectMemberType.Location = new System.Drawing.Point(4, 68);
            this.SelectMemberType.Name = "SelectMemberType";
            this.SelectMemberType.Size = new System.Drawing.Size(68, 13);
            this.SelectMemberType.TabIndex = 1;
            this.SelectMemberType.Text = "memberType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // frmGolfCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectMemberType);
            this.Controls.Add(this.cmbCreate);
            this.Name = "frmGolfCreate";
            this.Text = "frmGolfCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCreate;
        private System.Windows.Forms.Label SelectMemberType;
        private System.Windows.Forms.Label label1;
    }
}