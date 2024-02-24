using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.Entity;
using HotelHome.DAL;

namespace HotelHome.BLL
{
   public class B_Categoria
    {
        public static void Save(E_Categoria categoria)
        {
            if (categoria.ID==0)
            {
                D_Categoria.Create(categoria);
            }
            else
            {
                D_Categoria.Update(categoria);
            }
        }
        public static List<E_Categoria> GetByValo(string valor)
        {
            return D_Categoria.GetByValor(valor);
        }

        public static List<E_Categoria> GetAll()
        {
            return D_Categoria.GetAll();
        }
    }
}
