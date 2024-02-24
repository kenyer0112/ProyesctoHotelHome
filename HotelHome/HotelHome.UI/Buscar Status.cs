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

namespace HotelHome.UI
{
    public partial class Buscar_Status : Form
    {
        public Buscar_Status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicializar()
        {
            dgStatus.AutoGenerateColumns = false;
            dgStatus.DataSource = B_StatusRoom.GetAll();
        }
        private void Buscar_Status_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = txtStatus.Text;
           dgStatus.DataSource= B_StatusRoom.GetbyValor(valor);
        }
    }
}
