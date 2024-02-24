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
    public partial class CrearHabiacion : Form
    {
        public CrearHabiacion()
        {
            InitializeComponent();
        }
        const string titulo = "Sistema Hotelero";
        private Boolean Validar()
        {
            bool resultado = true;
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtPrecio.Text) || txtPrecio.Text==0.ToString())
            {
                errorProvider.SetError(txtPrecio, "Ingrese el precio");
                resultado = false;
            }

            return resultado;
        }

        int ID;

        private void CrearHabiacion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void CargarCategoria()
        {


            cbCategoria.ValueMember = "ID";
            cbCategoria.DisplayMember = "Name";
            cbCategoria.DataSource = B_Categoria.GetAll();


        }
        private void CargarStatus()
        {
            cbEstado.ValueMember = "idStatus";
            cbEstado.DisplayMember = "nombre";
            cbEstado.DataSource = B_StatusRoom.GetAll();
        }
        private void CargarPiso()
        {
            cbPiso.ValueMember = "Id";
            cbPiso.DisplayMember = "descripcion";
            cbPiso.DataSource = B_Piso.GetAll();
        }
        private void Inicializar()
        {
            ID = 0;
            txtPrecio.Text = 0.ToString();
            CargarCategoria();
            CargarStatus();
            CargarPiso();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            E_Room room = new E_Room();
            room.idCategoria =Convert.ToInt32(cbCategoria.SelectedValue);
            room.idEstado = Convert.ToInt32(cbEstado.SelectedValue);
            room.idPiso = Convert.ToInt32(cbPiso.SelectedValue);
            room.precio = Convert.ToDecimal(txtPrecio.Text);
            room.idRoom=ID;


            try
            {
                if (room.idRoom == 0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Room.Save(room);
                        MessageBox.Show("Registro Guardado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (room.idRoom >= 0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Room.Save(room);
                        MessageBox.Show("Los datos han sido Modificados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Inicializar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Habitaciones frmRoom = new Habitaciones();
            frmRoom.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Habitaciones habitaciones =new Habitaciones();
            
            if (habitaciones.ShowDialog()==DialogResult.OK)
            {
                E_Room room = B_Room.GetByID(habitaciones.ID);
                ID = room.idRoom;
                txtPrecio.Text = Math.Round(room.precio,2).ToString();
                cbCategoria.Text = room.Catenombre;
                cbEstado.Text = room.StatusNombre;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
