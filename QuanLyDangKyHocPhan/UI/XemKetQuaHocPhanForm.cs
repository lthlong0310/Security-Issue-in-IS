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
    public partial class XemKetQuaHocPhanForm : Form
    {
        User current_user;
        clsResize _form_resize;
        public XemKetQuaHocPhanForm(User curuser)
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

        private void LoadKetQuaHocPhanListView()
        {
            this.kqhocphanlv.BeginUpdate();
            this.kqhocphanlv.Clear();

            this.kqhocphanlv.Columns.Add("Mã môn học", 150);
            this.kqhocphanlv.Columns.Add("Tên môn học", 250);
            this.kqhocphanlv.Columns.Add("Điểm giữa kỳ", 150);
            this.kqhocphanlv.Columns.Add("Điểm cuối kỳ", 150);
            this.kqhocphanlv.Columns.Add("Điểm khác", 150);
            this.kqhocphanlv.Columns.Add("Điểm tổng", 150);

            this.kqhocphanlv.View = View.Details;
            this.kqhocphanlv.EndUpdate();
        }

        private void XemKetQuaHocPhanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SinhVienMenuForm svmenu = new SinhVienMenuForm(current_user);
            svmenu.ShowDialog();
        }
    }
}
