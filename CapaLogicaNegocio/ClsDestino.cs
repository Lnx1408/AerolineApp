using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class ClsDestino
    {
        private int numeroDestino;
        private String pais;
        private String ciudad;
        private String nombreAeropuerto;
        private String detalleDireccion;

        public ClsDestino() { }

        public ClsDestino(int numeroDestino, string pais, string ciudad, string nombreAeropuerto, string detalleDireccion)
        {
            this.numeroDestino = numeroDestino;
            this.pais = pais;
            this.ciudad = ciudad;
            this.nombreAeropuerto = nombreAeropuerto;
            this.detalleDireccion = detalleDireccion;
        }

        public int NumeroDestino
        {
            get { return numeroDestino; }
            set { numeroDestino = value; }
        }

        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public String NombreAeropuerto
        {
            get { return nombreAeropuerto; }
            set { nombreAeropuerto = value; }
        }

        public String DetalleDireccion
        {
            get { return detalleDireccion; }
            set { detalleDireccion = value; }
        }


        ClsManejadorDestinos manejadorDestinos = new ClsManejadorDestinos();

        public String registrarDestino(String pais, String nombreAeropuerto)
        {
            string msj = "";

            List<ClsParametrosDestino> lst = new List<ClsParametrosDestino>();

            try
            {
                
                lst.Add(new ClsParametrosDestino(NumeroDestino, Pais, Ciudad, NombreAeropuerto, DetalleDireccion));
                msj = manejadorDestinos.insertarDestino(lst, pais, nombreAeropuerto);
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                throw ex;
            }

            return msj;
        }

        public string BorrarDestino(int NDestino)
        {
            string msj = "";

            List<ClsParametrosDestino> lst = new List<ClsParametrosDestino>();

            try
            {
                lst.Add(new ClsParametrosDestino(NumeroDestino, Pais, Ciudad, NombreAeropuerto, DetalleDireccion));
                msj = manejadorDestinos.EliminarDestino(lst, NDestino);
            }
            catch (Exception ex)
            {
                msj = "Error a eliminar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        public List<Object> MostrarPaises()
        {
            return manejadorDestinos.listar_Pais();
        }

    }
}
