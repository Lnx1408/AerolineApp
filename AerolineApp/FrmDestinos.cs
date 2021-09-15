using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace AerolineApp
{
    public partial class FrmDestinos : Form
    {
        ClsDestino destino = new ClsDestino();
        String foto ="";
        public FrmDestinos()
        {
            InitializeComponent();
            txtPais.Focus();
            txtNDestino.Text = destino.obtenerVmax();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu fm = new frmMenu();
            fm.Show();
        }

        public void LimpiarCeldas() {
            txtADestino.Text = "";
            txtCiudad.Text = "";
            txtPais.Text = "";
            pboxFotoDestino.Image = null;
            
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            destino.NumeroDestino = int.Parse(txtNDestino.Text);

            String msj = "";
            
            if (txtPais.Text.Equals(""))
            {
                msj = "Todos los campos deben ser ingresados";
                MessageBox.Show(msj);
                txtPais.Focus();
            }
            else
            {
                
                try
                {
                    destino.NumeroDestino = int.Parse(txtNDestino.Text);
                    destino.Pais = txtPais.Text;
                    destino.Ciudad = txtCiudad.Text;
                    destino.NombreAeropuerto = txtADestino.Text;
                    if (this.foto.Equals(""))
                    {
                        destino.Foto = Path.Combine(Environment.CurrentDirectory, "..\\..\\img\\NoImagen.png");
                    }
                    else
                    {
                        destino.Foto = this.foto;
                    }
                    
                    msj = destino.registrarDestino();
                    if (msj.Equals("Registrado con éxito, 1")) {
                        int Numero = int.Parse(txtNDestino.Text) + 1;
                        txtNDestino.Text = Numero.ToString();
                    }

                    MessageBox.Show(msj);

                    LimpiarCeldas();
                    txtPais.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void btConsultar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(monthCalendarFechaLlegada.SelectionEnd.ToShortDateString());
            
            frmDestinoConsultar destinoConsultar = new frmDestinoConsultar(destino);
            this.Hide();
            destinoConsultar.Show();
        }

        

        /*
         * Validación de Números
         */ 
        public void validarNumeros(KeyPressEventArgs k) {
            if (Char.IsDigit(k.KeyChar) || Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else k.Handled = true;

        }
        /*
         * Metodo para cambiar el color de un boton pasado por parametro
         * 
        public void CambiarFocus(Button b) {
            if (b.Focused)
            {
                b.BackColor = Color.LightBlue;
            }
            else {
                b.BackColor = Color.Transparent;
            }  
        }


        
             destino.Fecha = TimePickerSalida.Value.ToShortDateString() +" "+TimePickerSalida.Value.ToShortTimeString();
             destino.Fecha = monthCalendarFechaLlegada.SelectionEnd.ToShortDateString();
             destino.DetalleDireccion = txtDetalleDireccion.Text;
        */
        public void SetFocusB(Button b)
        {
            b.BackColor = Color.LightBlue;
        }
        public void LostFocusB(Button b) {
            b.BackColor = Color.Transparent;
        }
        private void FrmDestinos_Shown(object sender, EventArgs e)
        {
            txtPais.Focus();
        }

        

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = openFileDialog1.FileName;

                    this.foto = imagen;
                    pboxFotoDestino.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo no es válido: " +ex);
            }
        }
    }
}
