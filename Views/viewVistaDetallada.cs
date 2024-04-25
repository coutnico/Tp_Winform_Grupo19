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
        public viewVistaDetallada(Image imagen, string nombre, string marca, string categoria, string descripcion, string precio)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            pbImageArticle.Image = imagen;

            lblName.Text = nombre;
            lblMar.Text = marca;
            lblCat.Text = categoria;
            lblDesc.Text = descripcion;
            lblPrice.Text = precio;
        }


    }
}
