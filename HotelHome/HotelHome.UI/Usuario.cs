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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
       private int id { get; set; }
        const string titulo = "Sistema Hotelero";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarUser()
        {
            bool resultado = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "Ingrese el Nombre");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Ingrese el Email");
                resultado = false;
            }

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                errorProvider.SetError(txtUser, "Ingrese el Nombre");
                resultado = false;
            }


            return resultado;

        }

        private void Inicializar()
        {
            id = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtUser.Clear();
            txtPass.Clear();
            CargarUsuario();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = B_Usuario.GetALL();

        }
        private void Usuario_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void CargarUsuario()
        {
            comRool.ValueMember = "id";
            comRool.DisplayMember = "nombre";
             comRool.DataSource=B_Rool.GetAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarUser())
            {
                return;
            }

            int ID = id;
            E_Usuario.FirstName = txtNombre.Text;
            E_Usuario.LastName=txtApellido.Text;
            E_Usuario.Email = txtEmail.Text;
            E_Usuario.Password = txtPass.Text;
            E_Usuario.LoginName=txtUser.Text;
            E_Usuario.Position = Convert.ToInt32(comRool.SelectedValue);


            try
            {

                if (ID>0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Usuario.Save(id);
                        MessageBox.Show("Registro Modificado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else 
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Usuario.Save(id);
                        MessageBox.Show("Registro Guardado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button3_Click(object sender, EventArgs e)
        {
            CrearRool rool=new CrearRool();
            rool.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          


        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
            txtNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtApellido.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUser.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            txtPass.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtBuscar.Text)))
            {
                string valor = txtBuscar.Text;
                dataGridView1.DataSource = B_Usuario.BuscarByValor(valor);
                txtBuscar.Clear();
            }
            else if (txtBuscar.Text == "")
            {
                Inicializar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
