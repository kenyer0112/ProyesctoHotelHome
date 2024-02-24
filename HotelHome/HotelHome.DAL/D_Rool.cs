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
   public class D_Rool:Conexion
    {

        public static void CreateRool(Rool rool)
        {
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_crearRool", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", rool.nombre);
                cmd.ExecuteNonQuery();


            }

        }

        public static void UpdateRool(Rool rool)
        {
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateRool", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", rool.nombre);
                cmd.Parameters.AddWithValue("@ID",rool.id);
                cmd.ExecuteNonQuery();


            }
        }


        public static List<Rool> GetAll()
        {
            List<Rool> list=new List<Rool>();
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string sql = "select * from Rool";
                SqlCommand cmd=new SqlCommand(sql, conex);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   list.Add(ConvertOBJ(reader));
                }




            }
            return list;
        }

        private static Rool ConvertOBJ(IDataReader reader)
        {
            Rool rool = new Rool();

            rool.id = reader.GetInt32(0);
            rool.nombre = reader.GetString(1);

            return rool;
        }


    }
}
