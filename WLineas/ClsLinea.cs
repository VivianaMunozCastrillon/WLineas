using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WLineas
{
    class ClsLinea
    {
        private int xInicial, xFinal, yInicial, yFinal;

        private static int contar = 0;


        public ClsLinea()
        {
            xInicial = 0;
            xFinal = 0;
            yInicial = 0;
            yFinal = 0;
        }

        public ClsLinea(int xInicial, int xFinal, int yInicial,int yFinal)
            {
            this.xInicial = xInicial;
            this.xFinal = xFinal;
            this.yInicial = yInicial;
            this.yFinal = yFinal;
            }

        public ClsLinea(double xInicial, double xFinal, double yInicial, double yFinal)
        {
            this.xInicial =(int) xInicial;
            this.xFinal = (int) xFinal;
            this.yInicial = (int) yInicial;
            this.yFinal = (int) yFinal;
        }


        public int obtenxInicial()
        {
            return xInicial;
        }
        public int obtenxFinal()
        {
            return xFinal;
        }
        public int obtenyInicial()
        {
            return yInicial;
        }
        public int obtenyfinal()
        {
            return yFinal;
        }


        public void cambiarxinicial(int xInicial)
        {
            this.xInicial = xInicial;
        }
        public void cambiarxfinal(int xFinal)
        {
            this.xFinal = xFinal;
        }
        public void cambiaryinicial(int yInicial)
        {
            this.yInicial = yInicial;
        }
        public void cambiaryFinal(int yFinal)
        {
            this.yFinal = yFinal;
        }


        public static int obtencuenta()
        {
            contar ++;
            return contar;
        }








    }
}
