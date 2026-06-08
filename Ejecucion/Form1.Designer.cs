namespace Ejecucion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaylist3 = new System.Windows.Forms.Button();
            this.btnRegistrarCancion = new System.Windows.Forms.Button();
            this.btnRegueton = new System.Windows.Forms.Button();
            this.btnPlayList1 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.lbListaReproduccion = new System.Windows.Forms.Label();
            this.flowLayoutPanelCola = new System.Windows.Forms.FlowLayoutPanel();
            this.lbHistorial = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCentro = new System.Windows.Forms.Panel();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanelListaReproduccion = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListadereproduccion = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panelCancion = new System.Windows.Forms.Panel();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblCancion = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PanelIzquierdo.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.flowLayoutPanelCola.SuspendLayout();
            this.panelCentro.SuspendLayout();
            this.flowLayoutPanelListaReproduccion.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelCancion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(575, 34);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(53, 49);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "⏭";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(445, 34);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(53, 49);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "⏮";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(507, 33);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 53);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.Gray;
            this.PanelIzquierdo.Controls.Add(this.label3);
            this.PanelIzquierdo.Controls.Add(this.btnPlaylist3);
            this.PanelIzquierdo.Controls.Add(this.btnRegistrarCancion);
            this.PanelIzquierdo.Controls.Add(this.btnRegueton);
            this.PanelIzquierdo.Controls.Add(this.btnPlayList1);
            this.PanelIzquierdo.Controls.Add(this.btnInicio);
            this.PanelIzquierdo.Controls.Add(this.label2);
            this.PanelIzquierdo.Controls.Add(this.label1);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(267, 693);
            this.PanelIzquierdo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(16, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "PLAYLIST";
            // 
            // btnPlaylist3
            // 
            this.btnPlaylist3.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist3.FlatAppearance.BorderSize = 0;
            this.btnPlaylist3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist3.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist3.Location = new System.Drawing.Point(16, 399);
            this.btnPlaylist3.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaylist3.Name = "btnPlaylist3";
            this.btnPlaylist3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPlaylist3.Size = new System.Drawing.Size(231, 41);
            this.btnPlaylist3.TabIndex = 3;
            this.btnPlaylist3.Text = "CUMBIA";
            this.btnPlaylist3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist3.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCancion
            // 
            this.btnRegistrarCancion.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCancion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCancion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCancion.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCancion.Location = new System.Drawing.Point(16, 626);
            this.btnRegistrarCancion.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCancion.Name = "btnRegistrarCancion";
            this.btnRegistrarCancion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegistrarCancion.Size = new System.Drawing.Size(231, 41);
            this.btnRegistrarCancion.TabIndex = 5;
            this.btnRegistrarCancion.Text = "Registrar Canción";
            this.btnRegistrarCancion.UseVisualStyleBackColor = false;
            this.btnRegistrarCancion.Click += new System.EventHandler(this.btnRegistrarCancion_Click);
            // 
            // btnRegueton
            // 
            this.btnRegueton.FlatAppearance.BorderSize = 0;
            this.btnRegueton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegueton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegueton.ForeColor = System.Drawing.Color.White;
            this.btnRegueton.Location = new System.Drawing.Point(16, 332);
            this.btnRegueton.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegueton.Name = "btnRegueton";
            this.btnRegueton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegueton.Size = new System.Drawing.Size(231, 44);
            this.btnRegueton.TabIndex = 4;
            this.btnRegueton.Text = "REGUETON";
            this.btnRegueton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegueton.UseVisualStyleBackColor = true;
            // 
            // btnPlayList1
            // 
            this.btnPlayList1.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayList1.FlatAppearance.BorderSize = 0;
            this.btnPlayList1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayList1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayList1.ForeColor = System.Drawing.Color.White;
            this.btnPlayList1.Location = new System.Drawing.Point(16, 263);
            this.btnPlayList1.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayList1.Name = "btnPlayList1";
            this.btnPlayList1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPlayList1.Size = new System.Drawing.Size(231, 41);
            this.btnPlayList1.TabIndex = 3;
            this.btnPlayList1.Text = "ROCK";
            this.btnPlayList1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayList1.UseVisualStyleBackColor = false;
            this.btnPlayList1.Click += new System.EventHandler(this.btnPlayList1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(16, 100);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(231, 36);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "🎵";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MusicApp";
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.Gray;
            this.panelDerecho.Controls.Add(this.lbListaReproduccion);
            this.panelDerecho.Controls.Add(this.flowLayoutPanelCola);
            this.panelDerecho.Controls.Add(this.label4);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(811, 0);
            this.panelDerecho.Margin = new System.Windows.Forms.Padding(4);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(293, 779);
            this.panelDerecho.TabIndex = 4;
            // 
            // lbListaReproduccion
            // 
            this.lbListaReproduccion.AutoSize = true;
            this.lbListaReproduccion.BackColor = System.Drawing.Color.Transparent;
            this.lbListaReproduccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaReproduccion.ForeColor = System.Drawing.Color.White;
            this.lbListaReproduccion.Location = new System.Drawing.Point(24, 408);
            this.lbListaReproduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListaReproduccion.Name = "lbListaReproduccion";
            this.lbListaReproduccion.Size = new System.Drawing.Size(214, 32);
            this.lbListaReproduccion.TabIndex = 2;
            this.lbListaReproduccion.Text = "RECOMENDADAS";
            // 
            // flowLayoutPanelCola
            // 
            this.flowLayoutPanelCola.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCola.Controls.Add(this.lbHistorial);
            this.flowLayoutPanelCola.Location = new System.Drawing.Point(11, 75);
            this.flowLayoutPanelCola.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelCola.Name = "flowLayoutPanelCola";
            this.flowLayoutPanelCola.Size = new System.Drawing.Size(279, 301);
            this.flowLayoutPanelCola.TabIndex = 1;
            this.flowLayoutPanelCola.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelCola_Paint);
            // 
            // lbHistorial
            // 
            this.lbHistorial.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbHistorial.ForeColor = System.Drawing.Color.Transparent;
            this.lbHistorial.FormattingEnabled = true;
            this.lbHistorial.ItemHeight = 16;
            this.lbHistorial.Location = new System.Drawing.Point(4, 4);
            this.lbHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.lbHistorial.Name = "lbHistorial";
            this.lbHistorial.Size = new System.Drawing.Size(261, 276);
            this.lbHistorial.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "RECIENTES";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelCentro
            // 
            this.panelCentro.BackColor = System.Drawing.Color.Black;
            this.panelCentro.Controls.Add(this.btnArchivos);
            this.panelCentro.Controls.Add(this.label7);
            this.panelCentro.Controls.Add(this.flowLayoutPanelListaReproduccion);
            this.panelCentro.Controls.Add(this.panel5);
            this.panelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentro.Location = new System.Drawing.Point(0, 0);
            this.panelCentro.Margin = new System.Windows.Forms.Padding(4);
            this.panelCentro.Name = "panelCentro";
            this.panelCentro.Size = new System.Drawing.Size(811, 779);
            this.panelCentro.TabIndex = 5;
            // 
            // btnArchivos
            // 
            this.btnArchivos.Location = new System.Drawing.Point(667, 100);
            this.btnArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(100, 28);
            this.btnArchivos.TabIndex = 5;
            this.btnArchivos.Text = "📁";
            this.btnArchivos.UseVisualStyleBackColor = true;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(297, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 37);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lista de reproduccion ";
            // 
            // flowLayoutPanelListaReproduccion
            // 
            this.flowLayoutPanelListaReproduccion.AutoScroll = true;
            this.flowLayoutPanelListaReproduccion.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelListaReproduccion.Controls.Add(this.lbListadereproduccion);
            this.flowLayoutPanelListaReproduccion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelListaReproduccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelListaReproduccion.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanelListaReproduccion.Location = new System.Drawing.Point(293, 161);
            this.flowLayoutPanelListaReproduccion.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelListaReproduccion.Name = "flowLayoutPanelListaReproduccion";
            this.flowLayoutPanelListaReproduccion.Size = new System.Drawing.Size(492, 524);
            this.flowLayoutPanelListaReproduccion.TabIndex = 2;
            this.flowLayoutPanelListaReproduccion.WrapContents = false;
            this.flowLayoutPanelListaReproduccion.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelListaReproduccion_Paint);
            // 
            // lbListadereproduccion
            // 
            this.lbListadereproduccion.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbListadereproduccion.ForeColor = System.Drawing.Color.Transparent;
            this.lbListadereproduccion.FormattingEnabled = true;
            this.lbListadereproduccion.ItemHeight = 20;
            this.lbListadereproduccion.Location = new System.Drawing.Point(4, 4);
            this.lbListadereproduccion.Margin = new System.Windows.Forms.Padding(4);
            this.lbListadereproduccion.Name = "lbListadereproduccion";
            this.lbListadereproduccion.Size = new System.Drawing.Size(469, 484);
            this.lbListadereproduccion.TabIndex = 6;
            this.lbListadereproduccion.DoubleClick += new System.EventHandler(this.lbListadereproduccion_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBuscar);
            this.panel5.Controls.Add(this.txtBuscador);
            this.panel5.Location = new System.Drawing.Point(328, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(421, 57);
            this.panel5.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(339, 4);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 44);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "🔎";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscador
            // 
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.ForeColor = System.Drawing.Color.White;
            this.txtBuscador.Location = new System.Drawing.Point(32, 12);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(299, 27);
            this.txtBuscador.TabIndex = 0;
            // 
            // panelCancion
            // 
            this.panelCancion.BackColor = System.Drawing.Color.DimGray;
            this.panelCancion.Controls.Add(this.lblArtista);
            this.panelCancion.Controls.Add(this.lblCancion);
            this.panelCancion.Controls.Add(this.btnPlay);
            this.panelCancion.Controls.Add(this.btnSiguiente);
            this.panelCancion.Controls.Add(this.btnAnterior);
            this.panelCancion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCancion.Location = new System.Drawing.Point(0, 693);
            this.panelCancion.Margin = new System.Windows.Forms.Padding(4);
            this.panelCancion.Name = "panelCancion";
            this.panelCancion.Size = new System.Drawing.Size(811, 86);
            this.panelCancion.TabIndex = 0;
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.ForeColor = System.Drawing.Color.Silver;
            this.lblArtista.Location = new System.Drawing.Point(47, 43);
            this.lblArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(44, 16);
            this.lblArtista.TabIndex = 5;
            this.lblArtista.Text = "Artista";
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancion.ForeColor = System.Drawing.Color.White;
            this.lblCancion.Location = new System.Drawing.Point(47, 16);
            this.lblCancion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(73, 23);
            this.lblCancion.TabIndex = 4;
            this.lblCancion.Text = "Cancion";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 779);
            this.Controls.Add(this.PanelIzquierdo);
            this.Controls.Add(this.panelCancion);
            this.Controls.Add(this.panelCentro);
            this.Controls.Add(this.panelDerecho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelIzquierdo.ResumeLayout(false);
            this.PanelIzquierdo.PerformLayout();
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.flowLayoutPanelCola.ResumeLayout(false);
            this.panelCentro.ResumeLayout(false);
            this.panelCentro.PerformLayout();
            this.flowLayoutPanelListaReproduccion.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelCancion.ResumeLayout(false);
            this.panelCancion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Panel panelCentro;
        private System.Windows.Forms.Panel panelCancion;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaReproduccion;
        private System.Windows.Forms.Label lbListaReproduccion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlayList1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegueton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.ListBox lbListadereproduccion;
        private System.Windows.Forms.Button btnRegistrarCancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlaylist3;
        private System.Windows.Forms.ListBox lbHistorial;
    }
}

