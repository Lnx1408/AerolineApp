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
    public partial class FrmReporteCompra : Form
    {
        public FrmReporteCompra(DataSet registro)
        {
            InitializeComponent();
            CrystalReporteCompra rp = new CrystalReporteCompra();
            rp.SetDataSource(registro.Tables[0]);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.RefreshReport();
        }

        private void FrmReporteCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
