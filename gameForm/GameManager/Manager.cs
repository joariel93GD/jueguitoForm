using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManager;

namespace GameManager
{
    public class Manager
    {


        private List<Questions> elJuego;
        private List<Questions> yaResueltas;
        private Questions laPregunta;
        private int vidas;
        private int nivel;

        #region Constructor

        public Manager()
        {
            this.elJuego = new List<Questions>();
            this.yaResueltas = new List<Questions>();
            this.laPregunta = new Questions();
            this.vidas = 5;
            this.nivel = 1;
            Questions.ArmarLaLista(this.ElJuego);
        }

        #endregion

        #region Propiedades
        public List<Questions> ElJuego
        {
            get
            {
                return this.elJuego;
            }
        }

        public List<Questions> YaResueltas
        {
            get
            {
                return this.yaResueltas;
            }
        }

        public Questions LaPregunta
        {
            get
            {
                return this.laPregunta;
            }
            set
            {
                this.laPregunta = value;
            }
        }
        public int Vidas
        {
            get
            {
                return this.vidas;
            }
            set
            {
                this.vidas = value;
            }
        }
        public int Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Agrega la pregunta resuelta a la lista de resueltas
        /// </summary>
        public void PreguntaResuelta(Questions laPregunta)
        {
            this.YaResueltas.Add(laPregunta);
        }

        /// <summary>
        /// Resta una vida
        /// </summary>
        public void RestarVida()
        {
            this.Vidas --;
        }

        /// <summary>
        /// Suma un nivel
        /// </summary>
        public void NivelResuelto()
        {
            this.Nivel++;
        }


        /// <summary>
        /// Inicializa el juego
        /// </summary>
        public void ArrancarElJuego()
        {
            Questions.ArmarLaLista(ElJuego);
        }


        #endregion

    }
}
