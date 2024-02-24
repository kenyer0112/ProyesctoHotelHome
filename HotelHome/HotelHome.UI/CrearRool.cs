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
    public partial class CrearRool : Form
    {
        public CrearRool()
        {
            InitializeComponent();
        }
        const string titulo = "Sistema Hotelero";
        private void Inicializar()
        {
            txtId.Text = 0.ToString();
            txtName.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = B_Rool.GetAll();
           

           
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
        private void CreatarRool_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            Rool rool=new Rool();
            rool.nombre = txtName.Text;
            rool.id=Convert.ToInt32(txtId.Text);


            try
            {
                if (rool.id==0)
                {

                    if (MessageBox.Show("Desea Aplicar Cambios", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        B_Rool.Saved(rool);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
