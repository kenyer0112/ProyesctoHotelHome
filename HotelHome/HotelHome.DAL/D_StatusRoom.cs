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
   public class D_StatusRoom:Conexion
    {

        public static void Create(E_StatusRoom statusRoom)
        {
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertStatusRoom", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", statusRoom.nombre);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(E_StatusRoom statusRoom)
        {
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateStatusRoom", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", statusRoom.nombre);
                cmd.Parameters.AddWithValue("@ID", statusRoom.idStatus);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<E_StatusRoom> GetAll ()
        {
            List<E_StatusRoom> list = new List<E_StatusRoom>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string sql = "Select *  from StatusRoom";
                SqlCommand cmd = new SqlCommand(sql, conex);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(CreateOBJ(reader));
                }
            }

            return list;
        }

        public static List<E_StatusRoom> GetbyValor(string valor)
        {
            List<E_StatusRoom> list = new List<E_StatusRoom>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                
                SqlCommand cmd = new SqlCommand("sp_BuscarStatus", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor",valor);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(CreateOBJ(reader));
                }
            }

            return list;
        }

        private static E_StatusRoom CreateOBJ(IDataReader reader)
        {

            E_StatusRoom statusRoom = new E_StatusRoom();

            statusRoom.idStatus = reader.GetInt32(0);
            statusRoom.nombre = reader.GetString(1);
            return statusRoom;


        }

    }
}
