using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsParametrosDestino
    {
        private int numeroDestino;
        private String pais;
        private String ciudad;
        private String nombreAeropuerto;
        private String fecha;
        


        public ClsParametrosDestino(int numeroDestino, string pais, string ciudad, string nombreAeropuerto, string fecha)
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

    }

}
