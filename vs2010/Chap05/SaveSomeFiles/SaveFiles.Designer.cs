namespace SaveSomeFiles
{
    partial class SaveFiles
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
            this.CLB = new System.Windows.Forms.CheckedListBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLB
            // 
            this.CLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.CLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLB.FormattingEnabled = true;
            this.CLB.Location = new System.Drawing.Point(0, 0);
            this.CLB.Name = "CLB";
            this.CLB.Size = new System.Drawing.Size(773, 319);
            this.CLB.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveBtn.Location = new System.Drawing.Point(698, 319);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 41);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "&SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBTN.Location = new System.Drawing.Point(623, 319);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 41);
            this.CancelBTN.TabIndex = 2;
            this.CancelBTN.Text = "&Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // SaveFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 360);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SaveFiles";
            this.Text = "Select Files to Save";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBTN;
        public System.Windows.Forms.CheckedListBox CLB;
    }
}