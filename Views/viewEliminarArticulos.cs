using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Grupo_19.Models;

namespace Tp_WinForm_Grupo_19.Views
{
    public partial class viewEliminarArticulos : Form
    {
        public viewEliminarArticulos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void codigo_Articulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void crear_Articulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio_obj = new ArticuloNegocio();
            articuloNegocio_obj.eliminarArticulo(int.Parse(Id_Articulo_Eliminar.Text));
            Close();
        }
    }
}
