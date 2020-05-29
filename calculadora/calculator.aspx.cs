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
        Calculos cal = new Calculos();
        double numero1 = 0;
        double numero2 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
                    
            if (Session["Login"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                lblLogeado.Text = " Usuario logeado: " + Convert.ToString(Session["Login"])
                                  + ", Hora: " + DateTime.Now.ToString();
                lblLogeado.Visible = true;
                lblLogeado.ForeColor = System.Drawing.Color.LightSkyBlue;
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            lbl.Visible = false;
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {

            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                numero1 = Convert.ToDouble(txt1.Text);
                numero2 = Convert.ToDouble(txt2.Text);
                var clResta = cal.resta(numero1, numero2).ToString();
                txt3.Text = clResta;
                lbl.Text = "El total es:";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Blue;
                Session.Add("resta", clResta.ToString() + ", " + Session["resta"]);
            }
        }

        protected void btnSuma_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                numero1 = Convert.ToDouble(txt1.Text);
                numero2 = Convert.ToDouble(txt2.Text);
                var clSuma = cal.suma(numero1, numero2).ToString();
                txt3.Text = clSuma;
                lbl.Text = "El total es:";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Black;
                Session.Add("suma", clSuma.ToString() + ", " + Session["suma"]);
            }
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                numero1 = Convert.ToDouble(txt1.Text);
                numero2 = Convert.ToDouble(txt2.Text);
                var clMul = cal.mul(numero1, numero2).ToString();
                txt3.Text = clMul;
                lbl.Text = "El total es:";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Green;
                Session.Add("mul", clMul.ToString() + ", " + Session["mul"]);
            }
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                lbl.Text = "Debe ingresar los números";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txt2.Text == "0")
                {
                    lbl.Text = "No se puede dividir por cero, ingrese otro número";
                    lbl.Visible = true;
                    lbl.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (txt2.Text != "0")
                    {
                        numero1 = Convert.ToDouble(txt1.Text);
                        numero2 = Convert.ToDouble(txt2.Text);
                        var clDiv = cal.div(numero1, numero2).ToString();
                        txt3.Text = clDiv;
                        lbl.Text = "El total es:";
                        lbl.Visible = true;
                        lbl.ForeColor = System.Drawing.Color.Yellow;
                        Session.Add("div", clDiv.ToString() + ", " + Session["div"]);
                    }
                }
            }
        }

        protected void btnResultados_Click(object sender, EventArgs e)
        {
            Response.Redirect("resultados.aspx");
        }
    } 
}


