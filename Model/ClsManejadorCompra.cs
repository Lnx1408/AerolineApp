using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class ClsManejador
    {
        //Tabla alumnos en memoria - reemplazo de la BD
        List<ClsDatosVuelo> datosVuelo = new List<ClsDatosVuelo>();


        //Abrir conexion a BD
        private SqlConnection abrirConexionSqlServer()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                //String stringConexion = "server = 0.0.0.0\\sqlexpress; database = grupo2; integrated security = true";
                String stringConexion = "server = localhost; database = Aereolinea1; integrated security = true";
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
        public String insertar_vuelo(List<ClsParametros> lst, String cd)
        {

            String msj = "";
            try
            {
                SqlConnection conexionOpen = abrirConexionSqlServer();

                string query = "INSERT INTO compra " +
                    "(Cedula,Nombres,Apellidos,NumeroPasajeros,Clase,Pais,Origen,Destino,FechaIda,FechaRegreso,ValorTotal)" +
                    "VALUES (@cedula,@nombres,@apellidos,@numPas,@clase,@pais,@origen,@destino,@fechaIda,@fechaRegreso,@precio)";
                //@cedula,@nombres,@apellidos,@numPas,@clase,@pais,@origen,@destino,@fechaIda,@fechaRegreso,@prec
                SqlCommand command = new SqlCommand(query, conexionOpen);
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                command.Parameters.AddWithValue("@nombres", lst[0].Nombres);
                command.Parameters.AddWithValue("@apellidos", lst[0].Apellidos);
                command.Parameters.AddWithValue("@numPas", lst[0].NumPas);
                command.Parameters.AddWithValue("@clase", lst[0].Clase);
                command.Parameters.AddWithValue("@pais", lst[0].Pais);
                command.Parameters.AddWithValue("@origen", lst[0].Origen);
                command.Parameters.AddWithValue("@destino", lst[0].Destino);
                command.Parameters.AddWithValue("@fechaIda", lst[0].FechaIda);
                command.Parameters.AddWithValue("@fechaRegreso", lst[0].FechaRegreso);
                command.Parameters.AddWithValue("@precio", lst[0].Precio);


                //command.ExecuteNonQuery();
                int t = Convert.ToInt32(command.ExecuteScalar());
                msj = "Registrado con éxito, " + t;
                cerrarConexionSqlServer(conexionOpen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos. \nMotivos:\n1. Conexión no establecida.\n2.Cedula duplicada.", "Error");
                msj = "Error, " + ex;
            }
            return msj;
        }
        public String EliminarXCedula(String Cedula)
        {
            String msj = "";
            try
            {
                SqlConnection conexion = abrirConexionSqlServer();
                string cadena = "DELETE FROM compra WHERE Cedula = " + Cedula;
                SqlCommand command = new SqlCommand(cadena, conexion);
                int resultado = Convert.ToInt32(command.ExecuteScalar());
                msj = "Alumno eliminado con éxito, " + resultado;
                cerrarConexionSqlServer(conexion);
            }
            catch (Exception ex)
            {
                msj = "Alumno no eliminado";
                throw ex;
            }
            return msj;
        }
        public bool existeCi(String cedula)
        {
            bool existe = false;
            foreach (var alumno in datosVuelo)
            {
                if (cedula == alumno.Cedula.ToString())
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }
        public Tuple<List<Object>,SqlDataAdapter>listar_alumno()
        {
            List<Object> lstAlumnos = new List<Object>();

            SqlConnection conexion = abrirConexionSqlServer();
            string cadena = "select Cedula,Nombres,Apellidos,NumeroPasajeros,Clase,Pais,Origen,Destino,FechaIda,FechaRegreso,ValorTotal from compra";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter RegistroAdapter = new SqlDataAdapter(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    cedula = registros["Cedula"].ToString(),
                    nombres = registros["Nombres"].ToString(),
                    apellidos = registros["Apellidos"].ToString(),
                    numPas = Int16.Parse(registros["NumeroPasajeros"].ToString()),
                    clase = registros["Clase"].ToString(),
                    pais = registros["Pais"].ToString(),
                    origen = registros["Origen"].ToString(),
                    destino = registros["Destino"].ToString(),
                    fechaIda = registros["FechaIda"].ToString(),
                    fechaRegreso = registros["FechaRegreso"].ToString(),
                    precio = float.Parse(registros["ValorTotal"].ToString())


                };
                lstAlumnos.Add(tmp);
            }
            cerrarConexionSqlServer(conexion);
            return Tuple.Create(lstAlumnos,RegistroAdapter);
        }
        // ---------------------- Reciente --------------------
        //public String EliminarXCedula(List<ClsParametros> lst, String Cedula)
        //{
        //    String msj = "";
        //    try
        //    {
        //        if (lst != null)
        //        {
        //            foreach (var alumno in datosVuelo)
        //            {
        //                if (alumno.Cedula.Equals(Cedula))
        //                {
        //                    datosVuelo.Remove(alumno);
        //                    msj = "Eliminado con éxito";
        //                    break;
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        msj = "Alumno no eliminado";
        //        throw ex;
        //    }
        //    return msj;
        //}
        public List<Object> listar_alumno_Cedula(String Cedula)
        {
            List<Object> lstAlumnos = new List<Object>();

            SqlConnection conexion = abrirConexionSqlServer();
            string cadena = "select Cedula,Nombres,Apellidos,Numero_Pasajeros,Clase,Pais,Origen,Destino,Fecha_Ida,Fecha_Regreso,Valor_Total from compra where Cedula =" + Cedula;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    cedula = registros["Cedula"].ToString().Trim(),
                    nombres = registros["Nombres"].ToString().Trim(),
                    apellidos = registros["Apellidos"].ToString().Trim(),
                    edad = Int16.Parse(registros["Numero_Pasajeros"].ToString().Trim()),
                    sexo = registros["Clase"].ToString().Trim(),
                    nacionalidad = registros["Pais"].ToString().Trim(),
                    provincia = registros["Origen"].ToString().Trim(),
                    cantones = registros["Destino"].ToString().Trim(),
                    fechaIda = registros["Fecha_Ida"].ToString().Trim(),
                    fechaRegreso = registros["Fecha_Regreso"].ToString().Trim(),
                    precio = float.Parse(registros["Valor_Total"].ToString().Trim())
                };
                lstAlumnos.Add(tmp);
            }
            cerrarConexionSqlServer(conexion);
            return lstAlumnos;
        }
        //public List<Object> listar_vuelo()
        //{
        //    List<Object> lstAlumnos = new List<Object>();

        //    //Se crea un tipo de datos Anonymus para obtener los datos del estudiantes y
        //    //pasarlo como objetos a la Capa Lógica del negocio
        //    foreach (var alumno in datosVuelo)
        //    {
        //        var tmp = new
        //        {
        //            cedula = alumno.Cedula,
        //            nombres = alumno.Nombres,
        //            apellidos = alumno.Apellidos,
        //            numPas = alumno.NumPas,
        //            clase = alumno.Clase,
        //            nacionalidad = alumno.Pais,
        //            provincia = alumno.Origen,
        //            cantones = alumno.Destino,
        //            fechaIda = alumno.FechaIda,
        //            fechaRegreso = alumno.FechaRegreso,
        //            precio = alumno.Precio,
        //        };

        //        lstAlumnos.Add(tmp);
        //    }
        //    return lstAlumnos;
        //}

    }
}
