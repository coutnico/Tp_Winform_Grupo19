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
        private CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();
        private int IdAModificar = -1;
        public viewEliminarCategorias()
        {
            InitializeComponent();
        }

        private void eliminar_Categoria_Click(object sender, EventArgs e)
        {
            if (IdAModificar != -1)
            {

                try
                {

                    CategoriaNegocio CategoriaNegocio_obj = new CategoriaNegocio();
                    CategoriaNegocio_obj.eliminarCategoria(IdAModificar);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void ibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewEliminarCategorias_Load(object sender, EventArgs e)
        {
            foreach (Categoria categoria in CategoriaNegocio.ListarCategorias())
            {
                cbCategorias.Items.Add(categoria.Descripcion);
            }
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Categoria categoria in CategoriaNegocio.ListarCategorias())
            {
                if (cbCategorias.SelectedItem.ToString() == categoria.Descripcion)
                {
                    IdAModificar = categoria.Id;
                    break;
                }
            }
        }
    }
}
