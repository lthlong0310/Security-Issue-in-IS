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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void button_TaoRole_Click(object sender, EventArgs e)
        {
 //           this.Hide();
            Form tao_role = new TaoRole();
            tao_role.ShowDialog();
        }

        private void button_XoaRole_Click(object sender, EventArgs e)
        {
 //           this.Hide();
            Form drop_role = new DropRole();
            drop_role.ShowDialog();
        }
    }
}
