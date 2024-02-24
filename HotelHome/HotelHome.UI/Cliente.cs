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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
       const string titulo = "Sistema Hotelero";
        private void Cliente_Load(object sender, EventArgs e)
        {

        }


        int ID;

        private bool Validar()
        {
            bool resultado = true;
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "Ingrese el nombre");
                resultado = false;
            }
           if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "Ingrese el apellido");
                resultado = false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Ingrese el Email");
                resultado = false;
            }

            if (!mkDoc.MaskCompleted)
            {
                errorProvider.SetError(mkDoc, "Ingrese el Documento");
                resultado = false;
            }

            if (!mkTelefono.MaskCompleted)
            {
                errorProvider.SetError(mkTelefono, "Ingrese el Telefono");
                resultado = false;
            }
            if (txtFecha.Value==DateTime.Now)
            {
                errorProvider.SetError(txtFecha, "Ingrese La fecha nacimiento");
                resultado = false;
            }

            return resultado;
        }

        private void Inicializar()
        {
            ID = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtFecha.Value = DateTime.Now;
            mkDoc.Clear();
            mkTelefono.Clear();
            txtEmail.Clear();
            errorProvider.Clear();
        }

      

    

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarClientes frmBuscar = new BuscarClientes();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                E_Cliente cliente = B_Cliente.GetById(frmBuscar.ID);

                ID= cliente.idCliente;
                txtNombre.Text = cliente.nombre;
                txtApellido.Text = cliente.apellido;
                txtEmail.Text = cliente.email;
                mkDoc.Text = cliente.Documento;
                mkTelefono.Text = cliente.telefono;
                txtFecha.Value = cliente.fechaNac;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            E_Cliente Cliente = new E_Cliente();
            Cliente.idCliente = ID;
            Cliente.nombre = txtNombre.Text;
            Cliente.apellido = txtApellido.Text;
            Cliente.Documento = mkDoc.Text;
            Cliente.email = txtEmail.Text;
            Cliente.telefono = mkTelefono.Text;
            Cliente.fechaNac = txtFecha.Value;
            Cliente.idUsuario = 1;


            try
            {

                if (Cliente.idCliente == 0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Cliente.Save(Cliente);
                        MessageBox.Show("Registro Guardado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (Cliente.idCliente > 0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Cliente.Save(Cliente);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
