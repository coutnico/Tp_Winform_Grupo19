using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Grupo_19.Models;

namespace Tp_WinForm_Grupo_19.Views
{
    public partial class viewAgregarArticulos : Form
    {
        public viewAgregarArticulos()
        {
            InitializeComponent();

            // Agrego en el listbox todos los ID de marcas que existen para poder crear un nuevo articulo

            MarcaNegocio marcaNegocio = new MarcaNegocio();

            List<Marca> marcas = marcaNegocio.ListarMarcas();

            for (int i = 0; i < marcas.Count; i++) {
                Marca marca_obj = marcas[i];
                lista_Marca.Items.Add(marca_obj.Id);
            }
        }

        private void viewAgregarArticulos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lista_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lista_Marca.Items.Add("id 1");
            //lista_Marca.Items.Add("id 2");
        }
    }
}
