using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using NAudio.Wave;

namespace Ejecucion
{
    public partial class Form1 : Form
    {
        private ListaCircular playlist = new ListaCircular();
        private Cola cola = new Cola();
        private Pila historial = new Pila();

        public Nodo primero=null;//l.circular

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
        
    }
}
