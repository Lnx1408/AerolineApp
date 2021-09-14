using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsManejadorUsuario
    {
        List<ClsDatosUsuario> datosUsuario = new List<ClsDatosUsuario>();


        public String InsertUsuario(List<ClsParametrosUsuario> lst, String nombre, String usuario)
        {
            String msj = "";
            try
            {
                if (lst != null)
                {
                    if (!validarUser(nombre, usuario))
                    {
                        datosUsuario.Add(new ClsDatosUsuario(lst[0].Nombre, lst[0].Usuario, lst[0].Password));
                        msj = "Registrado con éxito";
                    }
                    else
                    {
                        msj = "Error, el usuario ingresado ya existe";

                    }
                }

            }
            catch (Exception ex)
            { msj = "Error al ingresar datos"; throw ex; }

            return msj;
        }

        public bool validarUser(String name, String user)
        {
            bool existe = false;
            foreach (var usuario in datosUsuario)
            {
                if (name == usuario.Nombre.ToString() && user == usuario.Usuario)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

    }
}
