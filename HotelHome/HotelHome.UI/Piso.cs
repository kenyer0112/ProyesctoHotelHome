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
    public partial class Piso : Form
    {
        public Piso()
        {
            InitializeComponent();
        }
        const string titulo = "Sistema Hotelero";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!Validar())
            {
                return;
            }
            E_Piso piso = new E_Piso();

           piso.Id = int.Parse(txtID.Text);
           piso.descripcion = txtDescripcion.Text;
           piso.stock=int.Parse(txtStock.Text);


            try
            {
                if (piso.Id==0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios",titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                    {
                        B_Piso.Save(piso);
                        MessageBox.Show("Registro Guardado Correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                     
                        MessageBox.Show("Cambios Cancelados", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
               else if (piso.Id >=0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Piso.Save(piso);
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


        private void Inicializar()
        {
            txtID.Text = 0.ToString();
            txtDescripcion.Clear();
            txtStock.Clear();
            dgtPiso.AutoGenerateColumns = false;
            dgtPiso.DataSource = B_Piso.GetAll();

        }

        private Boolean Validar()
        {
            bool resultado = true;

            errorProvider.Clear();
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "Escriba la decripcion");
                resultado = false;
            }

             if (string.IsNullOrEmpty(txtStock.Text))
            {
                errorProvider.SetError(txtStock, "Escriba la Cantidad");
                resultado = false;

            }
            return resultado;

        }

        private void Piso_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void dgtPiso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgtPiso.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgtPiso.CurrentRow.Cells[1].Value.ToString();
            txtStock.Text = dgtPiso.CurrentRow.Cells[2].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = txtPiso.Text;
            dgtPiso.DataSource=B_Piso.GetByvalor(valor);
            txtPiso.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
