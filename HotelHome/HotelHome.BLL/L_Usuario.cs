using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
using System.Data;

namespace Logica
{
    public class L_Usuario
    {
       D_Usuario d_Usuario = new D_Usuario();
     
        public bool LoginUser(string user, string pass)
        {
            return d_Usuario.Login(user, pass);
        }
        public bool EditContraeaña(int user, string pass)
        {
            if (user == E_Usuario.IdUser)
            {

            }
            return true;
        }
        
       public void InsertarUsuario()
        {

            d_Usuario.InsertaUsuario();

        }

        public DataTable MonstarDatos()
        {
           return d_Usuario.MostrarDatos();
        }

       public void EliminarUsuario()
        {
            d_Usuario.EliminarUsuario();
        }

        public void ActulizarUsuario()
        {
            d_Usuario.ActulizarUsuario();
        }

        public  DataTable BuscarUser()
        {
            return d_Usuario.BuscarUser();
        }
      
    }
}
