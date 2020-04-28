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
            this.Vidas = 5;
            this.Nivel = 1;

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

        public void PreguntaResuelta(Questions laPregunta)
        {
            this.YaResueltas.Add(laPregunta);
        }

        public void RestarVida()
        {
            this.Vidas -= 1;
        }
        public void NivelResuelto()
        {
            this.Nivel++;
        }
        public void CambiarPregunta()
        {
            RestarVida();
            laPregunta.ElegirPregunta(this.ElJuego);

        }

        public void ArrancarElJuego()
        {
            Questions.ArmarLaLista(ElJuego);
        }


        #endregion

    }
}
