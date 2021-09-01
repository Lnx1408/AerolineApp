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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
            lblIntegrantes.Parent = pictureBox1;
            txtPassword.PasswordChar = '*';

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[1.] DÁVILA VIDAL JOSÉ ANDRÉS\n" +
                "[2.] LINO SÁNCHEZ YERMIN\n" +
                "[3.] TENEMEA LOJANO NEYSSER","Integrantes - Grupo #2");
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMenu frmMenuContext = new frmMenu();
            frmMenuContext.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frmRegister = new frmRegistrar();
            frmRegister.Show();
        }
    }   
}
