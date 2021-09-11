using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AerolineApp
{
    public partial class frmConsultarCompra : Form
    {
        List<Object> lst_alumnos_tmp;
        ClsPasajero VueloTemp;
        SqlDataAdapter registros;
        public frmConsultarCompra(ClsPasajero Al)
        {
            InitializeComponent();
            this.VueloTemp = Al;
            llenar_datagridview_alumnos();
        }

        public void llenar_datagridview_alumnos()
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();
            lst_alumnos_tmp = VueloTemp.listar().Item1;
            this.registros = VueloTemp.listar().Item2;

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var alumno in lst_alumnos_tmp)
            {
                System.Type type = alumno.GetType();

                String cedula = (String)type.GetProperty("cedula").GetValue(alumno);
                String nombres = (String)type.GetProperty("nombres").GetValue(alumno);
                String apellidos = (String)type.GetProperty("apellidos").GetValue(alumno);
                Int16 numPas = (Int16)type.GetProperty("numPas").GetValue(alumno);
                String clase = (String)type.GetProperty("clase").GetValue(alumno);
                String pais = (String)type.GetProperty("pais").GetValue(alumno);
                String origen = (String)type.GetProperty("origen").GetValue(alumno);  //los valores en comilla doble pertenecen al metodo listar_alumno del clsManejador
                String destino = (String)type.GetProperty("destino").GetValue(alumno);
                String fechaId = (String)type.GetProperty("fechaIda").GetValue(alumno);
                String fechaRegreso = (String)type.GetProperty("fechaRegreso").GetValue(alumno);
                float precio = (float)type.GetProperty("precio").GetValue(alumno);

                dgv_listarTodos.Rows.Add(cedula, nombres, apellidos, numPas, clase, pais, origen, destino, fechaId, fechaRegreso, precio);

            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarCompra_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }

        private void dgv_listarTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Esta segur@ de eliminar su compra", "Cancelación de compra", buttons);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(VueloTemp.eliminar((dgv_listarTodos.CurrentRow.Cells[0].Value.ToString())));
                    llenar_datagridview_alumnos();
                }
                else
                {
                    llenar_datagridview_alumnos();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos o filas para eliminar.");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataSet datset = new DataSet();
            this.registros.Fill(datset, "Aereolinea");
            FrmReporteCompra frmRep = new FrmReporteCompra(datset);
            frmRep.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(VueloTemp.eliminar((dgv_listarTodos.CurrentRow.Cells[0].Value.ToString())));
                llenar_datagridview_alumnos();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos o filas para eliminar.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataSet datset = new DataSet();
            this.registros.Fill(datset, "Aereolinea");
            FrmReporteCompra frmRep = new FrmReporteCompra(datset);
            frmRep.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(VueloTemp.eliminar((dgv_listarTodos.CurrentRow.Cells[0].Value.ToString())));
                llenar_datagridview_alumnos();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos o filas para eliminar.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DataSet datset = new DataSet();
            this.registros.Fill(datset, "Aereolinea");
            FrmReporteCompra frmRep = new FrmReporteCompra(datset);
            frmRep.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
