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
    public partial class DetalleReserva : Form
    {
        public DetalleReserva()
        {
            InitializeComponent();
        }
        const string titulo = "Sistema Hotelero";

        private void DetalleReserva_Load(object sender, EventArgs e)
        {
            dgvDetalleReserva.DataSource = B_Reserva.GetAllDetalle();
            dgvDetalleReserva.AutoGenerateColumns = false;
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(string.IsNullOrEmpty(txtBuscar.Text)))
                {
                    int id = Convert.ToInt32(txtBuscar.Text);
                    dgvDetalleReserva.DataSource = B_Reserva.BuscarByIDDetalle(id);
                    txtBuscar.Clear();
                }

                else if (txtBuscar.Text == "")
                {
                    dgvDetalleReserva.DataSource = B_Reserva.GetAllDetalle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,titulo);
            }
            txtBuscar.Clear();
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
