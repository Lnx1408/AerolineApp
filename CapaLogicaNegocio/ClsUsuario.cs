using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;


namespace CapaLogicaNegocio
{
    public class ClsUsuario
    {
        private String nombre;
        private String usuario;
        private String password;

        public ClsUsuario() { }

        public ClsUsuario(string nombre, string usuario, string password)
        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.password = password;
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        ClsManejadorUsuario manejadorUsuarios = new ClsManejadorUsuario();

        public String registrarUsuario(String name, String user)
        {
            string msj = "";

            List<ClsParametrosUsuario> lst = new List<ClsParametrosUsuario>();

            try
            {

                lst.Add(new ClsParametrosUsuario(Nombre, Usuario, Password));
                msj = manejadorUsuarios.InsertUsuario(lst);
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                throw ex;
            }

            return msj;
        }

    }
}

