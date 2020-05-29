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
    public partial class AuditAllForm : Form
    {
        public AuditAllForm()
        {
            InitializeComponent();
        }

        private void AuditBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoAuditBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
