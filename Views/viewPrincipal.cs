using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Tp_WinForm_Grupo_19.UserControls;
using Tp_WinForm_Grupo_19.Views;

namespace Tp_WinForm_Grupo_19
{
    public partial class viewPrincipal : Form
    {

        private bool dragging = false;
        private Point startPoint = Point.Empty;
        public viewPrincipal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void ibExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ibMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
        }

        private void panelBorderStyle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = e.Location;
            }
        }

        private void panelBorderStyle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelBorderStyle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ibviewArticles_Click(object sender, EventArgs e)
        {
            viewVerArticulos viewVerArticulos = new viewVerArticulos();
            viewVerArticulos.Transferencia += ViewVerArticulos_Transferencia;
            OpenChildForm(viewVerArticulos);
        }

        private void ViewVerArticulos_Transferencia(object sender, Models.EventoTransferir e)
        {
            Articulo articulo = e.ArticuloSeleccionado;
            viewVistaDetallada vistaDetallada = new viewVistaDetallada(articulo);
            OpenChildForm(vistaDetallada);
        }

        private void ibaAddArticles_Click(object sender, EventArgs e)
        {
           viewAgregarArticulos viewAgregarArticulos = new viewAgregarArticulos();
            OpenChildForm(viewAgregarArticulos);
        }


        private void OpenChildForm(Form childForm)
        {

            // Si hay un formulario secundario abierto, ciérralo antes de abrir uno nuevo
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            // Establece el formulario secundario pasado como argumento como formulario hijo del formulario principal
            childForm.MdiParent = this;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelHome.Visible = false;
            childForm.Show();

            childForm.FormClosed += (sender, e) =>
            {

                panelHome.Visible = true;
            };


            childForm.Show();
        }

        private void viewPrincipal_Load(object sender, EventArgs e)
        {
           this.DoubleBuffered = true;
        }

    }
}
