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
        private String foto;
        


        public ClsParametrosDestino(int numeroDestino, string pais, string ciudad, string nombreAeropuerto, string foto)
        {
            this.numeroDestino = numeroDestino;
            this.pais = pais;
            this.ciudad = ciudad;
            this.nombreAeropuerto = nombreAeropuerto;
            this.foto = foto;
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

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

    }

}
