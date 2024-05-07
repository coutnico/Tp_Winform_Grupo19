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
    public partial class viewEliminarCategorias : Form
    {
        public viewEliminarCategorias()
        {
            InitializeComponent();
        }

        private void eliminar_Categoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio CategoriaNegocio_obj = new CategoriaNegocio();
            CategoriaNegocio_obj.eliminarCategoria(int.Parse(Id_Categoria_Eliminar.Text));
            Close();
        }
    }
}
