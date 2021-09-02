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
    public partial class frmDestinoConsultar : Form
    {
        ClsDestino destinoTemp;
        List<object> lst_destinos_tmp;
        FrmDestinos frmDestinos;

        public frmDestinoConsultar()
        {
            InitializeComponent();
        }
        public frmDestinoConsultar(ClsDestino destino, FrmDestinos frmDestinos) {
            InitializeComponent();
            destinoTemp = destino;
            this.frmDestinos = frmDestinos;
            llenarDGVDestinos();
        }


        public void llenarDGVDestinos() {

            dgv_Destinos.Rows.Clear();
            dgv_Destinos.Refresh();
            lst_destinos_tmp = destinoTemp.MostrarDestino();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var destino in lst_destinos_tmp)
            {
                System.Type type = destino.GetType();

                int NumeroDestino = (int)type.GetProperty("numeroDestino").GetValue(destino);
                String Pais = (String)type.GetProperty("pais").GetValue(destino);
                String Ciudad = (String)type.GetProperty("ciudad").GetValue(destino);
                String NombreAeropuerto = (String)type.GetProperty("nombreAeropuerto").GetValue(destino);
                String fecha = (String)type.GetProperty("detalleDireccion").GetValue(destino);

                dgv_Destinos.Rows.Add(NumeroDestino, Pais, Ciudad, NombreAeropuerto, fecha);

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
            lst_destinos_tmp = destinoTemp.MostrarDestino();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var destino in lst_destinos_tmp)
            {
                System.Type type = destino.GetType();
                String Pais = (String)type.GetProperty("pais").GetValue(destino);
                if (Pais.Equals(txtPais.Text))
                {
                    int NumeroDestino = (int)type.GetProperty("numeroDestino").GetValue(destino);
                    String Ciudad = (String)type.GetProperty("ciudad").GetValue(destino);
                    String NombreAeropuerto = (String)type.GetProperty("nombreAeropuerto").GetValue(destino);
                    String DetalleDireccion = (String)type.GetProperty("detalleDireccion").GetValue(destino);

                    dgv_Destinos.Rows.Add(NumeroDestino, Pais, Ciudad, NombreAeropuerto, DetalleDireccion);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(destinoTemp.BorrarDestino(int.Parse(dgv_Destinos.CurrentRow.Cells[0].Value.ToString())));
            destinoTemp.MostrarDestino();
            llenarDGVDestinos();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            frmDestinos.Show();
        }

        private void btListarTodos_Click(object sender, EventArgs e)
        {
            llenarDGVDestinos();
        }

        private void BtBuscar_MouseEnter(object sender, EventArgs e)
        {
            BtBuscar.BackColor = Color.LightBlue; ;
        }

        private void BtBuscar_MouseLeave(object sender, EventArgs e)
        {
            BtBuscar.BackColor = Color.Transparent;
        }

        private void btListarTodos_MouseEnter(object sender, EventArgs e)
        {
            btListarTodos.BackColor = Color.LightBlue;
        }

        private void btListarTodos_MouseLeave(object sender, EventArgs e)
        {
            btListarTodos.BackColor = Color.Transparent;
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.LightBlue;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.Transparent;
        }

        private void frmDestinoConsultar_Shown(object sender, EventArgs e)
        {
            txtPais.Focus();
        }
    }
}
