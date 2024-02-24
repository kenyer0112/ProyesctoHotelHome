using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHome.Entity
{
   public class E_Reserva
    {
		public E_Reserva()
        {
			Detalle = new List<E_DetalleReserva>();
		}


		public List<E_DetalleReserva> Detalle;

    public int idReserva { get; set; }
	public	int idCliente { get; set; }
	public DateTime fecha { get; set; }
	public	int idUsuario { get; set; }

		//Propiedades Para convertir to OBJ

		public string nombre { get; set; }
		public string apellido { get; set; }
		public string email { get; set; }
		public string documento { get; set; }
		public double totalC { get; set; }
		public double impuestoC { get; set; }
		public double subC { get; set; }

		public double TotalSubtotal
        {
            get
            {
				return (from d in Detalle select d.SubTotal).Sum();
            }
        }

		public double Impuesto
		{
			get
			{
				return(from d in Detalle select d.Impuesto).Sum();
			}
		}

		public double Descuento
		{
			get
			{
				return (from d in Detalle select d.descuento).Sum();
			}
		}

		public double Total
		{
			get
			{
				return TotalSubtotal - Descuento + Impuesto;
			}
		}




	
		

	}




}

	