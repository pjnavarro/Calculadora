using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculadora
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Pablo" && txtPass.Text == "123456")
            {
                Session["Login"] = txtUser.Text;
                Response.Redirect("calculator.aspx");
                Response.Redirect("resultados.aspx");
            }
            else
            {
                lbl1.Text = "Usuario o clave incorrecto vuelva a intentar";
                lbl1.Visible = true;
                lbl1.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}