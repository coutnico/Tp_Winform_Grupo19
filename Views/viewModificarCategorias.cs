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
    public partial class viewModificarCategorias : Form
    {
        private CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();
        private int IdAModificar = -1;

        public viewModificarCategorias()
        {
            InitializeComponent();
        }

        private void modificar_Categorias_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria Categoria_obj = new Categoria();

                Categoria_obj.Id = IdAModificar;
                Categoria_obj.Descripcion = descripcion_Categoria_a_modificar.Text;


                //Cargar en  base de datos.
                CategoriaNegocio CategoriaNegocio_obj = new CategoriaNegocio();

                CategoriaNegocio_obj.modificarCategoria(Categoria_obj, IdAModificar);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void ibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            descripcion_Categoria_a_modificar.Text = cbCategorias.SelectedItem.ToString();

            foreach (Categoria categoria in CategoriaNegocio.ListarCategorias())
            {
                if (cbCategorias.SelectedItem.ToString() == categoria.Descripcion)
                {
                    IdAModificar = categoria.Id;
                    break;
                }
            }

        }

        private void viewModificarCategorias_Load(object sender, EventArgs e)
        {
            foreach (Categoria categoria in CategoriaNegocio.ListarCategorias())
            {
                cbCategorias.Items.Add(categoria.Descripcion);
            }
        }
    }
}
