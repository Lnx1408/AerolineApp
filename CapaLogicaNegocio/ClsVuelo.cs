using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ClsVuelo
    {
        protected String cedula;
        protected String nombres;
        protected String apellidos;
        protected Int16 numPas;
        protected float precio;




        private List<Object> lst_obj;

        public ClsVuelo() { }
        public ClsVuelo(String cedula, String nombres, String apellidos, Int16 numPas, float precio)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numPas = numPas;
            this.precio = precio;


        }

        //Getter and Setter fields
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

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //Métodos que pueden ser modificados por las clases hijos
        public virtual String registrar(String cd) { return ""; }
        public virtual List<Object> listar() { return lst_obj; }

        public virtual String eliminar(String cd) { return ""; }
    }
}
