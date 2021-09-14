using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AerolineApp
{
    public partial class frmFlotaAviones : Form
    {
        int contador = 1;
        public frmFlotaAviones()
        {
            InitializeComponent();

            //olakease
        }



        private SqlConnection abrirConexionSqlServer()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
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


        public List<Object> listar()

        {
               
            List<Object> lstDatos = new List<Object>();
            try
            {
                SqlConnection conexion = abrirConexionSqlServer();
                string cadena = "select modelo, velocidad, altura, capacidad from flota_info where id_avion = " + contador;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();
              
                while (registros.Read())
                {
                    
                    string modelo = registros["modelo"].ToString().Trim();
                    string velocidad = registros["velocidad"].ToString().Trim();
                    string altura = registros["altura"].ToString().Trim();
                    string capacidad = registros["capacidad"].ToString().Trim();

                        lblModelo.Text = modelo + "";
                        txtVelocidad.Text = velocidad + "";
                        txtAltura.Text = altura + "";
                        txtCapacidad.Text = capacidad + "";
                 
                }
                if (contador == 1)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota01;
                }
                else if (contador == 2)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota02;
                }
                else if (contador == 3)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota03;
                }
                else if (contador == 4)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota04;
                }
                else if (contador == 5)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota05;
                }
                else if (contador == 6)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota06;
                }
                 else if (contador == 7)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota07;
                }
                
                else if (contador == 8)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota08;

                    contador = 0;

                }
                contador++;
                cerrarConexionSqlServer(conexion);
            }
            catch (Exception e)
            {
                MessageBox.Show("Sin registros"+e);
            }
            return lstDatos;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            listarAnterior();
        }

        public List<Object> listarAnterior()

        {

            List<Object> lstDatos = new List<Object>();
            try
            {
                SqlConnection conexion = abrirConexionSqlServer();
                string cadena = "select modelo, velocidad, altura, capacidad from flota_info where id_avion = " + contador;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    string modelo = registros["modelo"].ToString().Trim();
                    string velocidad = registros["velocidad"].ToString().Trim();
                    string altura = registros["altura"].ToString().Trim();
                    string capacidad = registros["capacidad"].ToString().Trim();

                    lblModelo.Text = modelo + "";
                    txtVelocidad.Text = velocidad + "";
                    txtAltura.Text = altura + "";
                    txtCapacidad.Text = capacidad + "";

                }
                if (contador == 1)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota01;
                    contador = 9;
                }
                else if (contador == 2)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota02;
                }
                else if (contador == 3)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota03;
                }
                else if (contador == 4)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota04;
                }
                else if (contador == 5)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota05;
                }
                else if (contador == 6)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota06;
                }
                else if (contador == 7)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota07;
                }

                else if (contador == 8)
                {
                    this.pctAvion.Image = global::AerolineApp.Properties.Resources.Flota08;

                   

                }
                contador--;
                cerrarConexionSqlServer(conexion);
            }
            catch (Exception e)
            {
                MessageBox.Show("Sin registros" + e);
            }
            return lstDatos;
        }
    }
}
