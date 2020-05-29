namespace GiaoDien
{
    partial class FormQuyen
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
            this.listView_ThongTinQuyen = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Privilege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin_option = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Common = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inherited = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Cancle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_ThongTinQuyen
            // 
            this.listView_ThongTinQuyen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Privilege,
            this.Admin_option,
            this.Common,
            this.Inherited});
            this.listView_ThongTinQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ThongTinQuyen.HideSelection = false;
            this.listView_ThongTinQuyen.Location = new System.Drawing.Point(0, 145);
            this.listView_ThongTinQuyen.Name = "listView_ThongTinQuyen";
            this.listView_ThongTinQuyen.Size = new System.Drawing.Size(1054, 344);
            this.listView_ThongTinQuyen.TabIndex = 0;
            this.listView_ThongTinQuyen.UseCompatibleStateImageBehavior = false;
            this.listView_ThongTinQuyen.View = System.Windows.Forms.View.Details;
            this.listView_ThongTinQuyen.SelectedIndexChanged += new System.EventHandler(this.listView_ThongTinQuyen_SelectedIndexChanged);
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 130;
            // 
            // Privilege
            // 
            this.Privilege.Text = "Privilege";
            this.Privilege.Width = 317;
            // 
            // Admin_option
            // 
            this.Admin_option.Text = "Admin_option";
            this.Admin_option.Width = 141;
            // 
            // Common
            // 
            this.Common.Text = "Common";
            this.Common.Width = 110;
            // 
            // Inherited
            // 
            this.Inherited.Text = "Inherited";
            this.Inherited.Width = 127;
            // 
            // button_Cancle
            // 
            this.button_Cancle.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancle.ForeColor = System.Drawing.Color.White;
            this.button_Cancle.Location = new System.Drawing.Point(914, 519);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(140, 53);
            this.button_Cancle.TabIndex = 24;
            this.button_Cancle.Text = "Cancel";
            this.button_Cancle.UseVisualStyleBackColor = false;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 48);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thông tin về quyền của user";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(739, 519);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(140, 53);
            this.button_search.TabIndex = 22;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(839, 94);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(180, 29);
            this.textBox_username.TabIndex = 26;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Điền vào username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 618);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.listView_ThongTinQuyen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ThongTinQuyen;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Privilege;
        private System.Windows.Forms.ColumnHeader Admin_option;
        private System.Windows.Forms.ColumnHeader Common;
        private System.Windows.Forms.ColumnHeader Inherited;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label1;
    }
}