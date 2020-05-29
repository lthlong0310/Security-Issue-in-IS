using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using Business_Logic_Layer;
using Entity_Object;

namespace GiaoDien
{
    public partial class DsUser : Form
    {
        public DsUser()
        {
            InitializeComponent();
        }
        
        private void button_search_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsUser();
            ListUser_To_ListView(listView_DsUser, dsUser);

        }
        private void ListUser_To_ListView(ListView listView_DsUser, List<DanhSachUser> danhsachuser)
        {
            listView_DsUser.Items.Clear();
            foreach(var ds in danhsachuser)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ds.username;
                listView_DsUser.Items.Add(item);
                item.Tag = ds;
            }
        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button_Cancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
