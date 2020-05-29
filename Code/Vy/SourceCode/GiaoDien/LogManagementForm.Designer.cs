namespace GiaoDien
{
    partial class LogManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogManagementForm));
            this.label2 = new System.Windows.Forms.Label();
            this.CheckLogBtn = new System.Windows.Forms.Button();
            this.AuditConditionBtn = new System.Windows.Forms.Button();
            this.AuditAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(261, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 58);
            this.label2.TabIndex = 33;
            this.label2.Text = "Quản lý nhật ký";
            // 
            // CheckLogBtn
            // 
            this.CheckLogBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLogBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckLogBtn.Image = ((System.Drawing.Image)(resources.GetObject("CheckLogBtn.Image")));
            this.CheckLogBtn.Location = new System.Drawing.Point(634, 162);
            this.CheckLogBtn.Name = "CheckLogBtn";
            this.CheckLogBtn.Size = new System.Drawing.Size(184, 147);
            this.CheckLogBtn.TabIndex = 34;
            this.CheckLogBtn.Text = "Kiểm tra nhật ký";
            this.CheckLogBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheckLogBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CheckLogBtn.UseMnemonic = false;
            this.CheckLogBtn.UseVisualStyleBackColor = false;
            this.CheckLogBtn.Click += new System.EventHandler(this.CheckLogBtn_Click);
            // 
            // AuditConditionBtn
            // 
            this.AuditConditionBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AuditConditionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuditConditionBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AuditConditionBtn.Image = ((System.Drawing.Image)(resources.GetObject("AuditConditionBtn.Image")));
            this.AuditConditionBtn.Location = new System.Drawing.Point(341, 162);
            this.AuditConditionBtn.Name = "AuditConditionBtn";
            this.AuditConditionBtn.Size = new System.Drawing.Size(184, 147);
            this.AuditConditionBtn.TabIndex = 32;
            this.AuditConditionBtn.Text = "Quản lý nhật ký chỉ định";
            this.AuditConditionBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AuditConditionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AuditConditionBtn.UseMnemonic = false;
            this.AuditConditionBtn.UseVisualStyleBackColor = false;
            this.AuditConditionBtn.Click += new System.EventHandler(this.AuditConditionBtn_Click);
            // 
            // AuditAllBtn
            // 
            this.AuditAllBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AuditAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuditAllBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AuditAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("AuditAllBtn.Image")));
            this.AuditAllBtn.Location = new System.Drawing.Point(48, 162);
            this.AuditAllBtn.Name = "AuditAllBtn";
            this.AuditAllBtn.Size = new System.Drawing.Size(184, 147);
            this.AuditAllBtn.TabIndex = 31;
            this.AuditAllBtn.Text = "Quản lý nhật ký toàn hệ thống";
            this.AuditAllBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AuditAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AuditAllBtn.UseMnemonic = false;
            this.AuditAllBtn.UseVisualStyleBackColor = false;
            this.AuditAllBtn.Click += new System.EventHandler(this.AuditAllBtn_Click);
            // 
            // LogManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 351);
            this.Controls.Add(this.CheckLogBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuditConditionBtn);
            this.Controls.Add(this.AuditAllBtn);
            this.Name = "LogManagementForm";
            this.Text = "LogManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckLogBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AuditConditionBtn;
        private System.Windows.Forms.Button AuditAllBtn;
    }
}