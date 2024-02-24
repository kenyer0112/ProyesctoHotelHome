using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelHome.Reportes;
using HotelHome.Entity;


namespace HotelHome.UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño()
        {
            panelSubGestor.Visible = false;
            panelSubMantenimiento.Visible = false;
            panelSubReportes.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (panelSubGestor.Visible == true)
                panelSubGestor.Visible = false;
            if (panelSubMantenimiento.Visible == true)
                panelSubMantenimiento.Visible = false;
            if (panelSubReportes.Visible == true)
                panelSubReportes.Visible = false;
        }


        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();//AbrirFormularios(new Recepcion());
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region MostrarOcultarSubMenu
        private void btnGestor_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubGestor);
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            //AbrirFormularios(new Reservar());
            // OcultarSubMenu();
            Reservar frmReservar = new Reservar();
            frmReservar.ShowDialog();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Recepciones());
            OcultarSubMenu();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new CrearHabiacion());
            OcultarSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new CrearCategoria());
            OcultarSubMenu();
        }

        private void btnPiso_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Piso());
            OcultarSubMenu();
        }

        private void btnRecepciones_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Recepciones());
            OcultarSubMenu();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMantenimiento);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Cliente());
            OcultarSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Consultas());
            OcultarSubMenu();
        }
        #endregion
        private Form ActivarForm = null;
        private void AbrirFormularios(Form FormularioHijo)
        {
            if (ActivarForm != null)
                ActivarForm.Close();
            ActivarForm = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(FormularioHijo);
            panelFormulario.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void StatusRoom_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new StatusRoom());
            OcultarSubMenu();
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormularios(new Cliente());
            OcultarSubMenu();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

           
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void Home_Load_2(object sender, EventArgs e)
        {

        }
    }

}




