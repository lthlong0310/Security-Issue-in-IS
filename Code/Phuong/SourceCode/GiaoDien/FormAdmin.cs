using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button_XemTKB_Click(object sender, EventArgs e)
        {

        }

        private void button_QuanLyUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form User = new User();
            User.ShowDialog();
        }

        private void button_QuanLyRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form role = new Role();
            role.ShowDialog();
        }

        private void dsobjbtt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form obj = new FormObject();
            obj.ShowDialog();
            this.Close();
        }
    }
}
