using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.DAL;
using HotelHome.Entity;
using System.Data;

namespace HotelHome.BLL
{
   public class B_Reserva
    {
        public static void Save(E_Reserva reserva)
        {

            D_Reserva.Create(reserva);
        }

        public static int GetTotalReselvas()
        {
            return D_Reserva.GetTotalReselvas();
        }

        public static List<E_Reserva> BuscarReservas(string valor)
        {
            return D_Reserva.BuscarReservas(valor);
        }
        public static List<E_Reserva> GetAllReservas()
        {
            return D_Reserva.GetAllReservas();
        }
        public static List<E_Reserva> BuscarReservasByID(int ID)
        {
            return D_Reserva.BuscarReservasByID(ID);
        }

        public static DataTable GetAllDetalle()
        {
            return D_Reserva.GetAllDetalle();
        }
        public static DataTable BuscarByIDDetalle(int id)
        {
            return D_Reserva.BuscarByIDDetalle(id);
        }

        }
}
