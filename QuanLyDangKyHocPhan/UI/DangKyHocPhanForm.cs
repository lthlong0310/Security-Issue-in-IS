using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DangKyHocPhanForm : Form
    {
        clsResize _form_resize;
        User current_user;
        public DangKyHocPhanForm(User curuser)
        {
            InitializeComponent();
            current_user = curuser;
            LoadDSHocPhanListView();
            LoadDSHocPhanDangkyListView();

            _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void DangKyHocPhanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SinhVienMenuForm svmenu = new SinhVienMenuForm(current_user);
            svmenu.ShowDialog();
            this.Close();
        }

        private void LoadDSHocPhanListView()
        {
            this.dshocphanlv.BeginUpdate();
            this.dshocphanlv.Clear();

            this.dshocphanlv.Columns.Add("Mã môn học", 100);
            this.dshocphanlv.Columns.Add("Tên môn học", 250);
            this.dshocphanlv.Columns.Add("Giáo viên giảng dạy", 250);
            this.dshocphanlv.Columns.Add("Phòng học", 100);
            this.dshocphanlv.Columns.Add("Số sinh viên tối đa", 150);
            this.dshocphanlv.Columns.Add("Số sinh viên hiện tại", 150);



            this.dshocphanlv.View = View.Details;
            this.dshocphanlv.EndUpdate();
        }

        private void LoadDSHocPhanDangkyListView()
        {
            this.dshocphandadangkylv.BeginUpdate();
            this.dshocphandadangkylv.Clear();

            this.dshocphandadangkylv.Columns.Add("Mã môn học", 100);
            this.dshocphandadangkylv.Columns.Add("Tên môn học", 250);
            this.dshocphandadangkylv.Columns.Add("Giáo viên giảng dạy", 250);
            this.dshocphandadangkylv.Columns.Add("Phòng học", 100);
            this.dshocphandadangkylv.Columns.Add("Số sinh viên tối đa", 150);
            this.dshocphandadangkylv.Columns.Add("Số sinh viên hiện tại", 150);



            this.dshocphandadangkylv.View = View.Details;
            this.dshocphandadangkylv.EndUpdate();
        }


    }
}
