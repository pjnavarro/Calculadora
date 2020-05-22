using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calculadora
{
    public class Calculos
    {
        double resultado = 0;
        public Calculos()
        {
        }
        public double suma (double n1, double n2)
        {
            try
            {
                resultado = n1 + n2;
                return resultado;
            }
            catch
            {
                return resultado;               
            }
        }
        public double resta(double n1, double n2)
        {
            try
            {
                resultado = n1 - n2;
                return resultado;
            }
            catch
            {
                return resultado;
            }
        }
        public double mul(double n1, double n2)
        {
            try
            {
                resultado = n1 * n2;
                return resultado;
            }
            catch
            {
                return resultado;
            }
        }
        public double div(double n1, double n2)
        {
                try
                {
                    resultado = n1 / n2;
                    return resultado;
                }
                catch
                {
                    return resultado;
                }
            
        }

    }
}