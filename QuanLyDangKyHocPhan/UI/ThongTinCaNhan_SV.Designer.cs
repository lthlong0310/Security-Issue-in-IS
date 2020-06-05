namespace UI
{
    partial class ThongTinCaNhan_SV
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
            this.Xembttn = new System.Windows.Forms.Button();
            this.listView_ThongTinCaNhan_GV = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen_SV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh_SV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi_SV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh_SV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMND_SV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT_SV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email_SV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Xembttn
            // 
            this.Xembttn.Location = new System.Drawing.Point(380, 283);
            this.Xembttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xembttn.Name = "Xembttn";
            this.Xembttn.Size = new System.Drawing.Size(144, 34);
            this.Xembttn.TabIndex = 31;
            this.Xembttn.Text = "Xem";
            this.Xembttn.UseVisualStyleBackColor = true;
            // 
            // listView_ThongTinCaNhan_GV
            // 
            this.listView_ThongTinCaNhan_GV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.HoTen_SV,
            this.Lop,
            this.NgaySinh_SV,
            this.DiaChi_SV,
            this.GioiTinh_SV,
            this.CMND_SV,
            this.SDT_SV,
            this.Email_SV});
            this.listView_ThongTinCaNhan_GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ThongTinCaNhan_GV.HideSelection = false;
            this.listView_ThongTinCaNhan_GV.Location = new System.Drawing.Point(2, 68);
            this.listView_ThongTinCaNhan_GV.Name = "listView_ThongTinCaNhan_GV";
            this.listView_ThongTinCaNhan_GV.Size = new System.Drawing.Size(932, 194);
            this.listView_ThongTinCaNhan_GV.TabIndex = 30;
            this.listView_ThongTinCaNhan_GV.UseCompatibleStateImageBehavior = false;
            this.listView_ThongTinCaNhan_GV.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 121;
            // 
            // HoTen_SV
            // 
            this.HoTen_SV.Text = "Họ tên";
            this.HoTen_SV.Width = 83;
            // 
            // NgaySinh_SV
            // 
            this.NgaySinh_SV.Text = "Ngày sinh";
            this.NgaySinh_SV.Width = 111;
            // 
            // DiaChi_SV
            // 
            this.DiaChi_SV.Text = "Địa chỉ";
            this.DiaChi_SV.Width = 83;
            // 
            // GioiTinh_SV
            // 
            this.GioiTinh_SV.Text = "Giới tính";
            this.GioiTinh_SV.Width = 91;
            // 
            // CMND_SV
            // 
            this.CMND_SV.Text = "CMND";
            this.CMND_SV.Width = 77;
            // 
            // SDT_SV
            // 
            this.SDT_SV.Text = "SĐT";
            this.SDT_SV.Width = 66;
            // 
            // Email_SV
            // 
            this.Email_SV.Text = "Email";
            this.Email_SV.Width = 67;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            // 
            // ThongTinCaNhan_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 363);
            this.Controls.Add(this.Xembttn);
            this.Controls.Add(this.listView_ThongTinCaNhan_GV);
            this.Name = "ThongTinCaNhan_SV";
            this.Text = "ThongTinCaNhan_SV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Xembttn;
        private System.Windows.Forms.ListView listView_ThongTinCaNhan_GV;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader HoTen_SV;
        private System.Windows.Forms.ColumnHeader NgaySinh_SV;
        private System.Windows.Forms.ColumnHeader DiaChi_SV;
        private System.Windows.Forms.ColumnHeader GioiTinh_SV;
        private System.Windows.Forms.ColumnHeader CMND_SV;
        private System.Windows.Forms.ColumnHeader SDT_SV;
        private System.Windows.Forms.ColumnHeader Email_SV;
        private System.Windows.Forms.ColumnHeader Lop;
    }
}