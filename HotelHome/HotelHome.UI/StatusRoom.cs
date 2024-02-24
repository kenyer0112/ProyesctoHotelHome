using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelHome.Entity;
using HotelHome.BLL;

namespace HotelHome.UI
{
    public partial class StatusRoom : Form
    {
        public StatusRoom()
        {
            InitializeComponent();
        }

        const string titulo = "Sistema Hotelero";

        private void Status_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private Boolean Validar()
        {
            bool resultado = true;

            errorProvider.Clear();
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider.SetError(txtName, "Escriba el nombre");
                resultado = false;
            }

           

            return resultado;
        }

        private void Inicializar()
        {
            txtId.Text = 0.ToString();
            txtName.Clear();

            dgStatus.AutoGenerateColumns = false;
            dgStatus.DataSource =B_StatusRoom.GetAll() ;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            E_StatusRoom statusRoom = new E_StatusRoom();
            statusRoom.idStatus = int.Parse(txtId.Text);
            statusRoom.nombre = txtName.Text;

            try
            {
                if (statusRoom.idStatus == 0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_StatusRoom.Save(statusRoom);
                        MessageBox.Show("Registro Guardado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (statusRoom.idStatus >= 0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_StatusRoom.Save(statusRoom);
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
                MessageBox.Show(ex.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Inicializar();
        }

        private void dgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgStatus.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgStatus.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = txtStatus.Text;
            dgStatus.DataSource=B_StatusRoom.GetbyValor(valor);
            txtStatus.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
