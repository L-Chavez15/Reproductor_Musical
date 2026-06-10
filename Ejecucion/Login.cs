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
        Arbol abb = new Arbol();
        public Login()
        {
           InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }
            
            Usuario u = new Usuario();
           u.Nombre = txtNombre.Text;
           u.NombreUsuario = txtUsuario.Text;
            u.Contrasena = txtContrasena.Text;

            abb.InsertarUsuario(ref abb.raizPrincipal, u);
            abb.BuscarUsuario(abb.raizPrincipal, u.NombreUsuario);
        }
    }
}
