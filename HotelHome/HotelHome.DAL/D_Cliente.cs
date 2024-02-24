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
   public class D_Cliente:Conexion
    {

        public static void Create(E_Cliente e_Cliente)
        {
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertCliente", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documento", e_Cliente.Documento);
                cmd.Parameters.AddWithValue("@nombre", e_Cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", e_Cliente.apellido);
                cmd.Parameters.AddWithValue("@fechaNac", e_Cliente.fechaNac);
                cmd.Parameters.AddWithValue("@email", e_Cliente.email);
                cmd.Parameters.AddWithValue("@telefono", e_Cliente.telefono);
                cmd.Parameters.AddWithValue("@idUsuario", e_Cliente.idUsuario);
                e_Cliente.idCliente=Convert.ToInt32(cmd.ExecuteScalar());



            }

        }

        public static void Update(E_Cliente e_Cliente)
        {
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateCliente", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@documento", e_Cliente.Documento);
                cmd.Parameters.AddWithValue("@nombre", e_Cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", e_Cliente.apellido);
                cmd.Parameters.AddWithValue("@fechaNac", e_Cliente.fechaNac);
                cmd.Parameters.AddWithValue("@email", e_Cliente.email);
                cmd.Parameters.AddWithValue("@telefono", e_Cliente.telefono);
                cmd.Parameters.AddWithValue("@id", e_Cliente.idCliente);
                cmd.ExecuteNonQuery();

            }
        }


        public static List<E_Cliente> GetAll()
        {
            List<E_Cliente> list = new List<E_Cliente>();
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string sql = "select * from Cliente";
                SqlCommand cmd=new SqlCommand(sql,conex);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   list.Add(ComvertOBj(reader));
                }

            }


            return list;

        }

        public static List<E_Cliente> BuscarById(int id)
        {
            List<E_Cliente> list = new List<E_Cliente>();
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
           
                SqlCommand cmd = new SqlCommand("sp_BuscarClienteID", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    list.Add(ComvertOBj(reader));
                }
     
            }


            return list;

        }
        public static E_Cliente GetByID(int id)
        {
            E_Cliente e_Cliente=new E_Cliente();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string sql = $"select * from Cliente where IdCliente like {id}";
                SqlCommand cmd = new SqlCommand(sql,conex);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    e_Cliente = ComvertOBj(reader);
                }


            }
            
            return e_Cliente;

        }

        public static List<E_Cliente> GetByValor(string valor)
        {
            List <E_Cliente> list =new List<E_Cliente>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
              
                SqlCommand cmd = new SqlCommand("sp_BuscarCliente", conex);
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
        private static E_Cliente ComvertOBj (IDataReader reader)
        {
            E_Cliente e_cliente = new E_Cliente();

            e_cliente.idCliente = reader.GetInt32(0);
            e_cliente.Documento = reader.GetString(1);
            e_cliente.nombre = reader.GetString(2);
            e_cliente.apellido= reader.GetString(3);
            e_cliente.fechaNac = reader.GetDateTime(4);
            e_cliente.email = reader.GetString(5);
            e_cliente.telefono = reader.GetString(6);

            return e_cliente;
        }
    


    }
}
