using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.Entity;
using HotelHome.DAL;
using System.Data;

namespace HotelHome.BLL
{
    public class B_Usuario
    {

        public static bool LoginUser(string user, string pass)
        {
            return D_Usuario.Login(user, pass);
        }
        public static bool EditContraeaña(int user, string pass)
        {
            if (user == E_Usuario.IdUser)
            {

            }
            return true;
        }

        public static void Save(int id)
        {

            if (id>0)
            {
                D_Usuario.UpdateUsuario(id);
            }
            else
            {
                D_Usuario.InserUser();
            }


           
            
        }




        public static DataTable BuscarByValor(string valor)
        {
           return D_Usuario.BuscarByValor(valor);
        }



        public static DataTable GetALL()
        {
            return D_Usuario.GetALL();
        }
    }
}
