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
    public class D_Piso:Conexion
    {
        public static void Create(E_Piso e_Piso)
        {
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertPiso", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcio", e_Piso.descripcion);
                cmd.Parameters.AddWithValue("@stock", e_Piso.stock);
                cmd.ExecuteNonQuery();
            }

        }


        public static void Update(E_Piso piso)
        {
            using (SqlConnection conex= new SqlConnection(cadenaConexion))
            {
                conex.Open();

                SqlCommand cmd = new SqlCommand("sp_UpdatePiso", conex);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion",piso.descripcion);
                cmd.Parameters.AddWithValue("@stock", piso.stock);
                cmd.Parameters.AddWithValue("@ID", piso.Id);
                cmd.ExecuteNonQuery();

            }

        }

        public static List<E_Piso> GetAll()
        {
            List<E_Piso> list=new List<E_Piso>();
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string sql = "select * from Piso ";
                SqlCommand cmd = new SqlCommand(sql, conex);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ConvertObj(reader));
                }



            }
            return list;
        }
        
        public static List<E_Piso> GetByvalor(string valor)
        {
            List<E_Piso> list = new List<E_Piso>();
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                
                SqlCommand cmd = new SqlCommand("sp_BuscarPiso", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor", valor);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ConvertObj(reader));
                }



            }
            return list;
        }

        private static E_Piso ConvertObj(IDataReader reader)
        {
            E_Piso piso=new E_Piso();

            piso.Id = reader.GetInt32(0);
            piso.descripcion = reader.GetString(1);
            piso.stock=reader.GetInt32(2);

            return piso;

        }



    }
}
