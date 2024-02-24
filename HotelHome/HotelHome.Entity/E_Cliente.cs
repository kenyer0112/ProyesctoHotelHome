using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHome.Entity
{
   public class E_Cliente
    {

        public E_Cliente()
        {

        }

        public int idCliente { get; set; }
        public string Documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNac { get; set; }
        public string email { get; set; }

        public string telefono { get; set; }

        public int idUsuario { get; set; }





    }
}
