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
    public partial class viewEliminarMarcas : Form
    {
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        private int IdAModificar = -1;
        public viewEliminarMarcas()
        {
            InitializeComponent();
        }

        private void viewEliminarMarcas_Load(object sender, EventArgs e)
        {
            foreach (Marca marca in marcaNegocio.ListarMarcas())
            {
                cbMarcas.Items.Add(marca.Descripcion);
            }
        }

        private void eliminar_Marca_Click(object sender, EventArgs e)
        {
            if (IdAModificar != -1)
            {
                try
                {

                    MarcaNegocio marcaNegocio_obj = new MarcaNegocio();
                    marcaNegocio_obj.eliminarMarca(IdAModificar);
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

        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
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
