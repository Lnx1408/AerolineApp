using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsDatosVuelo
    {
        //Atributos 
        private String cedula;
        private String nombres;
        private String apellidos;
        private Int16 numPas;
        private float precio;
        //Nuevos Atributos
        private String clase;
        private String pais;
        private String origen;
        private String destino;
        private String fechaIda;
        private String fechaRegreso;
        //------------------------

        public ClsDatosVuelo(String cedula, String nombres, String apellidos, Int16 numPas, String clase, String pais, String origen, String destino, String fechaIda, String fechaRegreso, float precio)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numPas = numPas;
            this.clase = clase;
            this.pais = pais;
            this.origen = origen;
            this.destino = destino;
            this.fechaIda = fechaIda;
            this.fechaRegreso = fechaRegreso;
            this.precio = precio;

        }


        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public Int16 NumPas
        {
            get { return numPas; }
            set { numPas = value; }
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
        public float Precio
        {
            get { return precio; }
            set { Precio = value; }
        }
    }
}
