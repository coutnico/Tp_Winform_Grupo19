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
    public partial class viewAgregarCategorias : Form
    {
        public viewAgregarCategorias()
        {
            InitializeComponent();
        }

        private void ibAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria Categoria_obj = new Categoria();

            Categoria_obj.Descripcion = txtDescripcion.Text;

            //Cargar en  base de datos.
            CategoriaNegocio CategoriaNegocio_obj = new CategoriaNegocio();

            CategoriaNegocio_obj.agregarCategoria(Categoria_obj);

            Close();
        }

        private void ibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
