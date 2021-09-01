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
        List<ClsDatosDestino> datosDestinos = new List<ClsDatosDestino>();
        public MySqlConnection abrirConexionMySQL()
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
        public MySqlConnection cerrarConexionMySQL(MySqlConnection conexion)
        {
            conexion.Close();
            MessageBox.Show("Se ha cerrado la conexion con la base de datos.");

            return conexion;

        }


        public String insertarDestino(List<ClsParametrosDestino> lst, String pais, String nombreAeropuerto) {
            String msj = "";
            try
            {
                if (lst != null)
                {
                    if (!existeDestino(pais, nombreAeropuerto) )
                    {
                        datosDestinos.Add(new ClsDatosDestino(lst[0].NumeroDestino, lst[0].Pais, lst[0].Ciudad, lst[0].NombreAeropuerto, lst[0].DetalleDireccion));
                        msj = "Registrado con éxito";
                    }
                    else
                    {
                        msj = "Error, el destino ingresado ya existe";

                    }
                }

            }
            catch (Exception ex)
            { msj = "Error al ingresar datos"; throw ex; }

            return msj;
        }

        public bool existeDestino(String pais, String nombreAeropuerto)
        {
            bool existe = false;
            foreach (var destino in datosDestinos)
            {
                if (pais == destino.Pais.ToString() && nombreAeropuerto == destino.NombreAeropuerto)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public String EliminarDestino(List<ClsParametrosDestino> lst, int NDestino)
        {
            String msj = "";
            try
            {
                if (lst != null)
                {
                    foreach (var destino in datosDestinos)
                    {
                        if (destino.NumeroDestino.Equals(NDestino))
                        {
                            datosDestinos.Remove(destino);
                            msj = "Eliminado con éxito";
                            break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                msj = "Error al eliminar el destino";
                throw ex;
            }
            return msj;
        }

        public List<Object> listar_Pais()
        {
            List<Object> lstDestino = new List<Object>();
            foreach (var destino in datosDestinos)
            {
                var tmp = new
                {
                    numeroDestino = destino.NumeroDestino,
                    pais = destino.Pais,
                    ciudad = destino.Ciudad,
                    nombreAeropuerto = destino.NombreAeropuerto,
                    detalleDireccion = destino.DetalleDireccion                    
                };

                lstDestino.Add(tmp);
            }
            return lstDestino;
        }
    }
}
