namespace UI
{
    partial class XemDanhSachDangKyMonHocForm
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
            this.monhoccb = new System.Windows.Forms.ComboBox();
            this.lopcb = new System.Windows.Forms.ComboBox();
            this.loplb = new System.Windows.Forms.Label();
            this.monlb = new System.Windows.Forms.Label();
            this.dsdangkylv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // monhoccb
            // 
            this.monhoccb.FormattingEnabled = true;
            this.monhoccb.Location = new System.Drawing.Point(145, 37);
            this.monhoccb.Name = "monhoccb";
            this.monhoccb.Size = new System.Drawing.Size(224, 28);
            this.monhoccb.TabIndex = 0;
            // 
            // lopcb
            // 
            this.lopcb.FormattingEnabled = true;
            this.lopcb.Location = new System.Drawing.Point(551, 37);
            this.lopcb.Name = "lopcb";
            this.lopcb.Size = new System.Drawing.Size(182, 28);
            this.lopcb.TabIndex = 1;
            // 
            // loplb
            // 
            this.loplb.AutoSize = true;
            this.loplb.Location = new System.Drawing.Point(495, 40);
            this.loplb.Name = "loplb";
            this.loplb.Size = new System.Drawing.Size(40, 20);
            this.loplb.TabIndex = 2;
            this.loplb.Text = "Lớp:";
            // 
            // monlb
            // 
            this.monlb.AutoSize = true;
            this.monlb.Location = new System.Drawing.Point(56, 40);
            this.monlb.Name = "monlb";
            this.monlb.Size = new System.Drawing.Size(74, 20);
            this.monlb.TabIndex = 3;
            this.monlb.Text = "Môn học:";
            // 
            // dsdangkylv
            // 
            this.dsdangkylv.HideSelection = false;
            this.dsdangkylv.Location = new System.Drawing.Point(39, 93);
            this.dsdangkylv.Name = "dsdangkylv";
            this.dsdangkylv.Size = new System.Drawing.Size(723, 327);
            this.dsdangkylv.TabIndex = 4;
            this.dsdangkylv.UseCompatibleStateImageBehavior = false;
            // 
            // XemDanhSachDangKyMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.dsdangkylv);
            this.Controls.Add(this.monlb);
            this.Controls.Add(this.loplb);
            this.Controls.Add(this.lopcb);
            this.Controls.Add(this.monhoccb);
            this.Name = "XemDanhSachDangKyMonHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemDanhSachDangKyMonHoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemDanhSachDangKyMonHocForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox monhoccb;
        private System.Windows.Forms.ComboBox lopcb;
        private System.Windows.Forms.Label loplb;
        private System.Windows.Forms.Label monlb;
        private System.Windows.Forms.ListView dsdangkylv;
    }
}