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
using BLL;
//Cua giao vien

namespace UI
{
    public partial class XemDanhSachSVMonHocForm : Form
    {
        User current_user;
        clsResize _form_resize;
        public XemDanhSachSVMonHocForm(User curuser)
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

        private void XemDanhSachSVMonHocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GiaoVienMenuForm giaovienmenu = new GiaoVienMenuForm(current_user);
            giaovienmenu.ShowDialog();
        }

        private void capnhatdiembttn_Click(object sender, EventArgs e)
        {
            if (dsdangkylv.SelectedItems.Count == 1)
            {
                Diem diemsv = (Diem)dsdangkylv.SelectedItems[0].Tag;
                this.Hide();
                CapNhatDiemForm capnhat = new CapNhatDiemForm(current_user, diemsv);
                capnhat.ShowDialog();
                this.Close();
            }
        }

        private void monhoccb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void XemDanhSachSVMonHocForm_Load(object sender, EventArgs e)
        {

        }
    }
}
