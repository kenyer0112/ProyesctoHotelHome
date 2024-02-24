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
using HotelHome.Entity;

namespace HotelHome.UI
{
    public partial class Habitaciones : Form
    {
        public Habitaciones()
        {
            InitializeComponent();
        }
        private int _idRoom;

        public int ID
        {
            get
            {
                return _idRoom;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new CrearHabiacion();
            formulario.Show();
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            dgHabitaciones.AutoGenerateColumns = false;
            dgHabitaciones.DataSource = B_Room.GetALL();
        }

        private void dgHabitaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }


            _idRoom = Convert.ToInt32(dgHabitaciones.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = txtBuscar.Text;
            dgHabitaciones.DataSource=B_Room.GetByValor(valor);
            txtBuscar.Clear();
        }

        private void dgHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
