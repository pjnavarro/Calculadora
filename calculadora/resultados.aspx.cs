using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculadora
{
    public partial class Resultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtSuma.Text = Convert.ToString(Session["suma"]);
            txtResta.Text = Convert.ToString(Session["resta"]);
            txtMul.Text = Convert.ToString(Session["mul"]);
            txtDiv.Text = Convert.ToString(Session["div"]);

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

        protected void btnResultados_Click(object sender, EventArgs e)
        {
            Response.Redirect("calculator.aspx");
        }

        protected void btnBorrsr_Click(object sender, EventArgs e)
        {
            txtSuma.Text = string.Empty;
            Session["suma"] = string.Empty;
            txtResta.Text = string.Empty;
            Session["resta"] = string.Empty;
            txtMul.Text = string.Empty;
            Session["mul"] = string.Empty;
            txtDiv.Text = string.Empty;
            Session["div"] = string.Empty;
        }
    }
}