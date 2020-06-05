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
namespace UI
{
    public partial class ThongTinCaNhan_GV : Form
    {
      
        User current_user;
        clsResize _form_resize;
        public ThongTinCaNhan_GV(User curuser)
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

        private void ThongTinCaNhan_GV_Load(object sender, EventArgs e)
        {

        }

        private void Xembttn_Click(object sender, EventArgs e)
        {
            BLL.BLL bll = new BLL.BLL();
            var dsttgv = bll.LayDSTT_giaovien(current_user);
            ListTT_GiaoVien_To_ListView(listView_ThongTinCaNhan_GV, dsttgv);
        }
        private void ListTT_GiaoVien_To_ListView(ListView listView_ThongTinCaNhan_GV, List<GiaoVien> gv)
        {
            listView_ThongTinCaNhan_GV.Items.Clear();
            foreach(var tt in gv)
            {
                ListViewItem item = new ListViewItem();
                item.Text = tt.magv;
                item.SubItems.Add(tt.bomon);
                item.SubItems.Add(tt.tengv);
                item.SubItems.Add(tt.dobgv);
                item.SubItems.Add(tt.diachigv);
                item.SubItems.Add(tt.gioitinhgv);
                item.SubItems.Add(tt.cmndgv);
                item.SubItems.Add(tt.sdtgv);
                item.SubItems.Add(tt.emailgv);
                listView_ThongTinCaNhan_GV.Items.Add(item);
                item.Tag = tt;
            }
        }
    }
}
