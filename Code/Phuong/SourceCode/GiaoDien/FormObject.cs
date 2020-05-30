using Business_Logic_Layer;
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
using Entity_Object;

namespace GiaoDien
{
    public partial class FormObject : Form
    {
        clsResize _form_resize;
        public FormObject()
        {
            InitializeComponent();
            LoadObject();
        }

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void LoadObject()
        {
            this.objectlv.BeginUpdate();
            this.objectlv.Clear();
            this.objectlv.Columns.Add("Object Name", 250);
            this.objectlv.Columns.Add("Subobject Name", 250);
            this.objectlv.Columns.Add("Object Type", 150);

            var objs = new Business_Logic_Layer.BLL().get_DsObject();

            foreach(var obj in objs)
            {
                String[] item = new String[3];
                item[0] = obj.object_name;
                item[1] = obj.subobject_name;
                item[2] = obj.object_type;

                ListViewItem ob = new ListViewItem(item);
                this.objectlv.Items.Add(ob);
            }

            this.objectlv.View = View.Details;
            this.objectlv.EndUpdate();
            

        }


    }

    public class clsResize
    {
        List<System.Drawing.Rectangle> _arr_control_storage = new List<System.Drawing.Rectangle>();
        private bool showRowHeader = false;
        public clsResize(Form _form_)
        {
            form = _form_; //the calling form
            _formSize = _form_.ClientSize; //Save initial form size
            _fontsize = _form_.Font.Size; //Font size
        }

        private float _fontsize { get; set; }

        private System.Drawing.SizeF _formSize { get; set; }

        private Form form { get; set; }

        public void _get_initial_size() //get initial size//
        {
            var _controls = _get_all_controls(form);//call the enumerator
            foreach (Control control in _controls) //Loop through the controls
            {
                _arr_control_storage.Add(control.Bounds); //saves control bounds/dimension            
                                                          //If you have datagridview
                if (control.GetType() == typeof(DataGridView))
                    _dgv_Column_Adjust(((DataGridView)control), showRowHeader);
            }
        }

        public void _resize() //Set the resize
        {
            double _form_ratio_width = (double)form.ClientSize.Width / (double)_formSize.Width; //ratio could be greater or less than 1
            double _form_ratio_height = (double)form.ClientSize.Height / (double)_formSize.Height; // this one too
            var _controls = _get_all_controls(form); //reenumerate the control collection
            int _pos = -1;//do not change this value unless you know what you are doing
            foreach (Control control in _controls)
            {
                // do some math calc
                _pos += 1;//increment by 1;
                System.Drawing.Size _controlSize = new System.Drawing.Size
                ((int)(_arr_control_storage[_pos].Width * _form_ratio_width),
                    (int)(_arr_control_storage[_pos].Height * _form_ratio_height)); //use for sizing

                System.Drawing.Point _controlposition = new System.Drawing.Point((int)
                (_arr_control_storage[_pos].X * _form_ratio_width),
                (int)(_arr_control_storage[_pos].Y * _form_ratio_height));//use for location

                //set bounds
                control.Bounds = new System.Drawing.Rectangle(_controlposition, _controlSize); //Put together

                //Assuming you have a datagridview inside a form()
                //if you want to show the row header, replace the false statement of 
                //showRowHeader on top/public declaration to true;
                if (control.GetType() == typeof(DataGridView))
                    _dgv_Column_Adjust(((DataGridView)control), showRowHeader);


                //Font AutoSize
                control.Font = new System.Drawing.Font(form.Font.FontFamily,
                 (float)(((Convert.ToDouble(_fontsize) * _form_ratio_width) / 2) +
                  ((Convert.ToDouble(_fontsize) * _form_ratio_height) / 2)));

            }
        }

        private void _dgv_Column_Adjust(DataGridView dgv, bool _showRowHeader) //if you have Datagridview
                                                                               //and want to resize the column base on its dimension.
        {
            int intRowHeader = 0;
            const int Hscrollbarwidth = 5;
            if (_showRowHeader)
                intRowHeader = dgv.RowHeadersWidth;
            else
                dgv.RowHeadersVisible = false;

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Dock == DockStyle.Fill) //in case the datagridview is docked
                    dgv.Columns[i].Width = ((dgv.Width - intRowHeader) / dgv.ColumnCount);
                else
                    dgv.Columns[i].Width = ((dgv.Width - intRowHeader - Hscrollbarwidth) / dgv.ColumnCount);
            }
        }

        private static IEnumerable<Control> _get_all_controls(Control c)
        {
            return c.Controls.Cast<Control>().SelectMany(item =>
         _get_all_controls(item)).Concat(c.Controls.Cast<Control>()).Where(control => control.Name != string.Empty);
        }
    }
}
