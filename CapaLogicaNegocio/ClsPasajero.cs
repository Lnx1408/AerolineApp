using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data.SqlClient;

namespace CapaLogicaNegocio
{
    public class ClsPasajero : ClsVuelo
    {


        //Nuevos Atributos
        private String clase;
        private String pais;
        private String origen;
        private String destino;
        private String fechaIda;
        private String fechaRegreso;
        //------------------------

        public ClsPasajero() { }
        public ClsPasajero(String ced, String nom, String apel, Int16 numPas, String clase, String pais, String origen, String destino, String fechaIda, String fechaRegreso, float precio) : base(ced, nom, apel, numPas, precio)
        {

            this.clase = clase;
            this.pais = pais;
            this.origen = origen;
            this.destino = destino;
            this.fechaIda = fechaIda;
            this.fechaRegreso = fechaRegreso;
        }

        //Setter and Getter field
        public String FechaIda
        {
            get { return fechaIda; }
            set { fechaIda = value; }
        }
        public String FechaRegreso
        {
            get { return fechaRegreso; }
            set { fechaRegreso = value; }
        }


        public String Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public String Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar alumnos        
        public override String registrar(String cd)
        {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new ClsParametros(Cedula, Nombres, Apellidos, NumPas, Clase, Pais, Origen, Destino, FechaIda, FechaRegreso, Precio));
                //M.insertar_alumno(lst,cd);

                msj = M.insertar_vuelo(lst, cd);
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";

                throw ex;
            }

            return msj;
        }

        //Eliminar Alumnos

        public override string eliminar(string cd)
        {
            string msj = "";

            
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new ClsParametros(Cedula, Nombres, Apellidos, numPas, Clase, Pais, Origen, Destino, FechaIda, fechaRegreso, Precio));
                

                msj = M.EliminarXCedula(cd);
            }
            catch (Exception ex)
            {
                msj = "Error a eliminar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }



        public Tuple<List<Object>,SqlDataAdapter>listar()
        {
            return M.listar_vuelo();
        }

        public List<Object> Listar_Cedula(String Cedula)
        {
            return M.listar_Com(Cedula);
        }

        //Lista alumnos
        //public override List<Object> listar()
        //{
        //    return M.listar_vuelo();
        //}
    }
}

