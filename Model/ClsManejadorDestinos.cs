using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaAccesoDatos
{
    public class ClsManejadorDestinos
    {
        
        public SqlConnection abrirConexion()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                string ConexionSQL = "server = localhost; database = Aereolinea; integrated security = true";
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
        public SqlConnection cerrarConexion(SqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se ha cerrado la conexion con la base de datos.");

            return conexion;

        }


        public String insertarDestino(List<ClsParametrosDestino> lst) {
            String msj = "";
            try
            {
                SqlConnection conexion = abrirConexion();

                string query = "INSERT INTO destino " +
                    "(idDestino, lugarDestino, Aeropuerto, Ciudad, foto)" +
                    " VALUES (@idDestino, @lugarDestino, @Aeropuerto, @Ciudad, @foto)";
                SqlCommand command = new SqlCommand(query, conexion);
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@idDestino", lst[0].NumeroDestino);
                command.Parameters.AddWithValue("@lugarDestino", lst[0].Pais);
                command.Parameters.AddWithValue("@Aeropuerto", lst[0].NombreAeropuerto);
                command.Parameters.AddWithValue("@Ciudad", lst[0].Ciudad);
                command.Parameters.AddWithValue("@foto", lst[0].Foto);
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
                SqlConnection conexion = abrirConexion();
                string cadena = "DELETE FROM destino WHERE idDestino = " + NDestino;
                SqlCommand command = new SqlCommand(cadena, conexion);
                int resultado = Convert.ToInt32(command.ExecuteScalar());
                msj = "Destino eliminado con éxito, " + resultado;
                cerrarConexion(conexion);

            }
            catch (SqlException ex)
            {
                msj = "Error al eliminar el destino\nError: "+ ex;
                
            }
            return msj;
        }

        public Tuple<List<Object>, SqlDataAdapter> listar_Destino()
        {
            List<Object> lstDestino = new List<Object>();
            
            SqlConnection conexion = abrirConexion();
            string cadena = "select idDestino, lugarDestino, Aeropuerto, Ciudad, foto from destino";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter RegistroAdapter = new SqlDataAdapter(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    idDestino = int.Parse(registros["idDestino"].ToString()),
                    lugarDestino = registros["lugarDestino"].ToString(),
                    Aeropuerto = registros["Aeropuerto"].ToString(),
                    Ciudad = registros["Ciudad"].ToString(),
                    Foto = registros["foto"].ToString()
                };
                lstDestino.Add(tmp);
            }
            cerrarConexion(conexion);
            return Tuple.Create(lstDestino, RegistroAdapter); ;
        }
        public List<Object> listar_paises() 
        {
            List<Object> lstPaises = new List<Object>();

            SqlConnection conexion = abrirConexion();
            string cadena = "select distinct lugarDestino from destino";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter RegistroAdapter = new SqlDataAdapter(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    
                    lugarDestino = registros["lugarDestino"].ToString()
                };
                lstPaises.Add(tmp);
            }
            cerrarConexion(conexion);
            return lstPaises;
        }
        public string ObtenerIDMax()
        {
            String NMax="";

            SqlConnection conexion = abrirConexion();
            string cadena = "select max(idDestino)+1 as numero from destino;";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                NMax = registros["numero"].ToString();
            }
            if (NMax.Equals("")) 
            {
                NMax = "0";
            }
            cerrarConexion(conexion);
            return NMax;
        }

        public String ModificarDestino(int idDestino, string lugarDestino,string Aeropuerto, string Ciudad,string Foto)
        {
            String Msj = "";
            try
            {
                SqlConnection conexion = abrirConexion();
                String actualizar = "update destino set lugarDestino = @lugarDestino, Aeropuerto= @Aeropuerto, Ciudad= @Ciudad, foto = @foto where idDestino = @idDestino";
                SqlCommand comando = new SqlCommand(actualizar, conexion);
                comando.Parameters.AddWithValue("@idDestino", idDestino);
                comando.Parameters.AddWithValue("@lugarDestino", lugarDestino);
                comando.Parameters.AddWithValue("@Aeropuerto", Aeropuerto);
                comando.Parameters.AddWithValue("@Ciudad", Ciudad);
                comando.Parameters.AddWithValue("@foto", Foto);
                int Resultado = comando.ExecuteNonQuery();
                Msj = "Se ha actualizado correctamente los datos del destino, " + Resultado;
                cerrarConexion(conexion);
            }
            catch (MySqlException e) { Msj = "No se ha podido actualizar los datos del destino" + e; }
            return Msj;
        }
    }
}