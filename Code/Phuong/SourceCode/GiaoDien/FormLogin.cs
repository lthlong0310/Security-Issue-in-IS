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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox_Username_Click(object sender, EventArgs e)
        {
            textBox_Username.Clear();
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            textBox_Username.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            textBox_Password.Clear();
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            textBox_Password.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
