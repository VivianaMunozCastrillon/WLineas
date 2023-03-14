using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Fecha:Marzo 14 de 2023
/// Autor:Viviana Muñoz Castrillon
/// Descripcion: Aplicacion de dibujar una linea
/// </summary
namespace WLineas
{
    public partial class frmLineas : Form
    {
        public const int largo= 80;
        Graphics Dibujo;
        public frmLineas()
        {
            InitializeComponent();
            Dibujo = CreateGraphics();
        }

        

        private void btnDibujarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                double xInicial = double.Parse(txtXInicial.Text);
                double xFinal = double.Parse(txtXFinal.Text);
                double yInicial = double.Parse(txtYInicial.Text);
                double yFinal = double.Parse(txtYFinal.Text);

                ClsLinea Linea = new ClsLinea(xInicial, xFinal, yInicial, yFinal);

                Pen pen = new Pen(Color.Blue);
                Dibujo.DrawLine(pen, Linea.obtenxInicial(), Linea.obtenxFinal(), Linea.obtenyInicial(), Linea.obtenyfinal());
                
                txtResultado.Text = Convert.ToString(ClsLinea.obtencuenta());






            }
            catch (Exception)
            {

                MessageBox.Show("Digite el formato correcto");

                throw;
            }
        }

        private void frmLineas_Load(object sender, EventArgs e)
        {

        }
    }
}
