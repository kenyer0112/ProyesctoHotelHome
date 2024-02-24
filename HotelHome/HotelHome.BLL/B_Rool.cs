using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.DAL;
using HotelHome.Entity;

namespace HotelHome.BLL
{
   public  class B_Rool
    {
        public static void Saved(Rool rool)
        {
            if (rool.id==0)
            {
                D_Rool.CreateRool(rool);
            }
            else
            {
                D_Rool.UpdateRool(rool);
            }

            
        }
        public static List<Rool> GetAll()
        {
            return D_Rool.GetAll();
        }
    }
}
