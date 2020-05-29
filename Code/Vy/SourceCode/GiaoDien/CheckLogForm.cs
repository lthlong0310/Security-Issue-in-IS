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
    public partial class CheckLogForm : Form
    {
        public CheckLogForm()
        {
            InitializeComponent();
        }

        private void CheckLogForm_Load(object sender, EventArgs e)
        {
            var bll = new Business_Logic_Layer.BLL();
            DataSet data = bll.get_Log();
            CheckLog.ReadOnly = true;
            CheckLog.DataSource = data.Tables[0];
        }
    }
}
