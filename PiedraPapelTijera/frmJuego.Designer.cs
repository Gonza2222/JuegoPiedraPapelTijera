namespace PiedraPapelTijera
{
    partial class frmJuego
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.lblContador1 = new System.Windows.Forms.Label();
            this.lblContador2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContador3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pctMaquina = new System.Windows.Forms.PictureBox();
            this.pctJugador = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tmrTemporizador = new System.Windows.Forms.Timer(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaquina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computadora";
            // 
            // btnJugar
            // 
            this.btnJugar.Enabled = false;
            this.btnJugar.Location = new System.Drawing.Point(246, 448);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(144, 23);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "Jugar de nuevo";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.Location = new System.Drawing.Point(76, 382);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(75, 23);
            this.btnTijera.TabIndex = 5;
            this.btnTijera.Text = "Tijera";
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Location = new System.Drawing.Point(76, 340);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(75, 23);
            this.btnPapel.TabIndex = 6;
            this.btnPapel.Text = "Papel";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPiedra
            // 
            this.btnPiedra.Location = new System.Drawing.Point(76, 299);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(75, 23);
            this.btnPiedra.TabIndex = 7;
            this.btnPiedra.Text = "Piedra";
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // lblContador1
            // 
            this.lblContador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador1.Location = new System.Drawing.Point(154, 93);
            this.lblContador1.Name = "lblContador1";
            this.lblContador1.Size = new System.Drawing.Size(41, 37);
            this.lblContador1.TabIndex = 12;
            this.lblContador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContador2
            // 
            this.lblContador2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador2.Location = new System.Drawing.Point(563, 93);
            this.lblContador2.Name = "lblContador2";
            this.lblContador2.Size = new System.Drawing.Size(42, 37);
            this.lblContador2.TabIndex = 13;
            this.lblContador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Partidas jugadas";
            // 
            // lblContador3
            // 
            this.lblContador3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador3.Location = new System.Drawing.Point(293, 340);
            this.lblContador3.Name = "lblContador3";
            this.lblContador3.Size = new System.Drawing.Size(56, 49);
            this.lblContador3.TabIndex = 15;
            this.lblContador3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gana el que primero llegue a 3 puntos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PiedraPapelTijera.Properties.Resources.rock_paper_scissors_line_icons_vector;
            this.pictureBox3.Location = new System.Drawing.Point(242, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pctMaquina
            // 
            this.pctMaquina.Location = new System.Drawing.Point(459, 141);
            this.pctMaquina.Name = "pctMaquina";
            this.pctMaquina.Size = new System.Drawing.Size(130, 131);
            this.pctMaquina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMaquina.TabIndex = 1;
            this.pctMaquina.TabStop = false;
            // 
            // pctJugador
            // 
            this.pctJugador.Location = new System.Drawing.Point(51, 141);
            this.pctJugador.Name = "pctJugador";
            this.pctJugador.Size = new System.Drawing.Size(130, 131);
            this.pctJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctJugador.TabIndex = 0;
            this.pctJugador.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(206, 162);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(228, 100);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTemporizador
            // 
            this.tmrTemporizador.Interval = 1000;
            this.tmrTemporizador.Tick += new System.EventHandler(this.tmrTemporizador_Tick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(413, 480);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(65, 55);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tienes 3 segundos para jugar";
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(672, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContador3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContador2);
            this.Controls.Add(this.lblContador1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPiedra);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctMaquina);
            this.Controls.Add(this.pctJugador);
            this.Name = "frmJuego";
            this.Text = "Piedra, Papel, Tijera";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaquina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctJugador;
        private System.Windows.Forms.PictureBox pctMaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblContador1;
        private System.Windows.Forms.Label lblContador2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContador3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Timer tmrTemporizador;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label4;
    }
}

