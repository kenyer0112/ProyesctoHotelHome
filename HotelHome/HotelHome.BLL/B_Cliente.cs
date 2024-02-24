using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.DAL;
using HotelHome.Entity;

namespace HotelHome.BLL
{
   public class B_Cliente
    {
        public static void Save(E_Cliente e_Cliente)
        {
            if (e_Cliente.idCliente==0)
            {
                D_Cliente.Create(e_Cliente);
            }
            else
            {
                D_Cliente.Update(e_Cliente);
            }


        }

        public static List<E_Cliente> GetByValor(string valor)
        {
            return D_Cliente.GetByValor(valor);
        }
        public static List<E_Cliente> GetAll()
        {
            return D_Cliente.GetAll();
        }

        public static E_Cliente GetById(int id)
        {
            return D_Cliente.GetByID(id);
        }
        public static List<E_Cliente> BuscarById(int id)
        {
            return D_Cliente.BuscarById(id);
        }

    }
}
