using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }
        // 1 = piedra, 2 = papel, 3 = tijera

        Random R = new Random(); //Objeto generador de numeros aleatorios
        Timer Tiempo = new Timer(); //Objeto generador de temporizador

        Int32 J = 0; //VARIABLE J = Jugador , para el contador de puntos
        Int32 C = 0; //VARIABLE C = Computadora , para el contador de puntos
        Int32 P = 0; //VARIABLE P = Cantidad de partidas jugadas
        Int32 T = 0;
        private void btnPiedra_Click(object sender, EventArgs e)
        {
            pctJugador.Image = PiedraPapelTijera.Properties.Resources.png_transparent_rock_paper_scissors_computer_icons_scissors_game_white_face_thumbnail;
            Int32 Pi = R.Next(1, 4);//voy a generar >=1 y <4
            tmrTemporizador.Start();
            T = 0;
            lblMensaje.Text = T.ToString();
            switch (Pi) 
            {
                case 1:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.png_transparent_rock_paper_scissors_computer_icons_scissors_game_white_face_thumbnail;
                    lblResultado.Text = "Empate!!";
                    break;                  
                case 2:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.descarga;
                    lblResultado.Text = "Perdiste!!";
                    C = C + 1;//Cuando gana la computadora le incrementa 1 punto
                    break;
                case 3:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.images;
                    lblResultado.Text = "Ganaste!!";
                    J = J + 1; //Cuando gana el jugador le incrementa 1 punto
                    break;
            }
            if (J == 3)
            {
                lblResultado.Text = "Fin del juego ganaste!!";
                btnPapel.Enabled = false;
                btnPiedra.Enabled = false;
                btnTijera.Enabled = false;
                btnJugar.Enabled = true;
                P = P + 1;
                tmrTemporizador.Stop();
            }
            if (C == 3)
            {
                lblResultado.Text = "Fin del juego perdiste!!";
                btnPapel.Enabled = false;
                btnPiedra.Enabled = false;
                btnTijera.Enabled = false;
                btnJugar.Enabled = true;
                P = P + 1;
                tmrTemporizador.Stop();
            }
            lblContador1.Text = J.ToString();// Muestra el resultado en el contador de puntos del jugador
            lblContador2.Text = C.ToString(); //Muestra el resultado en el contador de puntos de la maquina
            lblContador3.Text = P.ToString(); //Muestar el resulado del total de partidas jugadas
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            pctJugador.Image = PiedraPapelTijera.Properties.Resources.descarga;
            Int32 Pi = R.Next(1, 4);
            tmrTemporizador.Start();
            T = 0;
            lblMensaje.Text = T.ToString();
            switch (Pi)
            {
                case 1:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.png_transparent_rock_paper_scissors_computer_icons_scissors_game_white_face_thumbnail;
                    lblResultado.Text = "Ganaste!!";
                    J = J + 1; 
                    break;
                case 2:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.descarga;
                    lblResultado.Text = "Empate!!";
                    break;
                case 3:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.images;
                    lblResultado.Text = "Perdiste!!";
                    C = C + 1; 
                    break;
            }
            if (J == 3)
            {
                lblResultado.Text = "Fin del juego ganaste!!";
                btnPapel.Enabled = false;
                btnPiedra.Enabled = false;
                btnTijera.Enabled = false;
                btnJugar.Enabled = true;
                P = P + 1;
                tmrTemporizador.Stop();
            }
            if (C == 3)
            {
                lblResultado.Text = "Fin del juego perdiste!!";
                btnPapel.Enabled = false;
                btnPiedra.Enabled = false;
                btnTijera.Enabled = false;
                btnJugar.Enabled = true;
                P = P + 1;
                tmrTemporizador.Stop();
            }
            lblContador1.Text = J.ToString();// Muestra el resultado en el contador de puntos del jugador
            lblContador2.Text = C.ToString(); //Muestra el resultado en el contador de puntos de la maquina
            lblContador3.Text = P.ToString(); //Muestar el resulado del total de partidas jugadas
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            pctJugador.Image = PiedraPapelTijera.Properties.Resources.images;
            Int32 Pi = R.Next(1, 4);
            tmrTemporizador.Start();
            T = 0;
            lblMensaje.Text = T.ToString();
            switch (Pi)
            {
                case 1:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.png_transparent_rock_paper_scissors_computer_icons_scissors_game_white_face_thumbnail;
                    lblResultado.Text = "Perdiste!!";
                    C = C + 1;
                    break;
                case 2:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.descarga;
                    lblResultado.Text = "Ganaste!!";
                    J = J + 1;
                    break;
                case 3:
                    pctMaquina.Image = PiedraPapelTijera.Properties.Resources.images;
                    lblResultado.Text = "Empate!!";
                    break;
            }

            if (J == 3)
            {
                lblResultado.Text = "Fin del juego ganaste!!";
                btnPapel.Enabled = false;
                btnPiedra.Enabled = false;
                btnTijera.Enabled = false;
                btnJugar.Enabled = true;
                P = P + 1;
                tmrTemporizador.Stop();
            }
            if (C == 3)
            {
                lblResultado.Text = "Fin del juego perdiste!!";
                btnPapel.Enabled = false;
                btnPiedra.Enabled = false;
                btnTijera.Enabled = false;
                btnJugar.Enabled = true;
                P = P + 1;
                tmrTemporizador.Stop();
            }
            lblContador1.Text = J.ToString();// Muestra el resultado en el contador de puntos del jugador
            lblContador2.Text = C.ToString(); //Muestra el resultado en el contador de puntos de la maquina
            lblContador3.Text = P.ToString(); //Muestar el resulado del total de partidas jugadas
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            btnPapel.Enabled = true;
            btnPiedra.Enabled = true;
            btnTijera.Enabled = true;
            lblContador1.Text = "0";
            lblContador2.Text = "0";
            lblContador3.Text = "0";
            J = 0;
            C = 0;
            lblResultado.Text = "";
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {
            if (T < 3)
            {
                T = T + 1;
                lblMensaje.Text = T.ToString();
            }
            else
            {
                tmrTemporizador.Stop();
                MessageBox.Show("Se termino tu tiempo");
            }
        }
    }
}
