namespace UI
{
    partial class SinhVienMenuForm
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
            this.dangkyhocphanbttn = new System.Windows.Forms.Button();
            this.xemketquahocphanbttn = new System.Windows.Forms.Button();
            this.xemthongtincanhanbttn = new System.Windows.Forms.Button();
            this.logoutbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dangkyhocphanbttn
            // 
            this.dangkyhocphanbttn.Location = new System.Drawing.Point(45, 53);
            this.dangkyhocphanbttn.Name = "dangkyhocphanbttn";
            this.dangkyhocphanbttn.Size = new System.Drawing.Size(261, 56);
            this.dangkyhocphanbttn.TabIndex = 0;
            this.dangkyhocphanbttn.Text = "Đăng ký học phần";
            this.dangkyhocphanbttn.UseVisualStyleBackColor = true;
            this.dangkyhocphanbttn.Click += new System.EventHandler(this.dangkyhocphanbttn_Click);
            // 
            // xemketquahocphanbttn
            // 
            this.xemketquahocphanbttn.Location = new System.Drawing.Point(45, 137);
            this.xemketquahocphanbttn.Name = "xemketquahocphanbttn";
            this.xemketquahocphanbttn.Size = new System.Drawing.Size(261, 56);
            this.xemketquahocphanbttn.TabIndex = 2;
            this.xemketquahocphanbttn.Text = "Xem kết quả học phần";
            this.xemketquahocphanbttn.UseVisualStyleBackColor = true;
            this.xemketquahocphanbttn.Click += new System.EventHandler(this.xemketquahocphanbttn_Click);
            // 
            // xemthongtincanhanbttn
            // 
            this.xemthongtincanhanbttn.Location = new System.Drawing.Point(45, 225);
            this.xemthongtincanhanbttn.Name = "xemthongtincanhanbttn";
            this.xemthongtincanhanbttn.Size = new System.Drawing.Size(261, 56);
            this.xemthongtincanhanbttn.TabIndex = 3;
            this.xemthongtincanhanbttn.Text = "Xem thông tin cá nhân";
            this.xemthongtincanhanbttn.UseVisualStyleBackColor = true;
            // 
            // logoutbttn
            // 
            this.logoutbttn.Location = new System.Drawing.Point(99, 321);
            this.logoutbttn.Name = "logoutbttn";
            this.logoutbttn.Size = new System.Drawing.Size(158, 44);
            this.logoutbttn.TabIndex = 4;
            this.logoutbttn.Text = "Logout";
            this.logoutbttn.UseVisualStyleBackColor = true;
            this.logoutbttn.Click += new System.EventHandler(this.logoutbttn_Click);
            // 
            // SinhVienMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 399);
            this.Controls.Add(this.logoutbttn);
            this.Controls.Add(this.xemthongtincanhanbttn);
            this.Controls.Add(this.xemketquahocphanbttn);
            this.Controls.Add(this.dangkyhocphanbttn);
            this.Name = "SinhVienMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinhVienMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dangkyhocphanbttn;
        private System.Windows.Forms.Button xemketquahocphanbttn;
        private System.Windows.Forms.Button xemthongtincanhanbttn;
        private System.Windows.Forms.Button logoutbttn;
    }
}