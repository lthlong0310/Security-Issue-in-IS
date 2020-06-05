namespace UI
{
    partial class CapNhatDiemForm
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
            this.gklb = new System.Windows.Forms.Label();
            this.khaclb = new System.Windows.Forms.Label();
            this.cklb = new System.Windows.Forms.Label();
            this.tonglb = new System.Windows.Forms.Label();
            this.capnhatbttn = new System.Windows.Forms.Button();
            this.gktb = new System.Windows.Forms.TextBox();
            this.khactb = new System.Windows.Forms.TextBox();
            this.tongtb = new System.Windows.Forms.TextBox();
            this.cktb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gklb
            // 
            this.gklb.AutoSize = true;
            this.gklb.Location = new System.Drawing.Point(42, 47);
            this.gklb.Name = "gklb";
            this.gklb.Size = new System.Drawing.Size(103, 20);
            this.gklb.TabIndex = 0;
            this.gklb.Text = "Điểm giữa kỳ:";
            // 
            // khaclb
            // 
            this.khaclb.AutoSize = true;
            this.khaclb.Location = new System.Drawing.Point(42, 105);
            this.khaclb.Name = "khaclb";
            this.khaclb.Size = new System.Drawing.Size(88, 20);
            this.khaclb.TabIndex = 2;
            this.khaclb.Text = "Điểm khác:";
            // 
            // cklb
            // 
            this.cklb.AutoSize = true;
            this.cklb.Location = new System.Drawing.Point(319, 47);
            this.cklb.Name = "cklb";
            this.cklb.Size = new System.Drawing.Size(102, 20);
            this.cklb.TabIndex = 3;
            this.cklb.Text = "Điểm cuối kỳ:";
            // 
            // tonglb
            // 
            this.tonglb.AutoSize = true;
            this.tonglb.Location = new System.Drawing.Point(319, 105);
            this.tonglb.Name = "tonglb";
            this.tonglb.Size = new System.Drawing.Size(86, 20);
            this.tonglb.TabIndex = 4;
            this.tonglb.Text = "Điểm tổng:";
            // 
            // capnhatbttn
            // 
            this.capnhatbttn.Location = new System.Drawing.Point(233, 159);
            this.capnhatbttn.Name = "capnhatbttn";
            this.capnhatbttn.Size = new System.Drawing.Size(144, 38);
            this.capnhatbttn.TabIndex = 5;
            this.capnhatbttn.Text = "Cập nhật";
            this.capnhatbttn.UseVisualStyleBackColor = true;
            // 
            // gktb
            // 
            this.gktb.Location = new System.Drawing.Point(164, 44);
            this.gktb.Name = "gktb";
            this.gktb.Size = new System.Drawing.Size(100, 26);
            this.gktb.TabIndex = 6;
            // 
            // khactb
            // 
            this.khactb.Location = new System.Drawing.Point(164, 99);
            this.khactb.Name = "khactb";
            this.khactb.Size = new System.Drawing.Size(100, 26);
            this.khactb.TabIndex = 7;
            // 
            // tongtb
            // 
            this.tongtb.Location = new System.Drawing.Point(427, 102);
            this.tongtb.Name = "tongtb";
            this.tongtb.Size = new System.Drawing.Size(100, 26);
            this.tongtb.TabIndex = 8;
            // 
            // cktb
            // 
            this.cktb.Location = new System.Drawing.Point(427, 44);
            this.cktb.Name = "cktb";
            this.cktb.Size = new System.Drawing.Size(100, 26);
            this.cktb.TabIndex = 9;
            // 
            // CapNhatDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 226);
            this.Controls.Add(this.cktb);
            this.Controls.Add(this.tongtb);
            this.Controls.Add(this.khactb);
            this.Controls.Add(this.gktb);
            this.Controls.Add(this.capnhatbttn);
            this.Controls.Add(this.tonglb);
            this.Controls.Add(this.cklb);
            this.Controls.Add(this.khaclb);
            this.Controls.Add(this.gklb);
            this.Name = "CapNhatDiemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatDiemForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CapNhatDiemForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gklb;
        private System.Windows.Forms.Label khaclb;
        private System.Windows.Forms.Label cklb;
        private System.Windows.Forms.Label tonglb;
        private System.Windows.Forms.Button capnhatbttn;
        private System.Windows.Forms.TextBox gktb;
        private System.Windows.Forms.TextBox khactb;
        private System.Windows.Forms.TextBox tongtb;
        private System.Windows.Forms.TextBox cktb;
    }
}