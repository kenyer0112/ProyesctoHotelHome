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
    public partial class BuscarUsuarios : Form
    {
        public BuscarUsuarios()
        {
            InitializeComponent();
        }
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
        }
        private void Inicializar()
        {
            
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = B_Usuario.GetALL();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void BuscarUsuarios_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }


            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
