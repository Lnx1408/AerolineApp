using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineApp.Reportes;

namespace AerolineApp
{
    public partial class frmDestinoReporte : Form
    {
        public frmDestinoReporte(DataSet registro)
        {
            InitializeComponent();
            CrystalReportsDestinos reportsDestinos = new CrystalReportsDestinos();
            reportsDestinos.SetDataSource(registro.Tables[0]);
            crystalReportViewer1.ReportSource = reportsDestinos;
            crystalReportViewer1.RefreshReport();
        }
    }
}
