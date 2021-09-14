using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class ClsManejadorUsuario
    {
        List<ClsDatosUsuario> datosUsuario = new List<ClsDatosUsuario>();
        
        //Abrir conexion a BD
        private SqlConnection abrirConexionSqlServer()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                //String stringConexion = "server = 0.0.0.0\\sqlexpress; database = grupo2; integrated security = true";
                String stringConexion = "server = localhost; database = Aereolinea; integrated security = true";
                conexion.ConnectionString = stringConexion;
                conexion.Open();
                Console.WriteLine("Se ha abierto la conexión con la base de datos de Sql Server");

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se ha posido establecer conexión con la base de datos, error: " + e);
            }
            return conexion;
        }

        //Cerrar conexion a BD
        private SqlConnection cerrarConexionSqlServer(SqlConnection conexion)
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Se ha cerrado la conexión con la base de datos Sql Server");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se ha podido cerrar la conexión con la base de datos Sql Server, error: " + e);
            }
            return conexion;
        }

        //Método para insertar información
        public String InsertUsuario(List<ClsParametrosUsuario> lst)
        {

            String msj = "";
            try
            {
                SqlConnection conexionOpen = abrirConexionSqlServer();

                string query = "INSERT INTO usuarios " +
                    "(Usuario,Nombre,contrasenia)" +
                    "VALUES (@Usuario,@Nombre,@contrasenia)";
                SqlCommand command = new SqlCommand(query, conexionOpen);
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@Usuario", lst[0].Usuario);
                command.Parameters.AddWithValue("@Nombre", lst[0].Nombre);
                command.Parameters.AddWithValue("@contrasenia", lst[0].Password);


                //command.ExecuteNonQuery();
                int t = Convert.ToInt32(command.ExecuteScalar());
                msj = "Registrado con éxito, ";
                cerrarConexionSqlServer(conexionOpen);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Usuario duplicado.", "Error");
               msj = "Usuario duplicado, Error";
            }
            return msj;
        }

    }
}
