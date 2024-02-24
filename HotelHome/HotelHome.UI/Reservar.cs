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
    public partial class Reservar : Form
    {
        public Reservar()
        {
            InitializeComponent();
        }
        const string titulo = "Sistema Hotelero";
        string categoria;
        private void Reservar_Load(object sender, EventArgs e)
        {

            Inicializar();
        }
        E_Reserva reserva;

        private string Status;
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarClientes frmBuscar = new BuscarClientes();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                E_Cliente cliente = B_Cliente.GetById(frmBuscar.ID);

                txtId.Text = cliente.idCliente.ToString();
                txtNombre.Text = cliente.nombre;
                txtApellido.Text = cliente.apellido;
                //txtEmail.Text = cliente.email;
                mkDoc.Text = cliente.Documento;
                // mkTelefono.Text = cliente.telefono;
                // txtFecha.Value = cliente.fechaNac;
            }
        }

     
        private bool ValidarAgregar()
        {
            bool resultado = true;
            errorProvider.Clear();
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                errorProvider.SetError(txtCategoria, "Error");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtCantidadNoche.Text) || txtCantidadNoche.Text==0.ToString())
            {
                errorProvider.SetError(txtCantidadNoche, "ingrese el valor");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text)|| txtPrecio.Text==0.ToString())
            {
                errorProvider.SetError(txtPrecio, "ingrese el valor");
                resultado = false;
            }
            if (string.IsNullOrEmpty(dateTimePicker2.Value.ToString()) && dateTimePicker2.Value==DateTime.Today)
            {
                errorProvider.SetError(dateTimePicker2, "ingrese el valor");
                return resultado;
            }
            return resultado;

        }


        private bool ValidarGuardar()
        {
            bool resultado = true;
            errorProvider.Clear();
            if (string.IsNullOrEmpty(txtId.Text) || txtId.Text==0.ToString())
            {
                errorProvider.SetError(txtId, "Error");
                resultado = false;
            }
            
            if (string.IsNullOrEmpty(txtSubTotalP.Text))
            {
                MessageBox.Show("Debes llenar todos los campos..", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultado = false;
            }
           

            return resultado;

        }
        private void InicializarAgregar()
        {
           
            txtIDRoom.Clear();
            txtCategoria.Clear();
            txtCantidadNoche.Text = 0.ToString();
            txtPrecio.Text = 0.ToString("C");
            dgReserva.AutoGenerateColumns = false;
            txtSubTotalP.Text = reserva.TotalSubtotal.ToString("C");
            txtDescuentoP.Text = reserva.Descuento.ToString("C");
            txtImp.Text = reserva.Impuesto.ToString("C");
            txtTotal.Text = reserva.Total.ToString("C");
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
             if (!ValidarAgregar())
             {
                 return;
             }

            E_DetalleReserva detalle = new E_DetalleReserva();
            detalle.idRoom = Convert.ToInt32(txtIDRoom.Text);
            detalle.precio = Convert.ToDouble(txtPrecio.Text);
            detalle.categoria = txtCategoria.Text;
            detalle.status = Status;
            detalle.cantidadNoche = Convert.ToInt32(txtCantidadNoche.Text);
            detalle.fechaLLegada = Convert.ToDateTime(dateTimePicker1.Value);
            detalle.fechaSalida = Convert.ToDateTime(dateTimePicker2.Value);
            reserva.Detalle.Add(detalle);

            dgReserva.DataSource = null;
            dgReserva.DataSource = reserva.Detalle;

            txtSubTotalP.Text = reserva.TotalSubtotal.ToString("C");
            txtDescuentoP.Text = reserva.Descuento.ToString("C");
             txtImp.Text = reserva.Impuesto.ToString("C");
            txtTotal.Text = reserva.Total.ToString("C");
           InicializarAgregar();

        }

        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            Habitaciones frmRoom = new Habitaciones();
            try
            {
                if (frmRoom.ShowDialog() == DialogResult.OK)
                {
                    E_Room room = B_Room.GetBYIDUpdate(frmRoom.ID);
                    txtIDRoom.Text = room.idRoom.ToString();
                    txtCategoria.Text = room.Catenombre;
                    txtPrecio.Text = room.precio.ToString();
                    Status = room.StatusNombre;
                    txtCantidadNoche.Text = 1.ToString();
                  string  categoria = room.Catenombre;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void dgReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InicializarReserva()
        {
            txtId.Text = 0.ToString();
            txtNombre.Clear();
            txtApellido.Clear();
            mkDoc.Clear();
            txtIDRoom.Clear();
            txtCategoria.Clear();
            txtCantidadNoche.Text = 0.ToString();
            txtPrecio.Text = 0.ToString("C");
            txtSubTotalP.Text= 0.ToString("C");
            txtDescuentoP.Text = 0.ToString("C");
            txtImp.Text = 0.ToString("C");
            txtTotal.Text = 0.ToString("C");
            dgReserva.DataSource = null;

        }

        private void Inicializar()
        {
            reserva = new E_Reserva();
            txtId.Text = 0.ToString();
            txtNombre.Clear();
            txtApellido.Clear();
            mkDoc.Clear();
            txtIDRoom.Clear();
            txtCategoria.Clear();
            txtCantidadNoche.Text = 0.ToString();
            txtPrecio.Text = 0.ToString("C");
            txtSubTotalP.Text = 0.ToString("C");
            txtDescuentoP.Text = 0.ToString("C");
            txtImp.Text = 0.ToString("C");
            txtTotal.Text = 0.ToString("C");
            dgReserva.DataSource = null;
            dgReserva.AutoGenerateColumns = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarGuardar())
            {
                return;
            }
            reserva.idCliente = Convert.ToInt32(txtId.Text);
            reserva.idUsuario = 1;
            try
            {
                

                if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Reserva.Save(reserva);
                        MessageBox.Show("Registro Guardado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    B_Room.UpdateStadoAgregacion();
                    }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),titulo);
            }

            InicializarReserva();
           
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarAgregar();
            InicializarReserva();
            B_Room.UpdateStadoAgregacion();
        }
    }
}
