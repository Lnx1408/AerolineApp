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
        public frmCompras()
        {
            InitializeComponent();
            cmbPais.Items.Add("Ecuador");
            cmbPais.Items.Add("Peru");
            cmbPais.Items.Add("Panama");
            cmbPais.Items.Add("Estados Unidos");
            cmbPais.Items.Add("Mexico");
            cmbPais.Items.Add("Londres");



        }
        private void limpiar_celdas()
        {
            txtcedula.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtNumPas.Text = "0";
            rbPrimeraClase.Checked = false;
            rbEconomica.Checked = false;
            cmbPais.Text = "";
            lstOrigen.Items.Clear();
            lstDestino.Items.Clear();
            txtPrecio.Text = "";
            dtFechaIda.Value = DateTime.Now;
            dtFechaRegreso.Value = DateTime.Now.AddDays(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu fm = new frmMenu();
            fm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmdregistrar_Click(object sender, EventArgs e)
        {

            String msj = "";
            String varCi = txtcedula.Text.Trim();

            if (txtcedula.Text.Equals(""))
            {
                msj = "El campo cédula debe ser ingresado";
                MessageBox.Show(msj);
                txtcedula.Focus();
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
                    Al.Pais = cmbPais.Text;
                    Al.Origen = lstOrigen.Text;
                    Al.Destino = lstDestino.Text;
                    Al.Precio = float.Parse(txtPrecio.Text);
                    msj = Al.registrar(varCi);
                    MessageBox.Show(msj);

                    limpiar_celdas();
                    txtcedula.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lstOrigen_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOrigen.Items.Clear();
            lstDestino.Items.Clear();
            // MessageBox.Show(cmbNacionalidad.GetItemText(cmbNacionalidad.SelectedItem));

            try
            {
                //TextReader leerProv;
                if (cmbPais.Text.Equals("Ecuador"))
                {
                    StreamReader archivo = new StreamReader("Provincias.txt");

                    for (int i = 0; i < 4; i++)
                    {
                        lstOrigen.Items.Add(archivo.ReadLine());

                    }

                    //archivo.ReadToEnd();
                    //archivo.DiscardBufferedData();
                    //archivo.Dispose();
                    archivo.Close();

                }
                else if (cmbPais.Text.Equals("Panama"))
                {
                    StreamReader archivo = new StreamReader("panama.txt");

                    for (int i = 0; i < 3; i++)
                    {
                        lstOrigen.Items.Add(archivo.ReadLine());

                    }


                    archivo.Close();
                }



            }
            catch (Exception j)
            {
                MessageBox.Show("Error el archivo no existe: " +j);
            }
        }

        private void btmGuardar_Click(object sender, EventArgs e)
        {
            String msj = "";
            String varCi = txtcedula.Text.Trim();


            if (txtcedula.Text.Equals(""))
            {
                msj = "El campo cédula debe ser ingresado";
                MessageBox.Show(msj);
                txtcedula.Focus();
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
                    Al.Pais = cmbPais.Text;
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

        private void txtconsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCompra frmEstCons = new frmConsultarCompra(Al);
            frmEstCons.Show();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            txtNumPas.Text = "0";
            pictureBox2.SendToBack();
            pictureBox3.SendToBack();
            txtPrecio.Enabled = false;
            dtFechaRegreso.Value = DateTime.Now.AddDays(1);


        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            //Al.FechaIda = dtFechaIda.ToString();
            //MessageBox.Show(dtFechaIda.Value.ToLongDateString());   
            frmConsultarCompra frmCons = new frmConsultarCompra(Al);
            frmCons.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String fecha_inicio = dtFechaIda.Value.Date.ToShortDateString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstDestino_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dtFechaRegreso_ValueChanged(object sender, EventArgs e)
        {

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

            lstOrigen.Items.Clear();
            lstDestino.Items.Clear();
            // MessageBox.Show(cmbNacionalidad.GetItemText(cmbNacionalidad.SelectedItem));

            try
            {
                //TextReader leerProv;
                if (cmbPais.Text.Equals("Ecuador"))
                {
                    StreamReader archivo = new StreamReader("Provincias.txt");

                    for (int i = 0; i < 4; i++)
                    {
                        lstOrigen.Items.Add(archivo.ReadLine());

                    }

                    //archivo.ReadToEnd();
                    //archivo.DiscardBufferedData();
                    //archivo.Dispose();
                    archivo.Close();

                }
                else if (cmbPais.Text.Equals("Panama"))
                {
                    StreamReader archivo = new StreamReader("panama.txt");

                    for (int i = 0; i < 3; i++)
                    {
                        lstOrigen.Items.Add(archivo.ReadLine());

                    }


                    archivo.Close();
                }



            }
            catch (Exception j)
            {
                MessageBox.Show("Error el archivo no existe: " +j);
            }

        }

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
                    Al.Pais = cmbPais.Text;
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

      

      

        private void txtNumPas_MouseCaptureChanged(object sender, EventArgs e)
        {
            
            
            

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

        private void txtcedula_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void validarNumeros(KeyPressEventArgs k)
        {
            if (Char.IsDigit(k.KeyChar) || Char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }
            else k.Handled = true;
        }
        public void validarLetras(KeyPressEventArgs k)
        {
            if (Char.IsLetter(k.KeyChar) || Char.IsControl(k.KeyChar) || Char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }
            else k.Handled = true;
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

        private void txtNumPas_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarLetras(e);
        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarLetras(e);
        }
    }
}
