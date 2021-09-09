using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace AerolineApp
{
    public partial class frmDestinoConsultar : Form
    {
        ClsDestino destinoTemp;
        List<object> lst_destinos_tmp;
        SqlDataAdapter registros;
        FrmDestinos frmDestinos = new FrmDestinos();

        public frmDestinoConsultar()
        {
            InitializeComponent();
        }
        public frmDestinoConsultar(ClsDestino destino) {
            InitializeComponent();
            destinoTemp = destino;
            llenarDGVDestinos();
        }


        public void llenarDGVDestinos() {

            dgv_Destinos.Rows.Clear();
            dgv_Destinos.Refresh();
            lst_destinos_tmp = destinoTemp.MostrarDestino().Item1;

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var destino in lst_destinos_tmp)
            {
                System.Type type = destino.GetType();

                int NumeroDestino = (int)type.GetProperty("idDestino").GetValue(destino);
                String Pais = (String)type.GetProperty("lugarDestino").GetValue(destino);
                String Ciudad = (String)type.GetProperty("Ciudad").GetValue(destino);
                String NombreAeropuerto = (String)type.GetProperty("Aeropuerto").GetValue(destino);
                String foto = (String)type.GetProperty("Foto").GetValue(destino);

                dgv_Destinos.Rows.Add(NumeroDestino, Pais, Ciudad, NombreAeropuerto, foto);

            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtPais.Text.Equals("")){
                llenarDGVDestinos();
            }
            else {
                BuscarxPais();
            }
        }

        public void BuscarxPais() {
            dgv_Destinos.Rows.Clear();
            dgv_Destinos.Refresh();
            lst_destinos_tmp = destinoTemp.MostrarDestino().Item1;

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var destino in lst_destinos_tmp)
            {
                System.Type type = destino.GetType();
                String Pais = (String)type.GetProperty("lugarDestino").GetValue(destino);
                if (Pais.Equals(txtPais.Text))
                {
                    int NumeroDestino = (int)type.GetProperty("idDestino").GetValue(destino);
                    String Ciudad = (String)type.GetProperty("Ciudad").GetValue(destino);
                    String NombreAeropuerto = (String)type.GetProperty("Aeropuerto").GetValue(destino);
                    String foto = (String)type.GetProperty("Foto").GetValue(destino);

                    dgv_Destinos.Rows.Add(NumeroDestino, Pais, Ciudad, NombreAeropuerto, foto);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(destinoTemp.BorrarDestino(int.Parse(dgv_Destinos.CurrentRow.Cells[0].Value.ToString())));
            //destinoTemp.MostrarDestino();
            llenarDGVDestinos();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmDestinos.Show();
            this.Hide();
        }

        private void btListarTodos_Click(object sender, EventArgs e)
        {
            llenarDGVDestinos();
        }

        
        private void frmDestinoConsultar_Shown(object sender, EventArgs e)
        {
            txtPais.Focus();
        }

        private void dgv_Destinos_Click(object sender, EventArgs e)
        {
            /*if (!dgv_Destinos.RowCount.Equals(0))
            {
                pboxFoto.Image = Image.FromFile(dgv_Destinos.CurrentRow.Cells[4].Value.ToString());

            }*/
        }

        private void dgv_Destinos_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgv_Destinos.RowCount.Equals(0))
            {
                pboxFoto.Image = Image.FromFile(dgv_Destinos.CurrentRow.Cells[4].Value.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDestinoModificar destinoModificar = new frmDestinoModificar(dgv_Destinos.CurrentRow.Cells[0].Value.ToString(),destinoTemp);
            destinoModificar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            
            //this.registros.Fill(ds, "Destino");
            frmDestinoReporte destinoReporte = new frmDestinoReporte();
            destinoReporte.ShowDialog();
        }
    }
}
