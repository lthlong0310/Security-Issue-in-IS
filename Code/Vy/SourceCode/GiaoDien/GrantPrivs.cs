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

namespace GiaoDien
{
    public partial class GrantPrivs : Form
    {
        public GrantPrivs()
        {
            InitializeComponent();
        }

        private void button_Search_DsUser_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var dsUser = bll.get_DsUser();
            comboBox_DsUser.DataSource = dsUser;
            comboBox_DsUser.DisplayMember = "username";
        }

        private void button_grant_Click(object sender, EventArgs e)
        {
            //BLL bll = new BLL();

            //var capquyen = new Entity_Object.CapQuyen();
            //capquyen.username = comboBox_DsUser.Text;
            //capquyen.name_privs = comboBox_ListQuyen.Text;
            //var grant = bll.Grant_privs(capquyen);
            //MessageBox.Show("Grant privilege successful!", "*****Notification*****");
            BLL bll = new BLL();

            var capquyen_option = new Entity_Object.CapQuyenOption();
            capquyen_option.username = comboBox_DsUser.Text;
            capquyen_option.name_privs = comboBox_ListQuyen.Text;
            var str = checkBox_option.CheckState == CheckState.Checked ? "with admin option" : checkBox_option.CheckState == CheckState.Unchecked ? " " : " ";
            capquyen_option.option = str;
            var grant = bll.Grant_privs_option(capquyen_option);
            MessageBox.Show("Grant privilege successful!", "*****Notification*****");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            var capquyen = new Entity_Object.CapQuyen();
            capquyen.username = comboBox_DsUser.Text;
            capquyen.name_privs = comboBox_ListQuyen.Text;
            var grant = bll.Revoke_privs(capquyen);
            MessageBox.Show("Revoke privilege successful!", "*****Notification*****");
        }
    }
}
