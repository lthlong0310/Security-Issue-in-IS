using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Object;
using Business_Logic_Layer;

namespace GiaoDien
{
    public partial class TaoUser : Form
    {
        private Entity_Object.User ngdung = null;
        
        public TaoUser()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox1_Password.Text == "" || textBox_password_confirm.Text == "") 
            {
                MessageBox.Show("You no fill in, please try again!", "*****Notification*****");
            }
            else
            {
                if (textBox_password_confirm.Text.Trim() != textBox1_Password.Text.Trim())
                    MessageBox.Show("Confict password vs confirm password", "*****Notification*****");
                else
                {
                    var services = new BLL();
                    var create_user = new Entity_Object.User();
                    create_user.username = textBox_username.Text;
                    create_user.password = textBox_password_confirm.Text;
                    ngdung = services.Create_user(create_user);
                    MessageBox.Show("Create user successful!", "*****Notification*****");
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
