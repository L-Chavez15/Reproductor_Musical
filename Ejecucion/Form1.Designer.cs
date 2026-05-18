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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpReproduccion = new System.Windows.Forms.GroupBox();
            this.grpListas = new System.Windows.Forms.GroupBox();
            this.btnRecientes = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.grpListas.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReproduccion
            // 
            this.grpReproduccion.BackColor = System.Drawing.Color.DimGray;
            this.grpReproduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpReproduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReproduccion.ForeColor = System.Drawing.Color.White;
            this.grpReproduccion.Location = new System.Drawing.Point(12, 122);
            this.grpReproduccion.Name = "grpReproduccion";
            this.grpReproduccion.Size = new System.Drawing.Size(506, 446);
            this.grpReproduccion.TabIndex = 0;
            this.grpReproduccion.TabStop = false;
            this.grpReproduccion.Text = "PLAYLIST";
            this.grpReproduccion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpListas
            // 
            this.grpListas.BackColor = System.Drawing.Color.DimGray;
            this.grpListas.Controls.Add(this.btnRecientes);
            this.grpListas.Controls.Add(this.btnCola);
            this.grpListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpListas.Location = new System.Drawing.Point(537, 122);
            this.grpListas.Name = "grpListas";
            this.grpListas.Size = new System.Drawing.Size(275, 446);
            this.grpListas.TabIndex = 0;
            this.grpListas.TabStop = false;
            // 
            // btnRecientes
            // 
            this.btnRecientes.BackColor = System.Drawing.Color.Transparent;
            this.btnRecientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecientes.ForeColor = System.Drawing.Color.White;
            this.btnRecientes.Location = new System.Drawing.Point(145, 19);
            this.btnRecientes.Name = "btnRecientes";
            this.btnRecientes.Size = new System.Drawing.Size(124, 32);
            this.btnRecientes.TabIndex = 1;
            this.btnRecientes.Text = "RECIENTES";
            this.btnRecientes.UseVisualStyleBackColor = false;
            // 
            // btnCola
            // 
            this.btnCola.BackColor = System.Drawing.Color.Transparent;
            this.btnCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCola.ForeColor = System.Drawing.Color.White;
            this.btnCola.Location = new System.Drawing.Point(6, 19);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(124, 32);
            this.btnCola.TabIndex = 0;
            this.btnCola.Text = "COLA";
            this.btnCola.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(387, 574);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(39, 40);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "⏮";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(432, 574);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(39, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(477, 574);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(39, 40);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "⏭";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "🎶MusicApp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(824, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "REPRODUCTOR";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(128, 22);
            this.toolStripButton2.Text = "REGISTRO DE MUSICA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.grpListas);
            this.Controls.Add(this.grpReproduccion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpListas.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReproduccion;
        private System.Windows.Forms.GroupBox grpListas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecientes;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

