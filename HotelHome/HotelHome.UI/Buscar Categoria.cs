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
    public partial class Buscar_Categoria : Form
    {
        public Buscar_Categoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicializar()
        {
            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.DataSource = B_Categoria.GetAll();
        }
        private void Buscar_Categoria_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = txtValor.Text;
            dgCategoria.DataSource = B_Categoria.GetByValo(valor);

        }
    }
}
