namespace UI
{
    partial class ThongTinCaNhan_GV
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
            this.listView_ThongTinCaNhan_GV = new System.Windows.Forms.ListView();
            this.MaGiaoVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaBoMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen_GiaoVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh_GV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi_GV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh_GV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMND_GV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT_GV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email_GV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Xembttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_ThongTinCaNhan_GV
            // 
            this.listView_ThongTinCaNhan_GV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaGiaoVien,
            this.MaBoMon,
            this.HoTen_GiaoVien,
            this.NgaySinh_GV,
            this.DiaChi_GV,
            this.GioiTinh_GV,
            this.CMND_GV,
            this.SDT_GV,
            this.Email_GV});
            this.listView_ThongTinCaNhan_GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ThongTinCaNhan_GV.HideSelection = false;
            this.listView_ThongTinCaNhan_GV.Location = new System.Drawing.Point(12, 72);
            this.listView_ThongTinCaNhan_GV.Name = "listView_ThongTinCaNhan_GV";
            this.listView_ThongTinCaNhan_GV.Size = new System.Drawing.Size(932, 194);
            this.listView_ThongTinCaNhan_GV.TabIndex = 28;
            this.listView_ThongTinCaNhan_GV.UseCompatibleStateImageBehavior = false;
            this.listView_ThongTinCaNhan_GV.View = System.Windows.Forms.View.Details;
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.Text = "Mã giáo viên";
            this.MaGiaoVien.Width = 130;
            // 
            // MaBoMon
            // 
            this.MaBoMon.Text = "Mã bộ môn";
            this.MaBoMon.Width = 120;
            // 
            // HoTen_GiaoVien
            // 
            this.HoTen_GiaoVien.Text = "Họ tên";
            this.HoTen_GiaoVien.Width = 83;
            // 
            // NgaySinh_GV
            // 
            this.NgaySinh_GV.Text = "Ngày sinh";
            this.NgaySinh_GV.Width = 111;
            // 
            // DiaChi_GV
            // 
            this.DiaChi_GV.Text = "Địa chỉ";
            this.DiaChi_GV.Width = 83;
            // 
            // GioiTinh_GV
            // 
            this.GioiTinh_GV.Text = "Giới tính";
            this.GioiTinh_GV.Width = 91;
            // 
            // CMND_GV
            // 
            this.CMND_GV.Text = "CMND";
            this.CMND_GV.Width = 77;
            // 
            // SDT_GV
            // 
            this.SDT_GV.Text = "SĐT";
            this.SDT_GV.Width = 66;
            // 
            // Email_GV
            // 
            this.Email_GV.Text = "Email";
            this.Email_GV.Width = 67;
            // 
            // Xembttn
            // 
            this.Xembttn.Location = new System.Drawing.Point(390, 287);
            this.Xembttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xembttn.Name = "Xembttn";
            this.Xembttn.Size = new System.Drawing.Size(144, 34);
            this.Xembttn.TabIndex = 29;
            this.Xembttn.Text = "Xem";
            this.Xembttn.UseVisualStyleBackColor = true;
            this.Xembttn.Click += new System.EventHandler(this.Xembttn_Click);
            // 
            // ThongTinCaNhan_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 385);
            this.Controls.Add(this.Xembttn);
            this.Controls.Add(this.listView_ThongTinCaNhan_GV);
            this.Name = "ThongTinCaNhan_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinCaNhan_GV";
            this.Load += new System.EventHandler(this.ThongTinCaNhan_GV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_ThongTinCaNhan_GV;
        private System.Windows.Forms.ColumnHeader MaGiaoVien;
        private System.Windows.Forms.ColumnHeader MaBoMon;
        private System.Windows.Forms.ColumnHeader HoTen_GiaoVien;
        private System.Windows.Forms.ColumnHeader NgaySinh_GV;
        private System.Windows.Forms.ColumnHeader DiaChi_GV;
        private System.Windows.Forms.ColumnHeader GioiTinh_GV;
        private System.Windows.Forms.ColumnHeader CMND_GV;
        private System.Windows.Forms.ColumnHeader SDT_GV;
        private System.Windows.Forms.ColumnHeader Email_GV;
        private System.Windows.Forms.Button Xembttn;
    }
}