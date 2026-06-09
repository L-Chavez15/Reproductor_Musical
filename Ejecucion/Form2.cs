using Clases;
using Microsoft.Win32;
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
    public partial class Form2 : Form
    {
        ListaDoble rock,cumbia, regueton;
        public Musica CancionRegistrada;
        private string ruta = "";

        public Form2(ref ListaDoble rock, ref ListaDoble cumbia, ref ListaDoble regueton)
        {
            InitializeComponent();
            this.rock = rock;
            this.cumbia = cumbia;
            this.regueton = regueton;
        }

        private void Form2_Load(object sender, EventArgs e)
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
            btnArchivo.BackColor = Color.FromArgb(60, 60, 60);
            btnArchivo.ForeColor = Color.White;
            btnArchivo.FlatStyle = FlatStyle.Flat;
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog2.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Musica RCancion = new Musica();
            RCancion.Nombre = txtNombre.Text;
            RCancion.Artista = txtArtista.Text;
            RCancion.genero = cmbGenero.Text;
            RCancion.Ruta = ruta;
            CancionRegistrada = RCancion;
            switch (RCancion.genero)
            {
                case "Rock":
                    rock.Ingresar(RCancion);
                    break;
                case "Cumbia":
                    cumbia.Ingresar(RCancion);
                    break;
                case "Regueton":
                    regueton.Ingresar(RCancion);
                    break;
                default:
                    break;
            }
            //ld.Ingresar(RCancion);

            MessageBox.Show("¡Canción registrada correctamente!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
