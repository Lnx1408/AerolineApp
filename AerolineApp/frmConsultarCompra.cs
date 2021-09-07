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


namespace AerolineApp
{
    public partial class frmConsultarCompra : Form
    {
        List<Object> lst_alumnos_tmp;
        ClsPasajero AlumnoTemp;
        public frmConsultarCompra(ClsPasajero Al)
        {
            InitializeComponent();
            this.AlumnoTemp = Al;
            llenar_datagridview_alumnos();
        }

        public void llenar_datagridview_alumnos()
        {
            dgv_listarTodos.Rows.Clear();
            dgv_listarTodos.Refresh();
            lst_alumnos_tmp = AlumnoTemp.listar();

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
    }
}
