namespace GiaoDien
{
    partial class FormQuyenUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_dsQuyen = new System.Windows.Forms.ComboBox();
            this.button_Search_DsQuyen = new System.Windows.Forms.Button();
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
            this.listView_ThongTinQuyen.Location = new System.Drawing.Point(12, 193);
            this.listView_ThongTinQuyen.Name = "listView_ThongTinQuyen";
            this.listView_ThongTinQuyen.Size = new System.Drawing.Size(1046, 368);
            this.listView_ThongTinQuyen.TabIndex = 27;
            this.listView_ThongTinQuyen.UseCompatibleStateImageBehavior = false;
            this.listView_ThongTinQuyen.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chọn username:";
            // 
            // button_Cancle
            // 
            this.button_Cancle.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancle.ForeColor = System.Drawing.Color.White;
            this.button_Cancle.Location = new System.Drawing.Point(918, 580);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(140, 53);
            this.button_Cancle.TabIndex = 30;
            this.button_Cancle.Text = "Cancel";
            this.button_Cancle.UseVisualStyleBackColor = false;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(183, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 48);
            this.label2.TabIndex = 29;
            this.label2.Text = "Thông tin về quyền của user";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(743, 580);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(140, 53);
            this.button_search.TabIndex = 28;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_dsQuyen
            // 
            this.comboBox_dsQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dsQuyen.FormattingEnabled = true;
            this.comboBox_dsQuyen.Location = new System.Drawing.Point(686, 141);
            this.comboBox_dsQuyen.Name = "comboBox_dsQuyen";
            this.comboBox_dsQuyen.Size = new System.Drawing.Size(227, 24);
            this.comboBox_dsQuyen.TabIndex = 32;
            // 
            // button_Search_DsQuyen
            // 
            this.button_Search_DsQuyen.BackColor = System.Drawing.Color.Teal;
            this.button_Search_DsQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search_DsQuyen.ForeColor = System.Drawing.Color.Transparent;
            this.button_Search_DsQuyen.Location = new System.Drawing.Point(940, 137);
            this.button_Search_DsQuyen.Name = "button_Search_DsQuyen";
            this.button_Search_DsQuyen.Size = new System.Drawing.Size(92, 34);
            this.button_Search_DsQuyen.TabIndex = 33;
            this.button_Search_DsQuyen.Text = "Load";
            this.button_Search_DsQuyen.UseVisualStyleBackColor = false;
            this.button_Search_DsQuyen.Click += new System.EventHandler(this.button_Search_DsQuyen_Click);
            // 
            // FormQuyenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 645);
            this.Controls.Add(this.button_Search_DsQuyen);
            this.Controls.Add(this.comboBox_dsQuyen);
            this.Controls.Add(this.listView_ThongTinQuyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_search);
            this.Name = "FormQuyenUser";
            this.Text = "FormQuyenUser";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_dsQuyen;
        private System.Windows.Forms.Button button_Search_DsQuyen;
    }
}