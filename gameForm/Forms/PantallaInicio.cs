using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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

        /// <summary>
        /// Pone visible los controladores necesarios para el juego y muestra la primera pregunta
        /// </summary>
        private void start_Click(object sender, EventArgs e)
        {
            lblInstrCambiarPreg.Visible = false;
            lblInstrucciones.Visible = false;
            btnOkEmpecemos.Visible = false;
            btnInstrucciones.Visible = false;
            start.Visible = false;
            botonAbD.Visible = true;
            botonAbI.Visible = true;
            botonCentro.Visible = true;
            botonArD.Visible = true;
            botonArI.Visible = true;
            btnCambiarPreg.Visible = true;
            labelVidas.Visible = true;
            imgCorazon.Visible = true;
            labelVidas.Text = this.juego.Vidas.ToString();
            labelVidas.BringToFront();
            PonerNivel(sender);
            ElegirPregunta(sender);
            ElegirBoton(sender);


        }

        /// <summary>
        /// Elige a que boton le pondra la pregunta correcta
        /// </summary>
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
      
        /// <summary>
        /// Selecciona una pregunta de la lista
        /// </summary>
        private void ElegirPregunta(object sender)
        {
            Random eligeIndice = new Random();
            bool flag = default;
           
            while (flag == false) 
            {
                flag = true;
                this.juego.LaPregunta = this.juego.ElJuego[eligeIndice.Next(0, this.juego.ElJuego.Count - 1)];

                foreach (Questions item in this.juego.YaResueltas)
                {
                    if (item == this.juego.LaPregunta)
                    { 
                        flag = false;
                        break;
                    }
                }

            }
        }

        /// <summary>
        /// Escribe en la barra principal el nivel actual del juego
        /// </summary>
        private void PonerNivel(object sender)
        {
            string text = String.Format("Nivel {0}", this.juego.Nivel);
            this.Text = text;
        }
        private void PonerVidas(object sender)
        {
            this.labelVidas.Text = this.juego.Vidas.ToString();
        }
        #region Cuando tocan el boton
        /// <summary>
        /// Revisa si el boton clickeado tiene la respuesta correcta o incorrecta
        /// </summary>
        private void botonArI_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonArI.Text)
            {
                this.juego.PreguntaResuelta(this.juego.LaPregunta);
                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                if (this.juego.Vidas > 1)
                {
                    MostrarLosNo(sender);
                    this.juego.Vidas--;
                    PonerVidas(sender);
                }
                else
                {
                    LanzarGameOver(sender);
                }
            }
        }
        /// <summary>
        /// Revisa si el boton clickeado tiene la respuesta correcta o incorrecta
        /// </summary>
        private void botonAbD_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonAbD.Text)
            {
                this.juego.PreguntaResuelta(this.juego.LaPregunta);
                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                if (this.juego.Vidas > 1)
                {
                    MostrarLosNo(sender);
                    this.juego.Vidas--;
                    PonerVidas(sender);
                }
                else
                {
                    LanzarGameOver(sender);
                }
            }
        }

        /// <summary>
        /// Revisa si el boton clickeado tiene la respuesta correcta o incorrecta
        /// </summary>
        private void botonArD_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonArD.Text)
            {
                this.juego.PreguntaResuelta(this.juego.LaPregunta);
                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                if (this.juego.Vidas > 1)
                {
                    MostrarLosNo(sender);
                    this.juego.Vidas--;
                    PonerVidas(sender);
                }
                else
                {
                    LanzarGameOver(sender);
                }
            }
        }
        /// <summary>
        /// Revisa si el boton clickeado tiene la respuesta correcta o incorrecta
        /// </summary>
        private void botonCentro_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonCentro.Text)
            {
                this.juego.PreguntaResuelta(this.juego.LaPregunta);
                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                if (this.juego.Vidas > 1)
                {
                    MostrarLosNo(sender);
                    this.juego.Vidas--;
                    PonerVidas(sender);
                }
                else
                {
                    LanzarGameOver(sender);
                }
            }
        }
        /// <summary>
        /// Revisa si el boton clickeado tiene la respuesta correcta o incorrecta
        /// </summary>
        private void botonAbI_Click(object sender, EventArgs e)
        {
            if (this.juego.LaPregunta.Correcta == this.botonAbI.Text)
            {
                this.juego.PreguntaResuelta(this.juego.LaPregunta);
                this.juego.Nivel++;
                PonerNivel(sender);
                ElegirPregunta(sender);
                ElegirBoton(sender);
            }
            else
            {
                if (this.juego.Vidas > 1)
                {
                    this.juego.Vidas--;
                    PonerVidas(sender);
                }
                else
                {
                    LanzarGameOver(sender);
                }

            }
        }
        #endregion

        /// <summary>
        /// Revisa si el jugador tiene vidas para cambiar por una nueva pregunta
        /// </summary>
        private void btnCambiarPreg_Click(object sender, EventArgs e)
        {
            if(this.juego.Vidas>1)
            {
                ElegirPregunta(sender);
                ElegirBoton(sender);
                this.juego.Vidas--;
                PonerVidas(sender);
            }
            else
            {
                LanzarGameOver(sender);
            }

        }

        /// <summary>
        /// Activa la visibilidad de las instruccines del juego
        /// </summary>
        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            btnInstrucciones.Visible = false;
            lblInstrucciones.Visible = true;
            lblInstrCambiarPreg.Visible = true;
            btnOkEmpecemos.Visible = true;
            btnCambiarPreg.Visible = true;
            labelVidas.Visible = true;
            imgCorazon.Visible = true;
            labelVidas.Text = this.juego.Vidas.ToString();
        }

        /// <summary>
        /// Arranca el juego desde las instrucciones
        /// </summary>
        private void btnOkEmpecemos_Click(object sender, EventArgs e)
        {
            start_Click(sender, e);
        }

        private void LanzarGameOver (object sender)
        {
            this.juego.Nivel = 1;
            this.juego.Vidas = 5;
            PonerNivel(sender);
            PonerVidas(sender);
            ElegirPregunta(sender);
            ElegirBoton(sender);
            
            new GameOver().ShowDialog();
        }
        private void MostrarLosNo(object sender)
        {
         
            this.no1.Visible = true;    
            
            this.no1.Visible = false;
            this.no2.Visible = true;

            this.no2.Visible = false;
            this.no3.Visible = true;

            this.no3.Visible = false;
            this.no4.Visible = true;

            this.no4.Visible = false;
            this.no5.Visible = true;

            this.no5.Visible = false;
        }
        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
