namespace UI
{
    partial class XemDanhSachSVMonHocForm
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
            this.dsdangkylv = new System.Windows.Forms.ListView();
            this.monlb = new System.Windows.Forms.Label();
            this.loplb = new System.Windows.Forms.Label();
            this.lopcb = new System.Windows.Forms.ComboBox();
            this.monhoccb = new System.Windows.Forms.ComboBox();
            this.capnhatdiembttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dsdangkylv
            // 
            this.dsdangkylv.HideSelection = false;
            this.dsdangkylv.Location = new System.Drawing.Point(35, 72);
            this.dsdangkylv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsdangkylv.Name = "dsdangkylv";
            this.dsdangkylv.Size = new System.Drawing.Size(643, 262);
            this.dsdangkylv.TabIndex = 9;
            this.dsdangkylv.UseCompatibleStateImageBehavior = false;
            // 
            // monlb
            // 
            this.monlb.AutoSize = true;
            this.monlb.Location = new System.Drawing.Point(50, 30);
            this.monlb.Name = "monlb";
            this.monlb.Size = new System.Drawing.Size(66, 17);
            this.monlb.TabIndex = 8;
            this.monlb.Text = "Môn học:";
            // 
            // loplb
            // 
            this.loplb.AutoSize = true;
            this.loplb.Location = new System.Drawing.Point(440, 30);
            this.loplb.Name = "loplb";
            this.loplb.Size = new System.Drawing.Size(36, 17);
            this.loplb.TabIndex = 7;
            this.loplb.Text = "Lớp:";
            // 
            // lopcb
            // 
            this.lopcb.FormattingEnabled = true;
            this.lopcb.Location = new System.Drawing.Point(490, 27);
            this.lopcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopcb.Name = "lopcb";
            this.lopcb.Size = new System.Drawing.Size(162, 24);
            this.lopcb.TabIndex = 6;
            // 
            // monhoccb
            // 
            this.monhoccb.FormattingEnabled = true;
            this.monhoccb.Location = new System.Drawing.Point(129, 27);
            this.monhoccb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monhoccb.Name = "monhoccb";
            this.monhoccb.Size = new System.Drawing.Size(200, 24);
            this.monhoccb.TabIndex = 5;
            this.monhoccb.SelectedIndexChanged += new System.EventHandler(this.monhoccb_SelectedIndexChanged);
            // 
            // capnhatdiembttn
            // 
            this.capnhatdiembttn.Location = new System.Drawing.Point(260, 353);
            this.capnhatdiembttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capnhatdiembttn.Name = "capnhatdiembttn";
            this.capnhatdiembttn.Size = new System.Drawing.Size(164, 26);
            this.capnhatdiembttn.TabIndex = 10;
            this.capnhatdiembttn.Text = "Cập nhật điểm";
            this.capnhatdiembttn.UseVisualStyleBackColor = true;
            this.capnhatdiembttn.Click += new System.EventHandler(this.capnhatdiembttn_Click);
            // 
            // XemDanhSachSVMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 398);
            this.Controls.Add(this.capnhatdiembttn);
            this.Controls.Add(this.dsdangkylv);
            this.Controls.Add(this.monlb);
            this.Controls.Add(this.loplb);
            this.Controls.Add(this.lopcb);
            this.Controls.Add(this.monhoccb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XemDanhSachSVMonHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemDanhSachSVMonHocForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemDanhSachSVMonHocForm_FormClosing);
            this.Load += new System.EventHandler(this.XemDanhSachSVMonHocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dsdangkylv;
        private System.Windows.Forms.Label monlb;
        private System.Windows.Forms.Label loplb;
        private System.Windows.Forms.ComboBox lopcb;
        private System.Windows.Forms.ComboBox monhoccb;
        private System.Windows.Forms.Button capnhatdiembttn;
    }
}