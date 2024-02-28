namespace VS_Info
{
    partial class VSInfoForm
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
            this.TC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CLB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PN = new System.Windows.Forms.Panel();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ENVINFO = new System.Windows.Forms.TextBox();
            this.TC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PN.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC
            // 
            this.TC.Controls.Add(this.tabPage1);
            this.TC.Controls.Add(this.tabPage2);
            this.TC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC.Location = new System.Drawing.Point(0, 0);
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(675, 304);
            this.TC.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CLB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visual Studio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CLB
            // 
            this.CLB.BackColor = System.Drawing.SystemColors.Info;
            this.CLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CLB.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLB.Location = new System.Drawing.Point(3, 3);
            this.CLB.Multiline = true;
            this.CLB.Name = "CLB";
            this.CLB.ReadOnly = true;
            this.CLB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CLB.Size = new System.Drawing.Size(661, 272);
            this.CLB.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ENVINFO);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Environment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PN
            // 
            this.PN.Controls.Add(this.OKBtn);
            this.PN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN.Location = new System.Drawing.Point(0, 266);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(675, 38);
            this.PN.TabIndex = 1;
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Location = new System.Drawing.Point(586, 8);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(85, 23);
            this.OKBtn.TabIndex = 0;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // ENVINFO
            // 
            this.ENVINFO.BackColor = System.Drawing.SystemColors.Info;
            this.ENVINFO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ENVINFO.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENVINFO.Location = new System.Drawing.Point(3, 3);
            this.ENVINFO.Multiline = true;
            this.ENVINFO.Name = "ENVINFO";
            this.ENVINFO.ReadOnly = true;
            this.ENVINFO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ENVINFO.Size = new System.Drawing.Size(661, 272);
            this.ENVINFO.TabIndex = 1;
            // 
            // VSInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 304);
            this.Controls.Add(this.PN);
            this.Controls.Add(this.TC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VSInfoForm";
            this.Text = "Visual Studio Environment";
            this.TC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PN;
        private System.Windows.Forms.Button OKBtn;
        public System.Windows.Forms.TextBox CLB;
        public System.Windows.Forms.TextBox ENVINFO;
    }
}