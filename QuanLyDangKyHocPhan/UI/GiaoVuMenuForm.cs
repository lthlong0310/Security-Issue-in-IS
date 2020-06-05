using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public partial class GiaoVuMenuForm : Form
    {
        User current_user;
        clsResize _form_resize;
        public GiaoVuMenuForm(User curuser)
        {
            current_user = curuser;

            InitializeComponent();

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

        private void dssvbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemDanhSachSinhVienForm dssv = new XemDanhSachSinhVienForm(current_user);
            dssv.ShowDialog();
            this.Close();
        }

        private void modkmhbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoMonHocForm momonhoc = new MoMonHocForm(current_user);
            momonhoc.ShowDialog();
            this.Close();
        }

        private void dsdkmhbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemDanhSachDangKyMonHocForm dsdkmh = new XemDanhSachDangKyMonHocForm(current_user);
            dsdkmh.ShowDialog();
            this.Close();
        }

        private void logoutbttn_Click(object sender, EventArgs e)
        {
            current_user.ClearUser();
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }
    }
}
