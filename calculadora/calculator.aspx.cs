using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;

namespace calculadora
{
    public partial class calculator : System.Web.UI.Page
    {
              
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
            }
            else
                {
                double a = Convert.ToDouble(txt1.Text);
                double b = Convert.ToDouble(txt2.Text);
                double c;

                c = a - b;

            txt3.Text = c.ToString();
            lbl.Visible = false;
            }
        }

        protected void btnSuma_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
            }
            else
            {
                double a = Convert.ToDouble(txt1.Text);
                double b = Convert.ToDouble(txt2.Text);
                double c;

                c = a + b;

                txt3.Text = c.ToString();
                lbl.Visible = false;
            }
           
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
            }
            else
            {
                double a = Convert.ToDouble(txt1.Text);
                double b = Convert.ToDouble(txt2.Text);
                double c;

                c = a * b;

                txt3.Text = c.ToString();
                lbl.Visible = false;
            }
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
            }
            else
            {
                double a = Convert.ToDouble(txt1.Text);
                double b = Convert.ToDouble(txt2.Text);
                double c;

                c = a / b;

                txt3.Text = c.ToString();
                lbl.Visible = false;
            }
        }
    }
}