namespace UI
{
    partial class XemKetQuaHocPhanForm
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
            this.namhoccb = new System.Windows.Forms.ComboBox();
            this.hockycb = new System.Windows.Forms.ComboBox();
            this.hockylb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kqhocphanlv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // namhoccb
            // 
            this.namhoccb.FormattingEnabled = true;
            this.namhoccb.Location = new System.Drawing.Point(486, 25);
            this.namhoccb.Name = "namhoccb";
            this.namhoccb.Size = new System.Drawing.Size(265, 28);
            this.namhoccb.TabIndex = 0;
            // 
            // hockycb
            // 
            this.hockycb.FormattingEnabled = true;
            this.hockycb.Location = new System.Drawing.Point(154, 25);
            this.hockycb.Name = "hockycb";
            this.hockycb.Size = new System.Drawing.Size(96, 28);
            this.hockycb.TabIndex = 1;
            // 
            // hockylb
            // 
            this.hockylb.AutoSize = true;
            this.hockylb.Location = new System.Drawing.Point(83, 28);
            this.hockylb.Name = "hockylb";
            this.hockylb.Size = new System.Drawing.Size(65, 20);
            this.hockylb.TabIndex = 2;
            this.hockylb.Text = "Học kỳ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm học:";
            // 
            // kqhocphanlv
            // 
            this.kqhocphanlv.HideSelection = false;
            this.kqhocphanlv.Location = new System.Drawing.Point(37, 74);
            this.kqhocphanlv.Name = "kqhocphanlv";
            this.kqhocphanlv.Size = new System.Drawing.Size(731, 347);
            this.kqhocphanlv.TabIndex = 4;
            this.kqhocphanlv.UseCompatibleStateImageBehavior = false;
            // 
            // XemKetQuaHocPhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kqhocphanlv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hockylb);
            this.Controls.Add(this.hockycb);
            this.Controls.Add(this.namhoccb);
            this.Name = "XemKetQuaHocPhanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemKetQuaHocPhanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemKetQuaHocPhanForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox namhoccb;
        private System.Windows.Forms.ComboBox hockycb;
        private System.Windows.Forms.Label hockylb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView kqhocphanlv;
    }
}