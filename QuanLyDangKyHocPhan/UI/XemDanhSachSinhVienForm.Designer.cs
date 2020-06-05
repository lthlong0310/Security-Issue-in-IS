namespace UI
{
    partial class XemDanhSachSinhVienForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.loplb = new System.Windows.Forms.Label();
            this.lopcb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 293);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // loplb
            // 
            this.loplb.AutoSize = true;
            this.loplb.Location = new System.Drawing.Point(43, 48);
            this.loplb.Name = "loplb";
            this.loplb.Size = new System.Drawing.Size(40, 20);
            this.loplb.TabIndex = 4;
            this.loplb.Text = "Lớp:";
            // 
            // lopcb
            // 
            this.lopcb.FormattingEnabled = true;
            this.lopcb.Location = new System.Drawing.Point(99, 45);
            this.lopcb.Name = "lopcb";
            this.lopcb.Size = new System.Drawing.Size(182, 28);
            this.lopcb.TabIndex = 3;
            // 
            // XemDanhSachSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loplb);
            this.Controls.Add(this.lopcb);
            this.Controls.Add(this.listView1);
            this.Name = "XemDanhSachSinhVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemDanhSachSinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label loplb;
        private System.Windows.Forms.ComboBox lopcb;
    }
}