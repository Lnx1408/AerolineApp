using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
namespace AerolineApp
{
    public partial class frmRegistrar : Form
    {
        ClsUsuario usuario = new ClsUsuario();
        public frmRegistrar()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public void LimpiarCeldas()
        {
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtUsuario.Text = "";


        }

     

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            String msj = "";

            if (txtUsuario.Text.Equals("") || txtNombre.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                msj = "Todos los campos deben ser ingresados";
                MessageBox.Show(msj);
            }
            else
            {

                try
                {
                    this.usuario.Nombre = txtNombre.Text;
                    this.usuario.Usuario = txtUsuario.Text;
                    this.usuario.Password = txtPassword.Text;
                    msj = this.usuario.registrarUsuario(txtNombre.Text, txtUsuario.Text);
                    MessageBox.Show(msj);
                    LimpiarCeldas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
