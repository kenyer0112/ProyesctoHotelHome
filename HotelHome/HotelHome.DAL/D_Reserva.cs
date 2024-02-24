using System;
using System.Collections.Generic;
using System.Linq;                                                                                          
using System.Text;
using System.Threading.Tasks;
using HotelHome.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Transactions;

namespace HotelHome.DAL
{
   public class D_Reserva:Conexion
    {
        public static void Create(E_Reserva reserva)                                                    

        {
            using (TransactionScope scope=new TransactionScope())
            {

            
            
                using (SqlConnection conex=new SqlConnection(cadenaConexion))
                {
                    conex.Open();
                
                    SqlCommand cmd = new SqlCommand("sp_InsertReserva", conex);
                    cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@idCliente", reserva.idCliente);
                    cmd.Parameters.AddWithValue("@subtotal", reserva.TotalSubtotal);
                     cmd.Parameters.AddWithValue("@impuesto", reserva.Impuesto);
                    cmd.Parameters.AddWithValue("@descuento", reserva.Descuento);
                    cmd.Parameters.AddWithValue("@total", reserva.Total);
                    cmd.Parameters.AddWithValue("@idUsuario", reserva.idUsuario);
                    reserva.idReserva = Convert.ToInt32(cmd.ExecuteScalar());

                    SqlCommand cmdD = new SqlCommand("sp_InsertDetalleReserva", conex);
                  
                    cmdD.CommandType = CommandType.StoredProcedure;

                    foreach (E_DetalleReserva detalle in reserva.Detalle)
                    {
                        cmdD.Parameters.Clear();
                        cmdD.Parameters.AddWithValue("@idRoom", detalle.idRoom);
                        cmdD.Parameters.AddWithValue("@idReserva", reserva.idReserva);
                        cmdD.Parameters.AddWithValue("@precio", detalle.precio);
                        cmdD.Parameters.AddWithValue("@cantidadN", detalle.cantidadNoche);
                        cmdD.Parameters.AddWithValue("@subtotalD", detalle.SubTotal);
                        cmdD.Parameters.AddWithValue("@impuestoD", detalle.Impuesto);
                        cmdD.Parameters.AddWithValue("@descuentoD", detalle.descuento);
                        cmdD.Parameters.AddWithValue("@totalD", detalle.Total);
                        cmdD.Parameters.AddWithValue("@fechaLlegada", detalle.fechaLLegada);
                        cmdD.Parameters.AddWithValue("@fechaSalida", detalle.fechaSalida);

                        

                        cmdD.ExecuteNonQuery();
                        UpdateStatusRoom(detalle.idRoom);



                    }


                    
                    
                }
                scope.Complete();
            }




        }

        public static List<E_Reserva> GetAllReservas()
        {
            List<E_Reserva> list = new List<E_Reserva>();

            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_GetAllReserva", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ComvertoObj(reader));
                }


            }

            return list;

        }

        public static List<E_Reserva> BuscarReservas(string valor)
        {
            List<E_Reserva> list = new List<E_Reserva>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_BuscarReserva", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor",valor);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(ComvertoObj(reader));
                }



            }

            return list;

        }
        public static List<E_Reserva> BuscarReservasByID(int ID)
        {
            List<E_Reserva> list = new List<E_Reserva>();

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("sp_BuscarReservaID", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    list.Add(ComvertoObj(reader));
                }
                   

            }

            return list;

        }

        private static E_Reserva ComvertoObj(IDataReader reader)
        {

            E_Reserva reserva = new E_Reserva();

            reserva.idReserva = reader.GetInt32(0);
            reserva.nombre = reader.GetString(1);
            reserva.apellido = reader.GetString(2);
            reserva.documento = reader.GetString(3);
            reserva.email = reader.GetString(4);
            reserva.subC =Convert.ToDouble(reader.GetDecimal(5));
            reserva.impuestoC = Convert.ToDouble(reader.GetDecimal(6));
            reserva.totalC = Convert.ToDouble(reader.GetDecimal(7));
            reserva.fecha = reader.GetDateTime(8);
            return reserva;
        }

        public static DataTable GetAllDetalle()
        {
            DataTable table;
            using (SqlConnection conx=new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllDetalleReserva", conx);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               table = new DataTable();
                adapter.Fill(table);

               


            }

            return table;
        }

        public static DataTable BuscarByIDDetalle(int id)
        {

            DataTable table;
            using (SqlConnection conx = new SqlConnection(cadenaConexion))
            {
                conx.Open();
                SqlCommand cmd = new SqlCommand("sp_BuscarDetalleReserva", conx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@valor", id);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);




            }

            return table;




        }

        private static void UpdateStatusRoom(int id)
        {
            using (SqlConnection conex=new SqlConnection(cadenaConexion))
            {
                conex.Open();
                SqlCommand cmdR = new SqlCommand("sp_UpdateStatus", conex);
                cmdR.CommandType = CommandType.StoredProcedure;
                cmdR.Parameters.AddWithValue("@ID", id);
                cmdR.ExecuteNonQuery();
            }
            
        }

        public static int GetTotalReselvas()
        {
            int cantidad =0;

            using (SqlConnection conex = new SqlConnection(cadenaConexion))
            {
                conex.Open();
                string consulta = "select COUNT(*) from Reserva ";
                SqlCommand cmd = new SqlCommand(consulta, conex);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = reader.GetInt32(0);
                }
            }


            return cantidad;

        }


    }
}
