using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHome.Reportes
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            ReporteHabitaciones reporteHabitaciones = new ReporteHabitaciones();
            reporteHabitaciones.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ReportReserva reportReserva = new ReportReserva();
            reportReserva.ShowDialog();
        }

        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            ReporteHabitacionesDisponible reporteHabitacionesDisponible = new ReporteHabitacionesDisponible();
            reporteHabitacionesDisponible.ShowDialog();
        }

        private void btnNodisponible_Click(object sender, EventArgs e)
        {
            ReportHabitacionesNoDisponible reportHabitacionesNoDisponible = new ReportHabitacionesNoDisponible();
            reportHabitacionesNoDisponible.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
