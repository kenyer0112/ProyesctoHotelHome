using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHome.Entity
{
   public class E_DetalleReserva
    {
	    public	int idDetalle { get; set; }
	    public	int idReserva { get; set; }
	    public	double precio { get; set; }
        public int idRoom { get; set; }
        public string categoria { get; set; }
        public string status { get; set; }
        public DateTime fechaLLegada { get; set; }
        public DateTime fechaSalida { get; set; }

        public 	int cantidadNoche { get; set; }
        public double descuento { get; set; } = 0;

  

        
		public  double SubTotal
        {
			get
            {
				return  precio * cantidadNoche;
            }
        }

		public double Impuesto
        {
            get
            {
                return SubTotal * 0.18;
            }
        }


		public double Total
        {
            get
            {
                return SubTotal - descuento + Impuesto;
            }

        }





    }
}

