using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HotelHome.Entity;

namespace HotelHome.DAL
{
   public class D_Usuario:Conexion
    {
        public static bool Login(string user, string pass)
        {
            SqlConnection conex = new SqlConnection(cadenaConexion);

            conex.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conex;
            command.CommandText = "select u.ID,u.nombre,u.apellido,u.usuario,u.pass,u.Email,r.nombre as rool from Users as u  inner join Rool as r on r.ID=u.ID where u.usuario=@user and u.pass=@pass";
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    E_Usuario.IdUser = reader.GetInt32(0);
                    E_Usuario.FirstName = reader.GetString(1);
                    E_Usuario.LastName = reader.GetString(2);
                    E_Usuario.LoginName = reader.GetString(3);
                    E_Usuario.Password = reader.GetString(4);
                    E_Usuario.Email = reader.GetString(5);
                    E_Usuario.rool=reader.GetString(6);


                }
                return true;
            }
            else
                conex.Close();
            return false;




        }
        


        public static void InserUser()
        {
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertUser", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", E_Usuario.FirstName);
                cmd.Parameters.AddWithValue("@apellido", E_Usuario.LastName);
                cmd.Parameters.AddWithValue("@usuario", E_Usuario.LoginName);
                cmd.Parameters.AddWithValue("@pass", E_Usuario.Password);
                cmd.Parameters.AddWithValue("@Rool", E_Usuario.Position);
                cmd.Parameters.AddWithValue("@Email", E_Usuario.Email);
                cmd.ExecuteNonQuery();



            }
        }
   

        public static void UpdateUsuario(int id)
        {

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateUser", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", E_Usuario.LoginName);
                cmd.Parameters.AddWithValue("@pass", E_Usuario.Password);
                cmd.Parameters.AddWithValue("@nombre", E_Usuario.FirstName);
                cmd.Parameters.AddWithValue("@apellido", E_Usuario.LastName);
                cmd.Parameters.AddWithValue("@Rool", E_Usuario.Position);
                cmd.Parameters.AddWithValue("@Email", E_Usuario.Email);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();

            }
        }



        public static DataTable GetALL()
        {

            SqlConnection conex = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand("sp_GetAllUser", conex);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }
     

        public static DataTable BuscarByValor(string valor)
        {
            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("GetUserByValor", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor", valor);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }

        }
    }
}
