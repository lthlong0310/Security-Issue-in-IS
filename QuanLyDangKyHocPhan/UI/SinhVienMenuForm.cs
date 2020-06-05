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
    public partial class SinhVienMenuForm : Form
    {
        User current_user;
        clsResize _form_resize;
        public SinhVienMenuForm(User curuser)
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

        private void dangkyhocphanbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyHocPhanForm dangkyhocphan = new DangKyHocPhanForm(current_user);

            dangkyhocphan.ShowDialog();
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

        private void xemketquahocphanbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemKetQuaHocPhanForm kqhocphan = new XemKetQuaHocPhanForm(current_user);
            kqhocphan.ShowDialog();
            this.Close();
        }

        private void xemthongtincanhanbttn_Click(object sender, EventArgs e)
        {

        }
    }
}
