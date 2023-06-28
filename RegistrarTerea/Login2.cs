using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrarTerea
{
    public partial class Login2 : Form
    {
  
        public Login2()
        {
            InitializeComponent();
            
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                Form Actividad = new Registrar();
                Actividad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecto/s");
            }
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login2_Load(object sender, EventArgs e)
        {

        }
    }
}
