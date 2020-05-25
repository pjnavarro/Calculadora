﻿using System;
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
        double resultados=0;

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
                txt3.Text = cal.resta(numero1, numero2).ToString();
                lbl.Text = "El total es:";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Blue;
                Session["resta"] = txt3.Text;

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
                txt3.Text = cal.suma(numero1, numero2).ToString();
                lbl.Text = "El total es:";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Black;
                Session["suma"] = txt3.Text;

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
                txt3.Text = cal.mul(numero1, numero2).ToString();
                lbl.Text = "El total es:";
                lbl.Visible = true;
                lbl.ForeColor = System.Drawing.Color.Green;
                Session["mul"] = txt3.Text;

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
                        txt3.Text = cal.div(numero1, numero2).ToString();
                        lbl.Text = "El total es:";
                        lbl.Visible = true;
                        lbl.ForeColor = System.Drawing.Color.Yellow;
                        Session["divicion"] = txt3.Text;

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


