namespace GiaoDien
{
    partial class Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.button_XoaRole = new System.Windows.Forms.Button();
            this.button_TaoRole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_XoaRole
            // 
            this.button_XoaRole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_XoaRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XoaRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_XoaRole.Image = ((System.Drawing.Image)(resources.GetObject("button_XoaRole.Image")));
            this.button_XoaRole.Location = new System.Drawing.Point(287, 179);
            this.button_XoaRole.Name = "button_XoaRole";
            this.button_XoaRole.Size = new System.Drawing.Size(184, 147);
            this.button_XoaRole.TabIndex = 31;
            this.button_XoaRole.Text = "Xóa role";
            this.button_XoaRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_XoaRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_XoaRole.UseMnemonic = false;
            this.button_XoaRole.UseVisualStyleBackColor = false;
            this.button_XoaRole.Click += new System.EventHandler(this.button_XoaRole_Click);
            // 
            // button_TaoRole
            // 
            this.button_TaoRole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_TaoRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TaoRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_TaoRole.Image = ((System.Drawing.Image)(resources.GetObject("button_TaoRole.Image")));
            this.button_TaoRole.Location = new System.Drawing.Point(45, 179);
            this.button_TaoRole.Name = "button_TaoRole";
            this.button_TaoRole.Size = new System.Drawing.Size(184, 147);
            this.button_TaoRole.TabIndex = 28;
            this.button_TaoRole.Text = "Tạo role mới";
            this.button_TaoRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_TaoRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_TaoRole.UseMnemonic = false;
            this.button_TaoRole.UseVisualStyleBackColor = false;
            this.button_TaoRole.Click += new System.EventHandler(this.button_TaoRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(102, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 58);
            this.label2.TabIndex = 32;
            this.label2.Text = "Quản lý role";
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_XoaRole);
            this.Controls.Add(this.button_TaoRole);
            this.Name = "Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_TaoRole;
        private System.Windows.Forms.Button button_XoaRole;
        private System.Windows.Forms.Label label2;
    }
}