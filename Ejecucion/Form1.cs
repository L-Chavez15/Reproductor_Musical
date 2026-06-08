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
using System.Windows.Data;
using System.Windows.Forms;
using WMPLib;

namespace Ejecucion
{
    public partial class Form1 : Form
    {
        //Declaramos 3 estructuras de datos: 
        public ListaCircular playlist = new ListaCircular();//una lista circular para la playlist
        private Pila historial = new Pila();//una pila para el historial 
        public ListaDoble ld= new ListaDoble();//una lista doble para las canciones registradas

        //SoundPlayer player = new SoundPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();//Reproductor de MP3

        private bool reproduciendo = false;//indica si se esta reproduciendo una cancion o no
        private Nodo nodoActual = null;//indica la cancion actual que se esta reproduciendo

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
            //tbBarra.BackColor = Color.FromArgb(40, 40, 40);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (reproduciendo )
            {
                reproduciendo = false;
                btnPlay.Text = "▶";
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
        public void MostrarLista()
        {
            lbListadereproduccion.Items.Clear();

            if (playlist.primero == null)
            {
                return;
            }
            Nodo temp = playlist.primero;
            do
            {
                lbListadereproduccion.Items.Add(temp.dato); // se debe castear, envia dato completo de música
                temp = temp.sig;

            } while (temp != playlist.primero);
        }
        
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nodoActual != null)
            {
                /*historial.Apilar(nodoActual.dato);
                MostrarHistorial();
                nodoActual = nodoActual.sig;
                CancionActual();
                player2.URL = nodoActual.dato.Ruta;
                player2.controls.play();*/
                historial.Apilar(nodoActual.dato);
                nodoActual = nodoActual.sig;
                CancionActual();
                MostrarHistorial();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Musica anterior = historial.Desapilar();

            if (anterior == null)
            {
            return;
            }

            Nodo temp = playlist.primero;

            do
            {
                if (temp.dato.Ruta == anterior.Ruta)
                {
                    nodoActual = temp;
                    break;
                }

                temp = temp.sig;

            } while (temp != playlist.primero);

            CancionActual();
            MostrarHistorial();
        }
        private void CancionActual()
        {
            if (playlist.primero != null)
            {
                player2.URL = nodoActual.dato.Ruta;
                player2.controls.play();
                reproduciendo = true;
                btnPlay.Text = "||";
            }
        }
        private void MostrarHistorial()
        {
            lbHistorial.Items.Clear();

            Nodo temp = historial.cima;

            while (temp != null)
            {
                Label lbl = new Label();

                lbl.AutoSize = true;
                lbl.ForeColor = Color.White;
                lbl.Text = temp.dato.Artista + " - " + temp.dato.Nombre+"\n";

                lbHistorial.Items.Add(lbl.Text);

                temp = temp.sig;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lbListadereproduccion.Items.Clear();
            lbHistorial.Items.Clear();
        }

        private void btnPlayList1_Click(object sender, EventArgs e)
        {
        }
        private void flowLayoutPanelCola_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbListadereproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*player= new SoundPlayer(lbListadereproduccion.SelectedItem.ToString());
            player.Play();
            player2.URL = lbListadereproduccion.SelectedItem.ToString();
            player2.controls.play();
            reproduciendo = true;
            btnPlay.Text = "||";*/
            //lbListadereproduccion.SelectedItem.ToString();

            /*
             Musica cancion = (Musica)lbListadereproduccion.SelectedItem;
             player2.URL = cancion.Ruta;
             player2.controls.play();
             reproduciendo = true;
             btnPlay.Text = "||";
            */
            Musica cancion = (Musica)lbListadereproduccion.SelectedItem;//casteamos el item seleccionado a Musica para obtener su ruta y reproducirla.

            if (nodoActual != null)
            {
                historial.Apilar(nodoActual.dato);
                MostrarHistorial();
            }

            Nodo temp = playlist.primero;

            do
            {
                if (temp.dato.Ruta == cancion.Ruta)
                {
                    nodoActual = temp;
                    break;
                }

                temp = temp.sig;

            } while (temp != playlist.primero);

            CancionActual();
            MostrarHistorial();

        }


        private void btnRegistrarCancion_Click(object sender, EventArgs e) 
        {
            Form2 rc = new Form2(ref ld);
            if (rc.ShowDialog() == DialogResult.OK)
            {
                playlist.IngresarFinal(rc.CancionRegistrada);
                MostrarLista();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanelListaReproduccion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
