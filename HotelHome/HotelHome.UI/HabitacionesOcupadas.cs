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
    public partial class HabitacionesOcupadas : Form
    {
        public HabitacionesOcupadas()
        {
            InitializeComponent();
        }

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    string valor = txtBuscar.Text;
        //    dgHabitaciones.DataSource = B_Room.GetByValor(valor);
        //    txtBuscar.Clear();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabitacionesOcupadas_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            dgHabitaciones.AutoGenerateColumns = false;
            dgHabitaciones.DataSource = B_Room.GetALLNoDisponibles();
        }
       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= dgHabitaciones.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(dgHabitaciones.Rows[i].Cells[7].Value) == true)
                    {
                        B_Room.UpdateNodisponible(Convert.ToInt32(dgHabitaciones.Rows[i].Cells[0].Value));
                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Inicializar();
        }
    }
}
