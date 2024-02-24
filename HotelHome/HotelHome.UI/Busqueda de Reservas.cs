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
    public partial class Busqueda_de_Reservas : Form
    {
        public Busqueda_de_Reservas()
        {
            InitializeComponent();
        }

        const string titulo = "Sistema Hotelero";
        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Busqueda_de_Reservas_Load(object sender, EventArgs e)
        {
            Inicializar();
        }


        private void Inicializar()
        {
            dgvReservas.AutoGenerateColumns = false;
            dgvReservas.DataSource= B_Reserva.GetAllReservas();
            

        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool Validar()
        {
            bool valor = true;

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                MessageBox.Show("Ingrese el Valor", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                valor = false;
            }
            return valor;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!Validar())
            {
                return;
            }
            if (rdID.Checked==true)
            {
                int id = Convert.ToInt32(txtBuscar.Text);
                dgvReservas.DataSource = B_Reserva.BuscarReservasByID(id);
                txtBuscar.Clear();
            }
            else if (rbValor.Checked==true)
            {
                string valor = txtBuscar.Text;
                dgvReservas.DataSource = B_Reserva.BuscarReservas(valor);
                txtBuscar.Clear();
            }

           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
