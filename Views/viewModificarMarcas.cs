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
        MarcaNegocio marcaNegocio = new MarcaNegocio(); 
        private int IdAModificar = -1;

        public viewModificarMarcas()
        {
            InitializeComponent();
        }


        private void codigo_Marca_a_modificar_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void modificar_Marcas_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca_obj = new Marca();

                marca_obj.Id = IdAModificar;
                marca_obj.Descripcion = descripcion_Marca_a_modificar.Text;


                //Cargar en  base de datos.
                MarcaNegocio marcaNegocio_obj = new MarcaNegocio();

                marcaNegocio_obj.modificarMarca(marca_obj, IdAModificar);
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

        private void viewModificarMarcas_Load(object sender, EventArgs e)
        {
            foreach (Marca marca in marcaNegocio.ListarMarcas())
            {
                cbMarcas.Items.Add(marca.Descripcion);
            }
        }

        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            descripcion_Marca_a_modificar.Text = cbMarcas.SelectedItem.ToString();

            foreach (Marca marca in marcaNegocio.ListarMarcas())
            {
                if (cbMarcas.SelectedItem.ToString() == marca.Descripcion)
                {
                    IdAModificar = marca.Id;
                    break;
                }
            }

        }
    }
}
