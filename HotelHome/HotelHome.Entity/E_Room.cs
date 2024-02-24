using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHome.Entity
{
   public class E_Room
    {
        public E_Room()
        {

        }

         
        public int idRoom { get; set; }
        public int idCategoria { get; set; }
        public int idPiso { get; set; }
        public decimal precio { get; set; }
        public int idEstado { get; set; }
        public DateTime fecha { get; set; }
        public string Catenombre { get; set; }
        public  string StatusNombre { get; set; }
        public  string pisoName { get; set; }
        public  string size { get; set; }




    }
}
