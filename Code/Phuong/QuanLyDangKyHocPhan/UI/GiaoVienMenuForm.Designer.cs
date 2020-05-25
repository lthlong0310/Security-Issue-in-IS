namespace UI
{
    partial class GiaoVienMenuForm
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
            this.dssvmhbttn = new System.Windows.Forms.Button();
            this.ttcnbttn = new System.Windows.Forms.Button();
            this.logoutbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dssvmhbttn
            // 
            this.dssvmhbttn.Location = new System.Drawing.Point(108, 60);
            this.dssvmhbttn.Name = "dssvmhbttn";
            this.dssvmhbttn.Size = new System.Drawing.Size(196, 66);
            this.dssvmhbttn.TabIndex = 0;
            this.dssvmhbttn.Text = "Xem danh sách sinh viên môn học";
            this.dssvmhbttn.UseVisualStyleBackColor = true;
            this.dssvmhbttn.Click += new System.EventHandler(this.dssvmhbttn_Click);
            // 
            // ttcnbttn
            // 
            this.ttcnbttn.Location = new System.Drawing.Point(108, 151);
            this.ttcnbttn.Name = "ttcnbttn";
            this.ttcnbttn.Size = new System.Drawing.Size(196, 66);
            this.ttcnbttn.TabIndex = 1;
            this.ttcnbttn.Text = "Xem thông tin cá nhân";
            this.ttcnbttn.UseVisualStyleBackColor = true;
            // 
            // logoutbttn
            // 
            this.logoutbttn.Location = new System.Drawing.Point(134, 264);
            this.logoutbttn.Name = "logoutbttn";
            this.logoutbttn.Size = new System.Drawing.Size(139, 45);
            this.logoutbttn.TabIndex = 2;
            this.logoutbttn.Text = "Logout";
            this.logoutbttn.UseVisualStyleBackColor = true;
            this.logoutbttn.Click += new System.EventHandler(this.logoutbttn_Click);
            // 
            // GiaoVienMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 366);
            this.Controls.Add(this.logoutbttn);
            this.Controls.Add(this.ttcnbttn);
            this.Controls.Add(this.dssvmhbttn);
            this.Name = "GiaoVienMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoVienMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dssvmhbttn;
        private System.Windows.Forms.Button ttcnbttn;
        private System.Windows.Forms.Button logoutbttn;
    }
}