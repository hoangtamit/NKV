using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanXuat.Test
{
    public partial class frmForeachControl2 : Form
    {
        public frmForeachControl2()
        {
            InitializeComponent();
        }

        private void frmForeachControl2_Load(object sender, EventArgs e)
        {
            //ClearTextBoxes(frmForeachControl2.ActiveForm);
            //foreach (TableLayoutPanel table in System.Windows.Forms.)
            //{
            //    table.BackColor = Color.Crimson;
            //    //foreach (System.Windows.Forms.Control control in table.Controls)
            //    //{
            //    //    if(control.GetType() == typeof(TextBox))
            //    //    control.BackColor = Color.Coral;
            //    //}
                
            //}
            //ClearTextBoxes3(frmForeachControl2.ActiveForm);
        }
        public void ClearTextBoxes3(Form frm)
        {
            foreach (TableLayoutPanel table in frm.Controls)
            {
                table.BackColor = Color.Aqua;
                //if (control.GetType() == typeof(TextBox))
                //{
                //    control.Text = "123";
                //    control.BackColor = Color.Aqua;
                //}
            }
        }
        public void ClearTextBoxes(Form frm)
        {
            foreach (System.Windows.Forms.Control control in frm.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "123";
                    control.BackColor = Color.Aqua;
                }
            }
        }

        public void ClearTextBoxes2(Form frm)
        {
            foreach (System.Windows.Forms.Control control in frm.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "123";
                    control.BackColor = Color.Aqua;
                }
            }
        }
    }
}
