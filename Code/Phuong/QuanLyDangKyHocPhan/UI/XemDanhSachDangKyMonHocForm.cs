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

//Cua giao vu

namespace UI
{
    public partial class XemDanhSachDangKyMonHocForm : Form
    {
        User current_user;
        clsResize _form_resize;
        public XemDanhSachDangKyMonHocForm(User curuser)
        {
            InitializeComponent();
            current_user = curuser;

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

        private void XemDanhSachDangKyMonHocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GiaoVuMenuForm giaovumenu = new GiaoVuMenuForm(current_user);
            giaovumenu.ShowDialog();
        }
    }
}
