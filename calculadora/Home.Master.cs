using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculadora
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                btnCerrar.Visible = false;
            }
            else
            {
                btnCerrar.Visible = true;
            }
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {            
                Session.Remove("Login");
                Response.Redirect("login.aspx");           
        }
    }
}