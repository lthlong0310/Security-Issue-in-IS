﻿namespace UI
{
    partial class LoginForm
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
            this.titlelb = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.usernamelb = new System.Windows.Forms.Label();
            this.passwordlb = new System.Windows.Forms.Label();
            this.loginbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelb
            // 
            this.titlelb.AutoSize = true;
            this.titlelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelb.Location = new System.Drawing.Point(68, 31);
            this.titlelb.Name = "titlelb";
            this.titlelb.Size = new System.Drawing.Size(551, 39);
            this.titlelb.TabIndex = 0;
            this.titlelb.Text = "Hệ thống quản lý đăng ký học phần";
            this.titlelb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernametb
            // 
            this.usernametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usernametb.Location = new System.Drawing.Point(214, 104);
            this.usernametb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(429, 34);
            this.usernametb.TabIndex = 1;
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordtb.Location = new System.Drawing.Point(214, 162);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(429, 34);
            this.passwordtb.TabIndex = 2;
            // 
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelb.Location = new System.Drawing.Point(49, 104);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(136, 29);
            this.usernamelb.TabIndex = 3;
            this.usernamelb.Text = "Username: ";
            // 
            // passwordlb
            // 
            this.passwordlb.AutoSize = true;
            this.passwordlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlb.Location = new System.Drawing.Point(49, 162);
            this.passwordlb.Name = "passwordlb";
            this.passwordlb.Size = new System.Drawing.Size(132, 29);
            this.passwordlb.TabIndex = 4;
            this.passwordlb.Text = "Password: ";
            // 
            // loginbttn
            // 
            this.loginbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbttn.Location = new System.Drawing.Point(316, 221);
            this.loginbttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbttn.Name = "loginbttn";
            this.loginbttn.Size = new System.Drawing.Size(177, 43);
            this.loginbttn.TabIndex = 5;
            this.loginbttn.Text = "Log in";
            this.loginbttn.UseVisualStyleBackColor = true;
            this.loginbttn.Click += new System.EventHandler(this.loginbttn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 305);
            this.Controls.Add(this.loginbttn);
            this.Controls.Add(this.passwordlb);
            this.Controls.Add(this.usernamelb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.titlelb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelb;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.Label passwordlb;
        private System.Windows.Forms.Button loginbttn;
    }
}