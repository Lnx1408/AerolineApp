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
        private String fecha;

        public ClsDestino() { }

        public ClsDestino(int numeroDestino, string pais, string ciudad, string nombreAeropuerto, string fecha)
        {
            this.numeroDestino = numeroDestino;
            this.pais = pais;
            this.ciudad = ciudad;
            this.nombreAeropuerto = nombreAeropuerto;
            this.fecha = fecha;
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

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        ClsManejadorDestinos manejadorDestinos = new ClsManejadorDestinos();

        public String registrarDestino()
        {
            string msj = "";

            List<ClsParametrosDestino> lst = new List<ClsParametrosDestino>();

            try
            {
                
                lst.Add(new ClsParametrosDestino(NumeroDestino, Pais, Ciudad, NombreAeropuerto, Fecha));
                msj = manejadorDestinos.insertarDestino(lst);
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

                msj = manejadorDestinos.EliminarDestino(NDestino);
            
            return msj;
        }

        public List<Object> MostrarDestino()
        {
            return manejadorDestinos.listar_Destino();
        }

    }
}
