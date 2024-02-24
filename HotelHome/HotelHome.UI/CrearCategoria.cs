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
    public partial class CrearCategoria : Form
    {
        public CrearCategoria()
        {
            InitializeComponent();
        }

        const string titulo = "Sistema Hotelero";
        private void CrearCategoria_Load(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(txtSize.Text))
            {
                errorProvider.SetError(txtSize, "Escriba el Size");
                resultado = false;
            }

            return resultado;
        }


        private void Inicializar()
        {
            txtId.Text = 0.ToString();
            txtName.Clear();
            txtSize.Clear();

            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.DataSource = B_Categoria.GetAll() ;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



            if (!Validar())
            {
                return;
            }

            E_Categoria categoria=new E_Categoria();

            categoria.ID = int.Parse(txtId.Text);
            categoria.Name = txtName.Text;
            categoria.size = txtSize.Text;


            try
            {
                if (categoria.ID==0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Categoria.Save(categoria);
                        MessageBox.Show("Registro Guardado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (categoria.ID>= 0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Categoria.Save(categoria);
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

    

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string valor;
            valor = txtValor.Text;

            dgCategoria.DataSource = B_Categoria.GetByValo(valor);
            txtValor.Clear();

        }

        private void dgCategoria_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgCategoria.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgCategoria.CurrentRow.Cells[1].Value.ToString();
            txtSize.Text = dgCategoria.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
