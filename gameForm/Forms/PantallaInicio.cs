using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GameManager;

namespace Forms
{
    public partial class PantallaInicio : Form
    {
        Manager juego = new Manager();
        
        



        public PantallaInicio()
        {
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {
            
            start.Visible = false;
            botonAbD.Visible = true;
            botonAbI.Visible = true;
            botonCentro.Visible = true;
            botonArD.Visible = true;
            botonArI.Visible = true;
            labelVidas.Visible = true;
            imgCorazon.Visible = true;
            labelVidas.Text = this.juego.Vidas.ToString();
            labelVidas.BringToFront();
            PonerNivel(sender);
            ElegirPregunta(sender);
            ElegirBoton(sender);


        }

        private void ElegirBoton(object sender)
        {
            Random ordenDeBotones = new Random();

            switch (ordenDeBotones.Next(1, 5))
            {
                case 1:
                    this.formPregunta.Text = this.juego.LaPregunta.Pregunta;
                    this.botonArI.Text = this.juego.LaPregunta.Correcta;
                    this.botonArD.Text = this.juego.LaPregunta.Incorrecta1;
                    this.botonCentro.Text = this.juego.LaPregunta.Incorrecta2;
                    this.botonAbI.Text = this.juego.LaPregunta.Incorrecta3;
                    this.botonAbD.Text = this.juego.LaPregunta.Incorrecta4;
                    break;
                case 2:
                    this.formPregunta.Text = this.juego.LaPregunta.Pregunta;
                    this.botonArI.Text = this.juego.LaPregunta.Incorrecta1;
                    this.botonArD.Text = this.juego.LaPregunta.Correcta;
                    this.botonCentro.Text = this.juego.LaPregunta.Incorrecta3;
                    this.botonAbI.Text = this.juego.LaPregunta.Incorrecta4;
                    this.botonAbD.Text = this.juego.LaPregunta.Incorrecta2;
                    break;
                case 3:
                    this.formPregunta.Text = this.juego.LaPregunta.Pregunta;
                    this.botonArI.Text = this.juego.LaPregunta.Incorrecta2;
                    this.botonArD.Text = this.juego.LaPregunta.Incorrecta3;
                    this.botonCentro.Text = this.juego.LaPregunta.Correcta;
                    this.botonAbI.Text = this.juego.LaPregunta.Incorrecta1;
                    this.botonAbD.Text = this.juego.LaPregunta.Incorrecta4;
                    break;
                case 4:
                    this.formPregunta.Text = this.juego.LaPregunta.Pregunta;
                    this.botonArI.Text = this.juego.LaPregunta.Incorrecta3;
                    this.botonArD.Text = this.juego.LaPregunta.Incorrecta4;
                    this.botonCentro.Text = this.juego.LaPregunta.Incorrecta1;
                    this.botonAbI.Text = this.juego.LaPregunta.Correcta;
                    this.botonAbD.Text = this.juego.LaPregunta.Incorrecta2;
                    break;
                case 5:
                    this.formPregunta.Text = this.juego.LaPregunta.Pregunta;
                    this.botonArI.Text = this.juego.LaPregunta.Incorrecta4;
                    this.botonArD.Text = this.juego.LaPregunta.Incorrecta3;
                    this.botonCentro.Text = this.juego.LaPregunta.Incorrecta1;
                    this.botonAbI.Text = this.juego.LaPregunta.Incorrecta2;
                    this.botonAbD.Text = this.juego.LaPregunta.Correcta;
                    break;
            }


        }
        private void ElegirPregunta(object sender)
        {
            Random eligeIndice = new Random();

            this.juego.LaPregunta = this.juego.ElJuego[eligeIndice.Next(0, this.juego.ElJuego.Count-1)];

        }
        private void PonerNivel(object sender)
        {
            string text = String.Format("Nivel {0}", this.juego.Nivel);
            this.Text = text;
        }

        #region Cuando tocan el boton

        private void botonArI_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonArI.Text)
            {

                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            { 
                this.juego.Vidas--;
                labelVidas.Text = this.juego.Vidas.ToString();
            }
        }

        private void botonAbD_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonAbD.Text)
            {

                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                this.juego.Vidas--;
                labelVidas.Text = this.juego.Vidas.ToString();
            }
        }

        private void botonArD_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonArD.Text)
            {

                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                this.juego.Vidas--;
                labelVidas.Text = this.juego.Vidas.ToString();
            }
        }

        private void botonCentro_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonCentro.Text)
            {

                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                this.juego.Vidas--;
                labelVidas.Text = this.juego.Vidas.ToString();
            }
        }

        private void botonAbI_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonAbI.Text)
            {

                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                this.juego.Vidas--;
                labelVidas.Text = this.juego.Vidas.ToString();
            }
        }
#endregion
    }
}
