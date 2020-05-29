using Business_Logic_Layer;
using Entity_Object;
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
    public partial class AuditConditionForm : Form
    {
        private List<DanhSachUser> Users;
        private List<USER_OBJECT> Objects;
        public AuditConditionForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuditConditionForm_Load(object sender, EventArgs e)
        {
            Users = GetAllUser();
            Objects = GetAllObject();
            foreach (var item in Users)
            {
                UserComboBox.Items.Add(item.username);
            }
            UserComboBox.Text = UserComboBox.Items[0].ToString();
            foreach (var item in Objects)
            {
                ObjectComboBox.Items.Add(item.name);
            }
            ObjectComboBox.Text = ObjectComboBox.Items[0].ToString();
        }

        private List<USER_OBJECT> GetAllObject()
        {
            var bll = new BLL();
            return bll.GetAllUserObject();
        }

        private List<DanhSachUser> GetAllUser()
        {
            var bll = new BLL();
            return bll.get_DsUser();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (UserComboBox.Items.Count > 0)
            {
                UserListView.Items.Clear();
                ActionListView.Items.Clear();
                ActionComboBox.Items.Clear();
                var CurrentUser = UserComboBox.Text;
                UserComboBox.Items.Remove(CurrentUser);
                UserComboBox.Text = UserComboBox.Items.Count > 0 ? UserComboBox.Items[0].ToString() : "";
                UserListView.Items.Add(CurrentUser);
                BLL bll = new BLL();
                var quyen = bll.Lay_DsQuyen(CurrentUser);
                foreach (var item in quyen)
                {
                    ActionComboBox.Items.Add(item.privilege);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void AddActionBtn_Click(object sender, EventArgs e)
        {
            if (ActionComboBox.Items.Count > 0)
            {
                var CurrentAction = ActionComboBox.Text;
                ActionComboBox.Items.Remove(CurrentAction);
                ActionComboBox.Text = ActionComboBox.Items.Count > 0 ? ActionComboBox.Items[0].ToString() : "";
                ActionListView.Items.Add(CurrentAction);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void AddObjectBtn_Click(object sender, EventArgs e)
        {
            if (ObjectComboBox.Items.Count > 0)
            {
                var CurrentObject = ObjectComboBox.Text;
                ObjectComboBox.Items.Remove(CurrentObject);
                ObjectComboBox.Text = ObjectComboBox.Items.Count > 0 ? ObjectComboBox.Items[0].ToString() : "";
                ObjectListView.Items.Add(CurrentObject);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void UserListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var CurrentItem = UserListView.FocusedItem.Text;
            UserListView.Items.Remove(UserListView.FocusedItem);
            UserComboBox.Items.Add(CurrentItem);
            ActionListView.Items.Clear();
            ActionComboBox.Items.Clear();
        }

        private void ActionListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var CurrentItem = ActionListView.FocusedItem.Text;
            ActionListView.Items.Remove(ActionListView.FocusedItem);
            ActionComboBox.Items.Add(CurrentItem);
        }

        private void ObjectListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var CurrentItem = ObjectListView.FocusedItem.Text;
            ObjectListView.Items.Remove(ObjectListView.FocusedItem);
            ObjectComboBox.Items.Add(CurrentItem);
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            var bll = new BLL();
            var username = UserListView.Items[0].Text;
            var actions = new List<string>();
            foreach (ListViewItem item in ActionListView.Items)
            {
                actions.Add(item.Text);
            }
            var success = bll.Audit(username, actions, SuccessCheckBox.Checked, NoSuccessCheckBox.Checked);
            if (success)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Not Success");
            }
            this.Close();
        }
    }
}
