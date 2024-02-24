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
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }
        private int _idCliente;

        const string titulo = "Sistema Hotelero";
        public int ID
        {
            get
            {
                return _idCliente;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            Inicializar();

        }

        private void Inicializar()
        {
            dgClientes.AutoGenerateColumns = false;
            dgClientes.DataSource = B_Cliente.GetAll();
        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }


        _idCliente =Convert.ToInt32(dgClientes.CurrentRow.Cells[0].Value);
        this.DialogResult = DialogResult.OK;
        this.Close();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
          

          
            if (!(string.IsNullOrEmpty(txtBuscar.Text)))
            {
                string valor = txtBuscar.Text;
                dgClientes.DataSource = B_Cliente.GetByValor(valor);
                txtBuscar.Clear();
            }
            else if (txtBuscar.Text=="")
            {
                Inicializar();
            }
        }

        private void BuscarClientes_Click(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
