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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDestinos fdestino = new FrmDestinos();
            fdestino.Show();
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDestinos fd = new FrmDestinos();
            fd.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFlotaAviones frmFlota = new frmFlotaAviones();
            frmFlota.Show();
        }

        private void pbFlota_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFlotaAviones frmFlota = new frmFlotaAviones();
            frmFlota.Show();
        }

        private void lbDestinos_MouseEnter(object sender, EventArgs e)
        {
            lbDestinos.BackColor = Color.LightBlue;
        }

        private void lbDestinos_MouseLeave(object sender, EventArgs e)
        {
            lbDestinos.BackColor = Color.Transparent;
        }

        private void pbDestinos_MouseEnter(object sender, EventArgs e)
        {
            pbDestinos.BackColor = Color.LightBlue;
        }

        private void pbDestinos_MouseLeave(object sender, EventArgs e)
        {
            pbDestinos.BackColor = Color.Transparent;
        }

        private void pbFlota_MouseEnter(object sender, EventArgs e)
        {
            pbFlota.BackColor = Color.LightBlue;
        }

        private void lbFlotaAviones_MouseEnter(object sender, EventArgs e)
        {
            lbFlotaAviones.BackColor = Color.LightBlue;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightBlue;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void lbFlotaAviones_MouseLeave(object sender, EventArgs e)
        {
            lbFlotaAviones.BackColor = Color.Transparent;
        }

        private void pbFlota_MouseLeave(object sender, EventArgs e)
        {
            pbFlota.BackColor = Color.Transparent;
        }
    }  
}
