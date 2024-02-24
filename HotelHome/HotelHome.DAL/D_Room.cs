using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelHome.Entity;
using System.Data.SqlClient;
using System.Data;

namespace HotelHome.DAL
{
   public class D_Room:Conexion
    {

        public static void Create(E_Room e_Room)
        {

            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertRoom",conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPiso", e_Room.idPiso);
                cmd.Parameters.AddWithValue("@idCategoria", e_Room.idCategoria);
                cmd.Parameters.AddWithValue("@precio", e_Room.precio);
                cmd.Parameters.AddWithValue("@idEstado", e_Room.idEstado);
                cmd.ExecuteNonQuery();

            }

        }

        public static void Update(E_Room e_Room)
        {

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateRoom", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPiso", e_Room.idPiso);
                cmd.Parameters.AddWithValue("@idCategoria", e_Room.idCategoria);
                cmd.Parameters.AddWithValue("@precio", e_Room.precio);
                cmd.Parameters.AddWithValue("@idEstado", e_Room.idEstado);
                cmd.Parameters.AddWithValue("@ID", e_Room.idRoom);
                cmd.ExecuteNonQuery();

            }

        }

        public static void UpdateNodisponible(int id)
        {
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateRoomNodisponible", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
               
                cmd.ExecuteNonQuery();

            }


        }
        public static void UpdateMantenimiento(int id)
        {
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateRoomMantenimiento", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery();

            }


        }
        public static void UpdateStadoAgregacion()
        {

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateStadoAgregacion", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

            }

        }

        public static List<E_Room> GetALLRoom()
        {
            List<E_Room> list = new List<E_Room>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("sp_GetAllRoom2", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ComvertOBj(reader));
                }


            }

            return list;

        }

        public static List<E_Room> GetALL()
        {
            List<E_Room> list = new List<E_Room>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                
                SqlCommand cmd = new SqlCommand("sp_GetAllRoom", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ComvertOBj(reader));
                }


            }

            return list;

        }

        public static List<E_Room> GetALLNoDisponibles()
        {
            List<E_Room> list = new List<E_Room>();
        

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("sp_GetAllRoomNoDisponible", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                  
                    list.Add(ComvertObj2(reader));
                }


            }

            return list;

        }
        public static List<E_Room> GetALLMatenimiento()
        {
            List<E_Room> list = new List<E_Room>();

      
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("sp_GetAllMantenimiento", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                
                    list.Add(ComvertObj2(reader));
                }


            }

            return list;

        }
        public static List<E_Room> GetByValor(string valor)
        {
            List<E_Room> list = new List<E_Room>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("sp_BuscarRoom", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor",valor);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ComvertOBj(reader));
                }


            }

            return list;

        }

        public static E_Room GetBYID(int ID)
        {
            E_Room e_Room =new E_Room();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("sp_GetByIDRoom", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    e_Room = ComvertOBj(reader);
                }


            }

            return e_Room;

        }



        public static E_Room GetBYIDUpdate(int ID)
        {
            E_Room e_Room = new E_Room();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("sp_GetByIDRoomUpdate", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    e_Room = ComvertOBj(reader);
                }


            }

            return e_Room;

        }
           
        public static int GetHabitacioneDisponibles()
        {
            int cantidad=0;

            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string consulta = "select COUNT(*) from Room where idEstado = 2";
                SqlCommand cmd = new SqlCommand(consulta, conex);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = reader.GetInt32(0);
                }
            }


            return cantidad;

        }

        public static int GetHabitacioneOcupadas()
        {
            int cantidad=0 ;

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string consulta = "select COUNT(*) from Room where idEstado = 3";
                SqlCommand cmd = new SqlCommand(consulta, conex);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = reader.GetInt32(0);
                }
            }


            return cantidad;

        }
        public static int GetHabitacioneMatenimiento()
        {
            int cantidad = 0;

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string consulta = "select COUNT(idestado) from Room where idEstado =1";
                SqlCommand cmd = new SqlCommand(consulta, conex);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = reader.GetInt32(0);
                }
            }


            return cantidad;

        }
        private static E_Room ComvertOBj(IDataReader reader)
        {
            E_Room room = new E_Room();

            room.idRoom = reader.GetInt32(0);
            room.Catenombre = reader.GetString(1);
            room.precio = reader.GetDecimal(2);
            room.size = reader.GetString(3);
            room.pisoName = reader.GetString(4);
            room.StatusNombre = reader.GetString(5);
            
          
            return room;
        }

        private static E_Room ComvertObj2(IDataReader reader)
        {
            E_Room room = new E_Room();

            room.idRoom = reader.GetInt32(0);
            room.Catenombre = reader.GetString(1);
            room.precio = reader.GetDecimal(2);
            room.size = reader.GetString(3);
            room.pisoName = reader.GetString(4);
            room.StatusNombre = reader.GetString(5);
            room.fecha = reader.GetDateTime(6);

            return room;
        }
    }
}
