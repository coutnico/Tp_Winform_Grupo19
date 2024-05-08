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
        public viewModificarCategorias()
        {
            InitializeComponent();
        }

        private void modificar_Categorias_Click(object sender, EventArgs e)
        {
            try
            {

                Categoria Categoria_obj = new Categoria();

                Categoria_obj.Id = int.Parse(codigo_Categoria_a_modificar.Text);
                Categoria_obj.Descripcion = descripcion_Categoria_a_modificar.Text;


                //Cargar en  base de datos.
                CategoriaNegocio CategoriaNegocio_obj = new CategoriaNegocio();

                CategoriaNegocio_obj.modificarCategoria(Categoria_obj, int.Parse(codigo_Categoria_a_modificar.Text));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void codigo_Categoria_a_modificar_TextChanged(object sender, EventArgs e)
        {
            CategoriaNegocio CategoriaNegocio_obj = new CategoriaNegocio();
            Categoria Categoria_obj;

            if (!string.IsNullOrEmpty(codigo_Categoria_a_modificar.Text))
            {
                Categoria_obj = CategoriaNegocio_obj.Buscar_Categoria_por_ID(int.Parse(codigo_Categoria_a_modificar.Text));
                descripcion_Categoria_a_modificar.Text = Categoria_obj.Descripcion; ;
            }
            else { descripcion_Categoria_a_modificar.Text = ""; }

        }

        private void ibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
