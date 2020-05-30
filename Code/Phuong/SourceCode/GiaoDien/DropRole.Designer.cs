namespace GiaoDien
{
    partial class DropRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Search_Role = new System.Windows.Forms.Button();
            this.comboBox_ListRole = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(7, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Role name";
            // 
            // button_Search_Role
            // 
            this.button_Search_Role.BackColor = System.Drawing.Color.SandyBrown;
            this.button_Search_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search_Role.ForeColor = System.Drawing.Color.Black;
            this.button_Search_Role.Location = new System.Drawing.Point(325, 131);
            this.button_Search_Role.Name = "button_Search_Role";
            this.button_Search_Role.Size = new System.Drawing.Size(140, 53);
            this.button_Search_Role.TabIndex = 48;
            this.button_Search_Role.Text = "Search";
            this.button_Search_Role.UseVisualStyleBackColor = false;
            this.button_Search_Role.Click += new System.EventHandler(this.button_Search_Role_Click);
            // 
            // comboBox_ListRole
            // 
            this.comboBox_ListRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ListRole.FormattingEnabled = true;
            this.comboBox_ListRole.Location = new System.Drawing.Point(12, 148);
            this.comboBox_ListRole.Name = "comboBox_ListRole";
            this.comboBox_ListRole.Size = new System.Drawing.Size(284, 28);
            this.comboBox_ListRole.TabIndex = 47;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.SandyBrown;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(501, 218);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(140, 53);
            this.button_Cancel.TabIndex = 46;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.SandyBrown;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.ForeColor = System.Drawing.Color.Black;
            this.button_Submit.Location = new System.Drawing.Point(325, 218);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(140, 53);
            this.button_Submit.TabIndex = 45;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 48);
            this.label2.TabIndex = 44;
            this.label2.Text = "Drop role";
            // 
            // DropRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Search_Role);
            this.Controls.Add(this.comboBox_ListRole);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label2);
            this.Name = "DropRole";
            this.Text = "DropRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Search_Role;
        private System.Windows.Forms.ComboBox comboBox_ListRole;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label2;
    }
}