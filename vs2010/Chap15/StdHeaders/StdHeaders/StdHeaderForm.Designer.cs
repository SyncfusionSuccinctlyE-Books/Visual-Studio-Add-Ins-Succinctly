namespace StdHeaders
{
    partial class StdHeaderForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LANGCOMBO = new System.Windows.Forms.ComboBox();
            this.TYPECOMBO = new System.Windows.Forms.ComboBox();
            this.INCLUDECHECK = new System.Windows.Forms.CheckBox();
            this.CODEFILE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(385, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(228, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(309, 186);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Language:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(58, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code:";
            // 
            // LANGCOMBO
            // 
            this.LANGCOMBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LANGCOMBO.FormattingEnabled = true;
            this.LANGCOMBO.Items.AddRange(new object[] {
            "Visual C#",
            "Visual Basic"});
            this.LANGCOMBO.Location = new System.Drawing.Point(145, 34);
            this.LANGCOMBO.Name = "LANGCOMBO";
            this.LANGCOMBO.Size = new System.Drawing.Size(158, 26);
            this.LANGCOMBO.TabIndex = 6;
            // 
            // TYPECOMBO
            // 
            this.TYPECOMBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TYPECOMBO.FormattingEnabled = true;
            this.TYPECOMBO.Items.AddRange(new object[] {
            "Subroutine",
            "Function"});
            this.TYPECOMBO.Location = new System.Drawing.Point(145, 71);
            this.TYPECOMBO.Name = "TYPECOMBO";
            this.TYPECOMBO.Size = new System.Drawing.Size(158, 26);
            this.TYPECOMBO.TabIndex = 7;
            this.TYPECOMBO.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // INCLUDECHECK
            // 
            this.INCLUDECHECK.AutoSize = true;
            this.INCLUDECHECK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INCLUDECHECK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.INCLUDECHECK.Location = new System.Drawing.Point(145, 112);
            this.INCLUDECHECK.Name = "INCLUDECHECK";
            this.INCLUDECHECK.Size = new System.Drawing.Size(224, 22);
            this.INCLUDECHECK.TabIndex = 8;
            this.INCLUDECHECK.Text = "Include standard Variables";
            this.INCLUDECHECK.UseVisualStyleBackColor = true;
            this.INCLUDECHECK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CODEFILE
            // 
            this.CODEFILE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODEFILE.Location = new System.Drawing.Point(145, 140);
            this.CODEFILE.Name = "CODEFILE";
            this.CODEFILE.Size = new System.Drawing.Size(224, 24);
            this.CODEFILE.TabIndex = 9;
            // 
            // StdHeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 234);
            this.Controls.Add(this.CODEFILE);
            this.Controls.Add(this.INCLUDECHECK);
            this.Controls.Add(this.TYPECOMBO);
            this.Controls.Add(this.LANGCOMBO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StdHeaderForm";
            this.Text = "StdHeaderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox LANGCOMBO;
        public System.Windows.Forms.TextBox CODEFILE;
        public System.Windows.Forms.ComboBox TYPECOMBO;
        public System.Windows.Forms.CheckBox INCLUDECHECK;
    }
}