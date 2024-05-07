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
        public viewEliminarMarcas()
        {
            InitializeComponent();
        }

        private void viewEliminarMarcas_Load(object sender, EventArgs e)
        {

        }

        private void eliminar_Marca_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio_obj = new MarcaNegocio();
            marcaNegocio_obj.eliminarMarca(int.Parse(Id_Marca_Eliminar.Text));
            Close();
        }
    }
}
