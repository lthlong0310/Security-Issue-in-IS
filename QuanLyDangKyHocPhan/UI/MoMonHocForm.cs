using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public partial class MoMonHocForm : Form
    {
        User current_user;
        clsResize _form_resize;
        public MoMonHocForm(User curuser)
        {
            InitializeComponent();
            current_user = curuser;
            LoadHockyCB();
            LoadGiaovienCB();
            LoadLopCB();
            LoadNamhocCB();

            _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void MoMonHocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            GiaoVuMenuForm gvumenu = new GiaoVuMenuForm(current_user);
            gvumenu.ShowDialog();
            this.Close();
        }

        private void LoadHockyCB()
        {
            int[] hocky = { 1, 2, 3 };
            this.hockycb.BeginUpdate();
            foreach (var hk in hocky)
            {
                this.hockycb.Items.Add(hk);
            }
            this.hockycb.EndUpdate();
        }

        private void LoadLopCB()
        {
            this.lopcb.BeginUpdate();
            var dslop = new BLL.BLL().LayDSLop(current_user);
            foreach (var lop in dslop)
            {
                this.lopcb.Items.Add(lop.malop);
            }
            this.lopcb.EndUpdate();
        }

        private void LoadNamhocCB()
        {
            DateTime basedate = DateTime.Now;
            List<String> nam = new List<String>();
            nam.Add(basedate.Year.ToString());
            for (int i = - 1; i >= -10; i--)
            {
                basedate.AddYears(i);
                nam.Add(basedate.Year.ToString());
            }
            nam.Reverse();
            for (int i = 0; i < nam.Count() - 1; i++)
            {
                nam[i] = nam[i] + "-" + nam[i + 1];
            }
            nam.RemoveAt(nam.Count() - 1);

            this.namhoccb.BeginUpdate();
            foreach(var namhoc in nam)
            {
                namhoccb.Items.Add(namhoc);
            }
            this.namhoccb.EndUpdate();
        }

        private void LoadGiaovienCB()
        {
            this.giaoviencb.BeginUpdate();

            this.giaoviencb.EndUpdate();
        }
    }
}
