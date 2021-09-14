using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsDatosUsuario
    {
        private String nombre;
        private String usuario;
        private String password;

        public ClsDatosUsuario(string nombre, string usuario, string password)
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

    }
}
