﻿namespace GiaoDien
{
    partial class DsUser
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
            this.listView_DsUser = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_DsUser
            // 
            this.listView_DsUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username});
            this.listView_DsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_DsUser.HideSelection = false;
            this.listView_DsUser.Location = new System.Drawing.Point(59, 137);
            this.listView_DsUser.Name = "listView_DsUser";
            this.listView_DsUser.Size = new System.Drawing.Size(326, 311);
            this.listView_DsUser.TabIndex = 0;
            this.listView_DsUser.UseCompatibleStateImageBehavior = false;
            this.listView_DsUser.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 281;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(59, 471);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(140, 53);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(90, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 48);
            this.label2.TabIndex = 20;
            this.label2.Text = "Danh sách ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "người dùng hệ thống";
            // 
            // button_Cancle
            // 
            this.button_Cancle.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancle.ForeColor = System.Drawing.Color.White;
            this.button_Cancle.Location = new System.Drawing.Point(245, 471);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(140, 53);
            this.button_Cancle.TabIndex = 23;
            this.button_Cancle.Text = "Cancle";
            this.button_Cancle.UseVisualStyleBackColor = false;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click_1);
            // 
            // DsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 536);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.listView_DsUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DsUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DsUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_DsUser;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancle;
    }
}