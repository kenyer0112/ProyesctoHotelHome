using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.Entity;
using HotelHome.DAL;

namespace HotelHome.BLL
{
   public class B_StatusRoom
    {

        public static void Save(E_StatusRoom statusRoom)
        {

            
            if (statusRoom.idStatus==0)
            {
                D_StatusRoom.Create(statusRoom);
            }
            else
            {
                D_StatusRoom.Update(statusRoom);
            }


        }
        public static List<E_StatusRoom> GetbyValor(string valor)
        {
            return D_StatusRoom.GetbyValor(valor);
        }

        public static List<E_StatusRoom> GetAll()
        {
            return D_StatusRoom.GetAll();
        }

   }
}
