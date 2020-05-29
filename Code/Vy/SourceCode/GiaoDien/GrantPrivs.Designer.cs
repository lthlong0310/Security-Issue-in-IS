namespace GiaoDien
{
    partial class GrantPrivs
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_Search_DsUser = new System.Windows.Forms.Button();
            this.comboBox_DsUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ListQuyen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_grant = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_option = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(124, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 48);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cấp quyền của user";
            // 
            // button_Search_DsUser
            // 
            this.button_Search_DsUser.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_Search_DsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search_DsUser.ForeColor = System.Drawing.Color.White;
            this.button_Search_DsUser.Location = new System.Drawing.Point(415, 120);
            this.button_Search_DsUser.Name = "button_Search_DsUser";
            this.button_Search_DsUser.Size = new System.Drawing.Size(99, 39);
            this.button_Search_DsUser.TabIndex = 36;
            this.button_Search_DsUser.Text = "Search";
            this.button_Search_DsUser.UseVisualStyleBackColor = false;
            this.button_Search_DsUser.Click += new System.EventHandler(this.button_Search_DsUser_Click);
            // 
            // comboBox_DsUser
            // 
            this.comboBox_DsUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DsUser.FormattingEnabled = true;
            this.comboBox_DsUser.Location = new System.Drawing.Point(182, 131);
            this.comboBox_DsUser.Name = "comboBox_DsUser";
            this.comboBox_DsUser.Size = new System.Drawing.Size(227, 24);
            this.comboBox_DsUser.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Chọn username:";
            // 
            // comboBox_ListQuyen
            // 
            this.comboBox_ListQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ListQuyen.FormattingEnabled = true;
            this.comboBox_ListQuyen.Items.AddRange(new object[] {
            "create session",
            "create user",
            "drop user",
            "create role",
            "create table",
            "insert any table",
            "update any table",
            "select any table",
            "create procedure",
            "drop any procedure",
            "drop any table"});
            this.comboBox_ListQuyen.Location = new System.Drawing.Point(182, 191);
            this.comboBox_ListQuyen.Name = "comboBox_ListQuyen";
            this.comboBox_ListQuyen.Size = new System.Drawing.Size(227, 24);
            this.comboBox_ListQuyen.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Chọn quyền:";
            // 
            // button_grant
            // 
            this.button_grant.BackColor = System.Drawing.Color.Green;
            this.button_grant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grant.ForeColor = System.Drawing.Color.White;
            this.button_grant.Location = new System.Drawing.Point(182, 287);
            this.button_grant.Name = "button_grant";
            this.button_grant.Size = new System.Drawing.Size(110, 39);
            this.button_grant.TabIndex = 39;
            this.button_grant.Text = "Grant";
            this.button_grant.UseVisualStyleBackColor = false;
            this.button_grant.Click += new System.EventHandler(this.button_grant_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(310, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 40;
            this.button1.Text = "Revoke";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_option
            // 
            this.checkBox_option.AutoSize = true;
            this.checkBox_option.Location = new System.Drawing.Point(434, 196);
            this.checkBox_option.Name = "checkBox_option";
            this.checkBox_option.Size = new System.Drawing.Size(139, 21);
            this.checkBox_option.TabIndex = 42;
            this.checkBox_option.Text = "with admin option";
            this.checkBox_option.UseVisualStyleBackColor = true;
            // 
            // GrantPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 369);
            this.Controls.Add(this.checkBox_option);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_grant);
            this.Controls.Add(this.comboBox_ListQuyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Search_DsUser);
            this.Controls.Add(this.comboBox_DsUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "GrantPrivs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantPrivs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Search_DsUser;
        private System.Windows.Forms.ComboBox comboBox_DsUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ListQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_grant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_option;
    }
}