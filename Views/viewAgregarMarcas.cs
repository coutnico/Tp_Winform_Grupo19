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
    public partial class viewAgregarMarcas : Form
    {
        public viewAgregarMarcas()
        {
            InitializeComponent();
        }

   

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ibAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca marca_obj = new Marca();

            marca_obj.Descripcion = txtDescripcion.Text;
            
            //Cargar en  base de datos.
            MarcaNegocio marcaNegocio_obj = new MarcaNegocio();

            marcaNegocio_obj.agregarMarca(marca_obj);

            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
