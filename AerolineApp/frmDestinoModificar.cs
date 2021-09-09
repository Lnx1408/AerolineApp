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
    public partial class frmDestinoModificar : Form
    {
        string idDestino;
        ClsDestino destino;
        string foto="";
        public frmDestinoModificar(String idDestino, ClsDestino destino)
        {
            InitializeComponent();
            txtNDestino.Enabled = false;
            txtNDestino.Text = idDestino;
            this.destino = destino;
            this.idDestino = idDestino;
            obtenerDatos();
            bloquearComponentes();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            desbloquearComponentes();
        }
        private void bloquearComponentes() 
        {
            btModificar.Enabled = true;
            btnSeleccionarFoto.Enabled = false;
            btmConfirmar.Enabled = false;
            txtADestino.ReadOnly = true;
            txtCiudad.ReadOnly = true;
            txtPais.ReadOnly = true;
        }
        private void desbloquearComponentes() 
        {
            btModificar.Enabled = false;
            btnSeleccionarFoto.Enabled = true;
            btmConfirmar.Enabled = true;
            txtADestino.ReadOnly = false;
            txtCiudad.ReadOnly = false;
            txtPais.ReadOnly = false;
        }

        private void btmConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(destino.modificar(int.Parse(txtNDestino.Text),txtPais.Text,txtADestino.Text,txtCiudad.Text,this.foto));
            bloquearComponentes();
        }
        private void obtenerDatos() 
        {
            List<Object> lst_destinos = destino.MostrarDestino().Item1;
            foreach (var destino in lst_destinos)
            {
                System.Type type = destino.GetType();
                int NumeroDestino = (int)type.GetProperty("idDestino").GetValue(destino);
                if (int.Parse(this.idDestino) == NumeroDestino) {
                    txtPais.Text = (String)type.GetProperty("lugarDestino").GetValue(destino);
                    txtCiudad.Text = (String)type.GetProperty("Ciudad").GetValue(destino);
                    txtADestino.Text = (String)type.GetProperty("Aeropuerto").GetValue(destino);
                    this.foto = (String)type.GetProperty("Foto").GetValue(destino);
                    pboxFotoDestino.Image = Image.FromFile(foto);
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmDestinoConsultar destinoConsultar = new frmDestinoConsultar(destino);
            destinoConsultar.Show();
            this.Hide();
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
                MessageBox.Show("El archivo no es válido: " + ex);
            }
        }
    }
}
