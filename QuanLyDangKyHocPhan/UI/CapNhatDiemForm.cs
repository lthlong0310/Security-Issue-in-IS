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
    public partial class CapNhatDiemForm : Form
    {
        User current_user;
        clsResize _form_resize;
        Diem diemcu;
        Diem diemmoi;
        public CapNhatDiemForm(User curuser, Diem cu)
        {
            current_user = curuser;
            diemcu = cu;
            diemmoi = cu;

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

        private void CapNhatDiemForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
