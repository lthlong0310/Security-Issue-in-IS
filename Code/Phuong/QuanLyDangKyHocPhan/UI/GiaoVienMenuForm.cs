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
    public partial class GiaoVienMenuForm : Form
    {
        User current_user;
        clsResize _form_resize;
        public GiaoVienMenuForm(User curuser)
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

        private void dssvmhbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemDanhSachSVMonHocForm dssvmh = new XemDanhSachSVMonHocForm(current_user);
            dssvmh.ShowDialog();
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
