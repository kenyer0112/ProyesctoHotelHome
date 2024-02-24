using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.Entity;
using HotelHome.DAL;

namespace HotelHome.BLL
{
  public  class B_Room
    {

        public static void Save(E_Room Room)
        {
            

            if (Room.idRoom==0)
            {
                D_Room.Create(Room);
            }
            else
            {
                D_Room.Update(Room);
            }


        }

        public static void UpdateNodisponible(int id)
        {
            D_Room.UpdateNodisponible(id);
        }
        public static void UpdateMantenimiento(int id)
        {
           D_Room.UpdateMantenimiento(id);
        }
        public static List<E_Room> GetALL()
        {
           return D_Room.GetALL();
        }

        public static E_Room GetByID(int id)
        {
            return D_Room.GetBYID(id);
        }

        public static E_Room GetBYIDUpdate(int ID)
        {
            return D_Room.GetBYIDUpdate(ID);
        }

        public static List<E_Room> GetByValor(string valor)
        {
            return D_Room.GetByValor(valor);
        }
        public static int GetHabitacioneDisponibles()
        {
            return D_Room.GetHabitacioneDisponibles();
        }

        public static int GetHabitacioneOcupadas()
        {
            return D_Room.GetHabitacioneOcupadas();

        }
        public static List<E_Room> GetALLNoDisponibles()
        {
            return D_Room.GetALLNoDisponibles();
        }

        public static void UpdateStadoAgregacion()
        {
            D_Room.UpdateStadoAgregacion();
        }
        public static int GetHabitacioneMatenimiento()
        {
            return D_Room.GetHabitacioneMatenimiento();
        }

        public static List<E_Room> GetALLMatenimiento()
        {
            return D_Room.GetALLMatenimiento();
        }

        public static List<E_Room> GetALLRoom()
        {
            return D_Room.GetALLRoom();
        }

        }
}
