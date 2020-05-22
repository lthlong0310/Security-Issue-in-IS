using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GiaoDien
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button_XemDsUser_Click(object sender, EventArgs e)
        {
//            this.Hide();
            Form DsUser = new DsUser();
            DsUser.ShowDialog();
        }

        private void button_TaoUser_Click(object sender, EventArgs e)
        {
//            this.Hide();
            Form TaoUser = new TaoUser();
            TaoUser.ShowDialog();
        }

        private void button_XoaUser_Click(object sender, EventArgs e)
        {
//            this.Hide();
            Form drop_user = new DropUser();
            drop_user.ShowDialog();
        }

        private void button_CapQuyenUser_Click(object sender, EventArgs e)
        {
 //           this.Hide();
            Form grant_privs_user = new GrantPrivs();
            grant_privs_user.ShowDialog();
        }

        private void button_ThongTinVeQuyenUser_Click(object sender, EventArgs e)
        {
            Form QuyenUser = new FormQuyenUser();
            QuyenUser.ShowDialog();
        }
    }
}
