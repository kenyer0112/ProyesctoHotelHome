using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHome.UI
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientes frmcliente = new BuscarClientes();
            frmcliente.ShowDialog();
        }

        private void btnBuscarReservas_Click(object sender, EventArgs e)
        {
            Busqueda_de_Reservas frmReserva = new Busqueda_de_Reservas();
            frmReserva.ShowDialog();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            BuscarHabitaciones frmRoom = new BuscarHabitaciones();
            frmRoom.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Buscar_Status buscar_Status = new Buscar_Status();
            buscar_Status.ShowDialog();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            Buscar_Categoria buscar_Categoria = new Buscar_Categoria();
            buscar_Categoria.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetalleReserva detalleReserva = new DetalleReserva();
            detalleReserva.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarUsuarios buscarUsuarios = new BuscarUsuarios();
            buscarUsuarios.ShowDialog();
        }
    }
}
