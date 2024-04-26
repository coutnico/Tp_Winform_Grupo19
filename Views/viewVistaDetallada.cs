using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_WinForm_Grupo_19.Views
{
    public partial class viewVistaDetallada : Form
    {
        public viewVistaDetallada(Articulo articulo)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            pbImageArticle.Image = articulo.ImagenCargada;

            lblName.Text = articulo.Nombre;
            lblMar.Text = articulo.Marca;
            lblCat.Text = articulo.Categoria;
            lblDesc.Text = articulo.Descripcion;
            lblPrice.Text = "$" + articulo.Precio.ToString();

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color borderColor = Color.Black; 
            int borderWidth = 8;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                g.DrawRectangle(borderPen, 0, 0, panelPrincipal.Width - 1, panelPrincipal.Height - 1);
            }
        }

        private void pbImageArticle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color borderColor = Color.WhiteSmoke;
            int borderWidth = 4;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                g.DrawRectangle(borderPen, 0, 0, pbImageArticle.Width - 1, pbImageArticle.Height - 1);
            }
        }
    }
}
