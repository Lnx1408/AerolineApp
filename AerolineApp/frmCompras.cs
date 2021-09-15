using CapaLogicaNegocio;
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

namespace AerolineApp
{
    public partial class frmCompras : Form
    {
        ClsPasajero Al = new ClsPasajero();
        List<object> listaAeropuerto;
        ClsDestino clsDestino = new ClsDestino();
        public frmCompras()
        {
            InitializeComponent();
            LlenarDestinosOrigen();
            llenarlstPais();
            txtcedula.Focus();
            /*
            cboxPaisOrigen.Items.Add("Ecuador");
            cboxPaisOrigen.Items.Add("Peru");
            cboxPaisOrigen.Items.Add("Panama");
            cboxPaisOrigen.Items.Add("Estados Unidos");
            cboxPaisOrigen.Items.Add("Mexico");
            cboxPaisOrigen.Items.Add("Londres");*/
        }
        private void limpiar_celdas()
        {
            txtcedula.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtNumPas.Text = "0";
            rbPrimeraClase.Checked = false;
            rbEconomica.Checked = false;
            cboxPaisOrigen.Text = "";
            lstOrigen.Items.Clear();
            //lstDestino.Items.Clear();
            txtPrecio.Text = "";
            dtFechaIda.Value = DateTime.Now;
            dtFechaRegreso.Value = DateTime.Now.AddDays(1);
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            txtNumPas.Text = "0";
            pictureBox2.SendToBack();
            pictureBox3.SendToBack();
            txtPrecio.Enabled = false;
            dtFechaRegreso.Value = DateTime.Now.AddDays(1);


        }

        private void dtFechaIda_ValueChanged(object sender, EventArgs e)
        {
            if(dtFechaIda.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Porfavor elija una fecha correcta");
                
            }
            else
            {
                String fecha_inicio = dtFechaIda.Value.Date.ToShortDateString();
            }
            
        }

        private void cmbPais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dgvOrigen.Rows.Clear();
            dgvOrigen.Refresh();
            listaAeropuerto = clsDestino.MostrarDestino().Item1;

            foreach (var Aeropuerto in listaAeropuerto)
            {
                System.Type type = Aeropuerto.GetType();

                String pais = type.GetProperty("lugarDestino").GetValue(Aeropuerto).ToString();
                if (cboxPaisOrigen.SelectedItem.ToString().Equals(pais))
                {
                    String NombreAeropuerto = (String)type.GetProperty("Aeropuerto").GetValue(Aeropuerto);
                    dgvOrigen.Rows.Add(pais, NombreAeropuerto);
                }
            }
        }

            // MessageBox.Show(cmbNacionalidad.GetItemText(cmbNacionalidad.SelectedItem));


        private void lstOrigen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lstDestino.Items.Clear();
            if (lstOrigen.GetItemText(lstOrigen.SelectedItem).Equals("Aeropuerto Internacional José Joaquín de Olmedo - GUAYAQUIL (GYE)"))
            {
                StreamReader archivoG = new StreamReader("destino.txt");
                for (int i = 0; i < 18; i++)
                {
                    lstDestino.Items.Add(archivoG.ReadLine());

                }
                //if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Afganistan"))
                //{
                //    txtPrecio.Text = 450.ToString();
                //}

            }
            else if (lstOrigen.GetItemText(lstOrigen.SelectedItem).Equals("Aeropuerto Mariscal Lamar - CUENCA (CUE)"))
            {
                StreamReader archivoG = new StreamReader("destino.txt");
                for (int i = 0; i < 18; i++)
                {
                    lstDestino.Items.Add(archivoG.ReadLine());
                }
            }
            else if (lstOrigen.GetItemText(lstOrigen.SelectedItem).Equals("Aeropuerto Internacional Mariscal Sucre - QUITO (UIO)"))
            {
                StreamReader archivoG = new StreamReader("destino.txt");
                for (int i = 0; i < 18; i++)
                {
                    lstDestino.Items.Add(archivoG.ReadLine());
                }
            }
            else if (lstOrigen.GetItemText(lstOrigen.SelectedItem).Equals("Aeropuerto Internacional de Santa Rosa - SANTA ROSA (ETR)"))
            {
                StreamReader archivoG = new StreamReader("destino.txt");
                for (int i = 0; i < 18; i++)
                {
                    lstDestino.Items.Add(archivoG.ReadLine());
                }
            }
            else if (lstOrigen.GetItemText(lstOrigen.SelectedItem).Equals("Aeropuerto de Achutupu - ACHUTUPU (ACU)"))
            {
                StreamReader archivoG = new StreamReader("destino.txt");
                for (int i = 0; i < 18; i++)
                {
                    lstDestino.Items.Add(archivoG.ReadLine());
                }
            }
            else if (lstOrigen.GetItemText(lstOrigen.SelectedItem).Equals("Aeropuerto Internacional Panamá Pacífico - ARRAIJÁN (BLB)"))
            {
                StreamReader archivoG = new StreamReader("destino.txt");
                for (int i = 0; i < 18; i++)
                {
                    lstDestino.Items.Add(archivoG.ReadLine());
                }
            }
            else if (lstOrigen.GetItemText(lstOrigen.SelectedItem).Equals("Aeropuerto Internacional de Bocas del Toro Isla Colón - BOCAS DE TORO (BOC)"))
            {
                StreamReader archivoG = new StreamReader("destino.txt");
                for (int i = 0; i < 18; i++)
                {
                    lstDestino.Items.Add(archivoG.ReadLine());
                }
            }
        }

        private void lstDestino_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int numpas;
            if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Afganistan"))
            {
                 numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (450 * numpas).ToString());

            }
            else if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Albania"))
            {
                txtPrecio.Clear();
                numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (400 * numpas).ToString());
            }
            else if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Alemania"))
            {
                txtPrecio.Clear();
                numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (600 * numpas).ToString());
            }
            else if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Paraguay"))
            {
                txtPrecio.Clear();
                numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (200 * numpas).ToString());
            }
            else if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Perú"))
            {
                txtPrecio.Clear();
                numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (180 * numpas).ToString());
            }
            else if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Polonia"))
            {
                txtPrecio.Clear();
                numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (350 * numpas).ToString());
            }
            else if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Andorra"))
            {
                txtPrecio.Clear();
                numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (275 * numpas).ToString());
            }
            else if (lstDestino.GetItemText(lstDestino.SelectedItem).Equals("Angola"))
            {
                txtPrecio.Clear();
                numpas = int.Parse(txtNumPas.Text);
                float.Parse(txtPrecio.Text = (500 * numpas).ToString());
            }
            
            
        }

        private void btConsultar_Click_1(object sender, EventArgs e)
        {
            frmConsultarCompra frmCons = new frmConsultarCompra(Al);
            frmCons.Show();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu fm = new frmMenu();
            fm.Show();
        }

        private void cmdregistrar_Click_1(object sender, EventArgs e)
        {
            String msj = "";
            String varCi = txtcedula.Text.Trim();


            if (txtcedula.Text.Equals(""))
            {
                msj = "El campo cédula debe ser ingresado";
                MessageBox.Show(msj);
                txtcedula.Focus();
            }
            else if (txtNumPas.Text.Equals("0"))
            {
                msj = "Ingrese el numero de pasajeros";
                MessageBox.Show(msj);
                txtNumPas.Focus();
            }
            else if(dtFechaIda.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("El valor de las fecha de partida no es correcto");
                
            }
            else if(dtFechaRegreso.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("El valor de las fecha de retorno no es correcto");
            }
            else
            {
                try
                {

                    Al.Cedula = txtcedula.Text;
                    Al.Cedula = txtcedula.Text;
                    Al.Nombres = txtnombres.Text;
                    Al.Apellidos = txtapellidos.Text;
                    Al.NumPas = Int16.Parse(txtNumPas.Text);
                    if (rbPrimeraClase.Checked == true)
                    {
                        Al.Clase = "Primera Clase";
                    }
                    else if (rbEconomica.Checked == true)
                    {
                        Al.Clase = "Económica";
                    }
                    else
                    {
                        Al.Clase = "Ejecutiva";
                    }
                    Al.Pais = cboxPaisOrigen.Text;
                    Al.Origen = lstOrigen.Text;
                    Al.Destino = lstDestino.Text;
                    Al.FechaIda = dtFechaIda.Value.ToLongDateString();
                    Al.FechaRegreso = dtFechaRegreso.Value.ToLongDateString();
                    Al.Precio = float.Parse(txtPrecio.Text);
                    MessageBox.Show(Al.registrar(varCi));

                    limpiar_celdas();
                    txtcedula.Focus();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void txtNumPas_MouseUp(object sender, MouseEventArgs e)
        {
          
        }
        private void txtNumPas_TextChanged(object sender, EventArgs e)
        {
            if(txtNumPas.Focus() == true)
            {
                
                
                if (lstDestino.SelectedItem != null)
                {
                    //String valor = lstDestino.SelectedItem.ToString();
                    lstDestino.ClearSelected();
                    txtPrecio.Text = "";
                    //lstDestino.Text = valor;
                }
            }
        }

        private void frmCompras_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaRegreso_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtFechaRegreso.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Porfavor elija una fecha correcta");

            }
            else
            {
                String fecha_regreso = dtFechaRegreso.Value.Date.ToShortDateString();
            }
        }
        void LlenarDestinosOrigen() 
        {
            
            dgvOrigen.Rows.Clear();
            dgvOrigen.Refresh();
            dgvDestino.Rows.Clear();
            dgvDestino.Refresh();
            listaAeropuerto = clsDestino.MostrarDestino().Item1;
            
            foreach (var Aeropuerto in listaAeropuerto)
            {
                System.Type type = Aeropuerto.GetType();
                
                String pais = type.GetProperty("lugarDestino").GetValue(Aeropuerto).ToString();
                String NombreAeropuerto = (String)type.GetProperty("Aeropuerto").GetValue(Aeropuerto);
                dgvOrigen.Rows.Add(pais,NombreAeropuerto);
                dgvDestino.Rows.Add(pais, NombreAeropuerto);
            }
        }

        void llenarlstPais() 
        {
            cboxPaisOrigen.Refresh();
            cboxPaisOrigen.Items.Clear();
            cboxPaisDestino.Refresh();
            cboxPaisDestino.Items.Clear();
            listaAeropuerto = clsDestino.MostrarPaises();

            foreach (var Aeropuerto in listaAeropuerto)
            {
                System.Type type = Aeropuerto.GetType();

                String pais = type.GetProperty("lugarDestino").GetValue(Aeropuerto).ToString();
                cboxPaisOrigen.Items.Add(pais);
                cboxPaisDestino.Items.Add(pais);
            }
        }

        private void cboxPaisDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDestino.Rows.Clear();
            dgvDestino.Refresh();
            listaAeropuerto = clsDestino.MostrarDestino().Item1;

            foreach (var Aeropuerto in listaAeropuerto)
            {
                System.Type type = Aeropuerto.GetType();

                String pais = type.GetProperty("lugarDestino").GetValue(Aeropuerto).ToString();
                if (cboxPaisDestino.SelectedItem.ToString().Equals(pais))
                {
                    String NombreAeropuerto = (String)type.GetProperty("Aeropuerto").GetValue(Aeropuerto);
                    dgvDestino.Rows.Add(pais, NombreAeropuerto);
                }
            }
        }
    }

}
