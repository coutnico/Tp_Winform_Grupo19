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
    public partial class viewModificarMarcas : Form
    {
        public viewModificarMarcas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void codigo_Marca_a_modificar_TextChanged(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio_obj = new MarcaNegocio();
            Marca marca_obj;

            if (!string.IsNullOrEmpty(codigo_Marca_a_modificar.Text))
            {
                marca_obj = marcaNegocio_obj.Buscar_Marca_por_ID(int.Parse(codigo_Marca_a_modificar.Text));
                descripcion_Marca_a_modificar.Text = marca_obj.Descripcion; ;
            }
            else { descripcion_Marca_a_modificar.Text = ""; }

        }

        private void modificar_Marcas_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca_obj = new Marca();

                marca_obj.Id = int.Parse(codigo_Marca_a_modificar.Text);
                marca_obj.Descripcion = descripcion_Marca_a_modificar.Text;


                //Cargar en  base de datos.
                MarcaNegocio marcaNegocio_obj = new MarcaNegocio();

                marcaNegocio_obj.modificarMarca(marca_obj, int.Parse(codigo_Marca_a_modificar.Text));
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
    }
}
