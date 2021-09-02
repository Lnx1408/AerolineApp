using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaAccesoDatos
{
    public class ClsManejadorDestinos
    {
        
        public MySqlConnection abrirConexion()
        {
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                string ConexionSQL = "server = localhost; port = 3306; user = root; pwd = 12345; database = proyectoaerolinea;";
                conexion.ConnectionString = ConexionSQL;
                //SqlConnection conexion = new SqlConnection(ConexionSQL);
                conexion.Open();
                Console.WriteLine("Se ha abierto la conexión con la base de datos.");

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Ha ocurrido un error al inicar la base de datos: " + e);
            }
            return conexion;
        }
        public MySqlConnection cerrarConexion(MySqlConnection conexion)
        {
            conexion.Close();
            MessageBox.Show("Se ha cerrado la conexion con la base de datos.");

            return conexion;

        }


        public String insertarDestino(List<ClsParametrosDestino> lst) {
            String msj = "";
            try
            {
                MySqlConnection conexion = abrirConexion();

                string query = "INSERT INTO destino " +
                    "(idDestino, lugarDestino, Aeropuerto, Ciudad, fechaDestino)" +
                    " VALUES (@idDestino, @lugarDestino, @Aeropuerto, @Ciudad, str_to_date(@fechaDestino, '%d/%m/%Y %H:%i'))";
                MySqlCommand command = new MySqlCommand(query, conexion);
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@idDestino", lst[0].NumeroDestino);
                command.Parameters.AddWithValue("@lugarDestino", lst[0].Pais);
                command.Parameters.AddWithValue("@Aeropuerto", lst[0].NombreAeropuerto);
                command.Parameters.AddWithValue("@Ciudad", lst[0].Ciudad);
                command.Parameters.AddWithValue("@fechaDestino", lst[0].Fecha);
                //command.ExecuteNonQuery();
                int t = command.ExecuteNonQuery();
                msj = "Registrado con éxito, " + t;
                cerrarConexion(conexion);
            }
            catch (Exception ex)
            {
                msj = "No se pudo insertar los datos. \nMotivos:\n1. Conexión no establecida.\n2.PK duplicada." + "\nError: " + ex;
            }
            return msj;
        }

        public String EliminarDestino(int NDestino)
        {
            String msj = "";
            try
            {
                MySqlConnection conexion = abrirConexion();
                string cadena = "DELETE FROM destino WHERE idDestino = " + NDestino;
                MySqlCommand command = new MySqlCommand(cadena, conexion);
                int resultado = Convert.ToInt32(command.ExecuteScalar());
                msj = "Destino eliminado con éxito, " + resultado;
                cerrarConexion(conexion);

            }
            catch (MySqlException ex)
            {
                msj = "Error al eliminar el destino\nError: "+ ex;
                
            }
            return msj;
        }

        public List<Object> listar_Destino()
        {
            List<Object> lstDestino = new List<Object>();
            
            MySqlConnection conexion = abrirConexion();
            string cadena = "select idDestino, lugarDestino, Aeropuerto, Ciudad, fechaDestino from destino";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            MySqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    idDestino = int.Parse(registros["idDestino"].ToString()),
                    lugarDestino = registros["lugarDestino"].ToString(),
                    Aeropuerto = registros["Aeropuerto"].ToString(),
                    Ciudad = registros["Ciudad"].ToString(),
                    fechaDestino = registros["fechaDestino"].ToString()
                };
                lstDestino.Add(tmp);
            }
            cerrarConexion(conexion);
            return lstDestino;
        }
        public String ModificarDestino(int idDestino, string lugarDestino,string Aeropuerto, string Ciudad,string fechaDestino)
        {
            String Msj = "";
            try
            {
                MySqlConnection conexion = abrirConexion();
                String actualizar = "update destino set lugarDestino=@ lugarDestino, Aeropuerto=@ Aeropuerto, Ciudad=@ Ciudad, fechaDestino=@ fechaDestino where idDestino = " + idDestino;
                MySqlCommand comando = new MySqlCommand(actualizar, conexion);
                //comando.Parameters.AddWithValue("@idDestino", idDestino);
                comando.Parameters.AddWithValue("@lugarDestino", lugarDestino);
                comando.Parameters.AddWithValue("@Aeropuerto", Aeropuerto);
                comando.Parameters.AddWithValue("@Ciudad", Ciudad);
                comando.Parameters.AddWithValue("@fechaDestino", fechaDestino);
                int Resultado = comando.ExecuteNonQuery();
                Msj = "Se ha actualizado correctamente los datos del destino, " + Resultado;
                cerrarConexion(conexion);
            }
            catch (MySqlException e) { Msj = "No se ha podido actualizar los datos del destino" + e; }
            return Msj;
        }
    }
}