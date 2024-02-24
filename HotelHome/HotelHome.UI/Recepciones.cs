using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelHome.BLL;

namespace HotelHome.UI
{
    public partial class Recepciones : Form
    {
        public Recepciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recepciones_Load(object sender, EventArgs e)
        {
            InicializarBotontes();


        }


        private void InicializarBotontes()
        {
            btnDisponibles.Text = " Habitaciones Disponibles \n" + "Total: "
              + B_Room.GetHabitacioneDisponibles().ToString();

            btnHabitacionesOcupadas.Text = " Habitaciones Ocupadas \n" + "Total: "
              + B_Room.GetHabitacioneOcupadas().ToString();

            btnReservas.Text = "Reservas Realizadas \n" + 
                "Total: " + B_Reserva.GetTotalReselvas().ToString();

            btnMantenimiento.Text = "Habitaciones en Mantenimiento \n" +
                "Total: " + B_Room.GetHabitacioneMatenimiento().ToString();
        }

        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            Habitaciones frmRoom = new Habitaciones();
            frmRoom.ShowDialog();
        }

        private void btnHabitacionesOcupadas_Click(object sender, EventArgs e)
        {
            HabitacionesOcupadas frmOcupada = new HabitacionesOcupadas();
            frmOcupada.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Busqueda_de_Reservas busquedaReservas = new Busqueda_de_Reservas();
            busquedaReservas.ShowDialog();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Habitaciones_Mantenimiento frmMantenimiento = new Habitaciones_Mantenimiento();
            frmMantenimiento.ShowDialog();
        }

        private void Vista_Click(object sender, EventArgs e)
        {
            InicializarBotontes();
        }
    }
}
