using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecucion
{
    public partial class Login : Form
    {
        Arbol abb;
        public string UsuarioIngresado;
        public Login(ref Arbol abb)
        {
           InitializeComponent();
           this.abb = abb;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Diseño();
        }
        private void Diseño()
        {
            BackColor=Color.FromArgb(18, 18, 18);
            btnRegistrar.BackColor = Color.FromArgb(29, 185, 84);
            txtContrasena.PasswordChar = '*';
            btnIngresar.BackColor = Color.FromArgb(29, 185, 84);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario u= abb.BuscarUsuario(abb.raizPrincipal2, txtUsuario.Text);
            if (u == null)
            {
                MessageBox.Show("Usuario no existe");
                return;
            }

            if (u.Contrasena != txtContrasena.Text)
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }
            UsuarioIngresado = u.NombreUsuario; 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
