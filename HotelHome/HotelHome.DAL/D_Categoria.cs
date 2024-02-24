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
   public class D_Categoria:Conexion
    {

        public static void Create(E_Categoria categoria)
        {
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
               
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertCategoria", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", categoria.Name);
                cmd.Parameters.AddWithValue("@size", categoria.size);
                cmd.ExecuteNonQuery();
            }


        }

        public static void Update(E_Categoria categoria)
        {
            using (SqlConnection conex =new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateCategoria", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", categoria.Name);
                cmd.Parameters.AddWithValue("@size", categoria.size);
                cmd.Parameters.AddWithValue("@ID", categoria.ID);
                cmd.ExecuteNonQuery();


            }
        }
        
        public static List<E_Categoria> GetAll()
        {
            List<E_Categoria> list=new List<E_Categoria>();
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string sql = "select * from Categoria";
                SqlCommand cmd=new SqlCommand(sql, conex);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   list.Add(ConvertObj(reader));
                }
            }

            return list;
        }

        public static List<E_Categoria> GetByValor(string valor)
        {
            List<E_Categoria> list = new List<E_Categoria>();
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                
                SqlCommand cmd = new SqlCommand("sp_BuscarCategoria", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor",valor);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ConvertObj(reader));
                }
            }

            return list;
        }

        private static E_Categoria ConvertObj(IDataReader reader)
        {
            E_Categoria categoria = new E_Categoria();

            categoria.ID = reader.GetInt32(0);
            categoria.Name = reader.GetString(1);
            categoria.size= reader.GetString(2);

            return categoria;
        }
    }
}
