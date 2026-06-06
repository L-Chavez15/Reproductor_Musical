using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegistroCanciones
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        public Musica CancionRegistrada;
        public ListaDoble ld = new ListaDoble();
        private Arbol abb = new Arbol();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Diseño();
        }
        private void Diseño()
        {
            this.BackColor = Color.FromArgb(18, 18, 18);
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            txtNombre.BackColor = Color.FromArgb(42, 42, 42);
            txtNombre.ForeColor = Color.White;
            txtArtista.BackColor = Color.FromArgb(42, 42, 42);
            txtArtista.ForeColor = Color.White;
            btnBuscar.BackColor = Color.FromArgb(60, 60, 60);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog2.FileName;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*if (abb.Buscar(abb.raizPrincipal, txtNombre.Text))
            {
                MessageBox.Show("La canción ya está registrada.");
                return;
            }*/
            Musica RCancion = new Musica();
            RCancion.Nombre = txtNombre.Text;
            RCancion.Artista = txtArtista.Text;
            RCancion.genero = cmbGuardaren.Text;
            RCancion.Ruta = ruta;
            CancionRegistrada = RCancion;
            ld.Ingresar(RCancion);

            MessageBox.Show("¡Canción registrada correctamente!");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private void MostrarLista()
        {
            Nodo temp = ld.primero;
            while (temp != null)
            {
                MessageBox.Show(temp.dato.ToString());
                temp = temp.sig;
            }
        }
    }

}
