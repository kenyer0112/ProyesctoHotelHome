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
    public partial class Habitaciones_Mantenimiento : Form
    {
        public Habitaciones_Mantenimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicializar()
        {
            dgHabitaciones.AutoGenerateColumns = false;
            dgHabitaciones.DataSource = B_Room.GetALLMatenimiento();
            
        }
        private void Habitaciones_Mantenimiento_Load(object sender, EventArgs e)
        {
            Inicializar();

        }
       

        private void btnActulizar_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i <= dgHabitaciones.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(dgHabitaciones.Rows[i].Cells[7].Value) == true)
                    {
                        B_Room.UpdateMantenimiento(Convert.ToInt32(dgHabitaciones.Rows[i].Cells[0].Value));
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
