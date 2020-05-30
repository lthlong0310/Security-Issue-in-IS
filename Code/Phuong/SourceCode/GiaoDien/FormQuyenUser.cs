using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using Entity_Object;
namespace GiaoDien
{
    public partial class FormQuyenUser : Form
    {
        public FormQuyenUser()
        {
            InitializeComponent();
        }

        private void button_Search_DsQuyen_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsUser();
            comboBox_dsQuyen.DataSource = dsUser;
            comboBox_dsQuyen.DisplayMember = "username";
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var username = comboBox_dsQuyen.Text;
            BLL bll = new BLL();
            var quyen = bll.Lay_DsQuyen(username);
            ListQuyen_To_ListView(listView_ThongTinQuyen, quyen);
        }
        private void ListQuyen_To_ListView(ListView listView_ThongTinQuyen, List<Quyen> quyen)
        {
            listView_ThongTinQuyen.Items.Clear();
            foreach (var privs in quyen)
            {
                ListViewItem item = new ListViewItem();
                item.Text = privs.grantee;
                item.SubItems.Add(privs.privilege);
                item.SubItems.Add(privs.admin_option);
                item.SubItems.Add(privs.common);
                item.SubItems.Add(privs.inheritied);
                listView_ThongTinQuyen.Items.Add(item);
                item.Tag = privs;

            }
        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
