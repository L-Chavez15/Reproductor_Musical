using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Ejecucion
{
    public partial class Form1 : Form
    {
        private ListaCircular playlist = new ListaCircular();
        private Cola cola = new Cola();
        private Pila historial = new Pila();

        //SoundPlayer player = new SoundPlayer();
        WindowsMediaPlayer player2= new WindowsMediaPlayer();//Reproductor de MP3

        private bool reproduciendo = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarColores();
        }
        private void AplicarColores()
        {
            this.BackColor = Color.FromArgb(18, 18, 18);
            panelCentro.BackColor = Color.FromArgb(22, 22, 22);
            PanelIzquierdo.BackColor = Color.FromArgb(30, 30, 30);
            panelDerecho.BackColor = Color.FromArgb(28, 28, 28);
            panelCancion.BackColor = Color.FromArgb(40, 40, 40);
            txtBuscador.BackColor = ColorTranslator.FromHtml("#2A2A2A");
            panel5.BackColor = Color.FromArgb(42, 42, 42);

            // TrackBar
            tbBarra.BackColor = Color.FromArgb(40, 40, 40);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (reproduciendo )
            {
                reproduciendo = false;
                btnPlay.Text = "▶";
                //player.Stop();
                player2.controls.pause();
                // guardamos la cancion actual en el historial
                //historial.Apilar(primero.dato);
            }
            else
            {
                reproduciendo = true;
                btnPlay.Text = "||";
                //player.SoundLocation = primero.dato.Ruta;
                //player.Load();//carga el archivo de sonido
                ////player.Play();
                player2.controls.play();
            }
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //MessageBox.Show("Nombre de cancion: "+ ofd.FileName);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Musica nuevaCancion = new Musica();
                nuevaCancion.Ruta = openFileDialog1.FileName;
                playlist.IngresarFinal(nuevaCancion);
                MostrarLista();
            }
        }
        private void MostrarLista()
        {
            lbListadereproduccion.Items.Clear();
            Nodo temp = playlist.primero;

            if (playlist.primero == null)
            {
                return;
            }

            do
            {
                lbListadereproduccion.Items.Add(temp.dato.Ruta);
                temp = temp.sig;

            } while (temp != playlist.primero);
        }
        
        private void btnSiguiente_Click(object sender, EventArgs e)
        { }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnPlayList1_Click(object sender, EventArgs e)
        {
            
        }
        private void flowLayoutPanelCola_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelListaReproduccion_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lbListadereproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //player= new SoundPlayer(lbListadereproduccion.SelectedItem.ToString());
            //player.Play();
            player2.URL = lbListadereproduccion.SelectedItem.ToString();
            player2.controls.play();
            reproduciendo = true;

        }

        private void btnRegistrarCancion_Click(object sender, EventArgs e)
        {
            RegistroCanciones.Form1 rc = new RegistroCanciones.Form1();
            rc.Show();
        }
    }
}
