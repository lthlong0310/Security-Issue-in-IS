namespace UI
{
    partial class DangKyHocPhanForm
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
            this.dshocphanlv = new System.Windows.Forms.ListView();
            this.dshocphandadangkylv = new System.Windows.Forms.ListView();
            this.dangkybttn = new System.Windows.Forms.Button();
            this.huydangkybttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dshocphanlv
            // 
            this.dshocphanlv.HideSelection = false;
            this.dshocphanlv.Location = new System.Drawing.Point(35, 51);
            this.dshocphanlv.Name = "dshocphanlv";
            this.dshocphanlv.Size = new System.Drawing.Size(315, 324);
            this.dshocphanlv.TabIndex = 0;
            this.dshocphanlv.UseCompatibleStateImageBehavior = false;
            // 
            // dshocphandadangkylv
            // 
            this.dshocphandadangkylv.HideSelection = false;
            this.dshocphandadangkylv.Location = new System.Drawing.Point(447, 51);
            this.dshocphandadangkylv.Name = "dshocphandadangkylv";
            this.dshocphandadangkylv.Size = new System.Drawing.Size(315, 324);
            this.dshocphandadangkylv.TabIndex = 1;
            this.dshocphandadangkylv.UseCompatibleStateImageBehavior = false;
            // 
            // dangkybttn
            // 
            this.dangkybttn.Location = new System.Drawing.Point(107, 395);
            this.dangkybttn.Name = "dangkybttn";
            this.dangkybttn.Size = new System.Drawing.Size(168, 43);
            this.dangkybttn.TabIndex = 2;
            this.dangkybttn.Text = "Đăng ký";
            this.dangkybttn.UseVisualStyleBackColor = true;
            // 
            // huydangkybttn
            // 
            this.huydangkybttn.Location = new System.Drawing.Point(525, 395);
            this.huydangkybttn.Name = "huydangkybttn";
            this.huydangkybttn.Size = new System.Drawing.Size(168, 43);
            this.huydangkybttn.TabIndex = 3;
            this.huydangkybttn.Text = "Hủy Đăng ký";
            this.huydangkybttn.UseVisualStyleBackColor = true;
            // 
            // DangKyHocPhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.huydangkybttn);
            this.Controls.Add(this.dangkybttn);
            this.Controls.Add(this.dshocphandadangkylv);
            this.Controls.Add(this.dshocphanlv);
            this.Name = "DangKyHocPhanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKyHocPhanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangKyHocPhanForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dshocphanlv;
        private System.Windows.Forms.ListView dshocphandadangkylv;
        private System.Windows.Forms.Button dangkybttn;
        private System.Windows.Forms.Button huydangkybttn;
    }
}