using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.DAL;
using HotelHome.Entity;
namespace HotelHome.BLL
{
   public class B_Piso
    {

        public static void Save(E_Piso Piso)
        {

            if (Piso.Id==0)
            {
                D_Piso.Create(Piso);
            }
            else
            {
                D_Piso.Update(Piso);
            }


        }

        public static List<E_Piso> GetByvalor(string valor)
        {
            return D_Piso.GetByvalor(valor);
        }
        public static List<E_Piso> GetAll()
        {
           return D_Piso.GetAll();
        }

    }
}
