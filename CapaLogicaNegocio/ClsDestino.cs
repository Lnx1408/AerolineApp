using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private String foto;

        public ClsDestino() { }

        public ClsDestino(int numeroDestino, string pais, string ciudad, string nombreAeropuerto, string foto)
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

        ClsManejadorDestinos manejadorDestinos = new ClsManejadorDestinos();

        public String registrarDestino()
        {
            string msj = "";

            List<ClsParametrosDestino> lst = new List<ClsParametrosDestino>();

            try
            {
                
                lst.Add(new ClsParametrosDestino(NumeroDestino, Pais, Ciudad, NombreAeropuerto, Foto));
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
        public string modificar(int idDestino, string lugarDestino, string Aeropuerto, string Ciudad, string Foto) 
        {
            return manejadorDestinos.ModificarDestino(idDestino, lugarDestino, Aeropuerto, Ciudad, Foto);
        }
        public Tuple<List<Object>, SqlDataAdapter> MostrarDestino()
        {
            return manejadorDestinos.listar_Destino();
        }
        public string obtenerVmax() 
        {
            return manejadorDestinos.ObtenerIDMax(); 
        }

    }
}
