namespace UI
{
    partial class GiaoVuMenuForm
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
            this.dssvbttn = new System.Windows.Forms.Button();
            this.modkmhbttn = new System.Windows.Forms.Button();
            this.dsdkmhbttn = new System.Windows.Forms.Button();
            this.ttcanhanbttn = new System.Windows.Forms.Button();
            this.logoutbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dssvbttn
            // 
            this.dssvbttn.Location = new System.Drawing.Point(38, 47);
            this.dssvbttn.Name = "dssvbttn";
            this.dssvbttn.Size = new System.Drawing.Size(208, 66);
            this.dssvbttn.TabIndex = 0;
            this.dssvbttn.Text = "Xem danh sách sinh viên";
            this.dssvbttn.UseVisualStyleBackColor = true;
            this.dssvbttn.Click += new System.EventHandler(this.dssvbttn_Click);
            // 
            // modkmhbttn
            // 
            this.modkmhbttn.Location = new System.Drawing.Point(38, 156);
            this.modkmhbttn.Name = "modkmhbttn";
            this.modkmhbttn.Size = new System.Drawing.Size(208, 66);
            this.modkmhbttn.TabIndex = 1;
            this.modkmhbttn.Text = "Mở đăng ký môn học";
            this.modkmhbttn.UseVisualStyleBackColor = true;
            this.modkmhbttn.Click += new System.EventHandler(this.modkmhbttn_Click);
            // 
            // dsdkmhbttn
            // 
            this.dsdkmhbttn.Location = new System.Drawing.Point(288, 47);
            this.dsdkmhbttn.Name = "dsdkmhbttn";
            this.dsdkmhbttn.Size = new System.Drawing.Size(208, 66);
            this.dsdkmhbttn.TabIndex = 2;
            this.dsdkmhbttn.Text = "Xem danh sách đăng ký môn học";
            this.dsdkmhbttn.UseVisualStyleBackColor = true;
            this.dsdkmhbttn.Click += new System.EventHandler(this.dsdkmhbttn_Click);
            // 
            // ttcanhanbttn
            // 
            this.ttcanhanbttn.Location = new System.Drawing.Point(544, 47);
            this.ttcanhanbttn.Name = "ttcanhanbttn";
            this.ttcanhanbttn.Size = new System.Drawing.Size(208, 66);
            this.ttcanhanbttn.TabIndex = 3;
            this.ttcanhanbttn.Text = "Xem thông tin cá nhân";
            this.ttcanhanbttn.UseVisualStyleBackColor = true;
            // 
            // logoutbttn
            // 
            this.logoutbttn.Location = new System.Drawing.Point(325, 252);
            this.logoutbttn.Name = "logoutbttn";
            this.logoutbttn.Size = new System.Drawing.Size(134, 45);
            this.logoutbttn.TabIndex = 4;
            this.logoutbttn.Text = "Logout";
            this.logoutbttn.UseVisualStyleBackColor = true;
            this.logoutbttn.Click += new System.EventHandler(this.logoutbttn_Click);
            // 
            // GiaoVuMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 326);
            this.Controls.Add(this.logoutbttn);
            this.Controls.Add(this.ttcanhanbttn);
            this.Controls.Add(this.dsdkmhbttn);
            this.Controls.Add(this.modkmhbttn);
            this.Controls.Add(this.dssvbttn);
            this.Name = "GiaoVuMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoVuMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dssvbttn;
        private System.Windows.Forms.Button modkmhbttn;
        private System.Windows.Forms.Button dsdkmhbttn;
        private System.Windows.Forms.Button ttcanhanbttn;
        private System.Windows.Forms.Button logoutbttn;
    }
}