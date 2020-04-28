using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager;

namespace Forms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaInicio());


            Manager elJuego = new Manager();
            elJuego.ArrancarElJuego();
            Random ordenDeBotones = new Random();
            elJuego.LaPregunta.ElegirPregunta(elJuego.ElJuego);

            PantallaInicio form = new PantallaInicio();
            switch (ordenDeBotones.Next(1, 5))
            {
                case 1:
                    form.botonArI.Text = elJuego.LaPregunta.Correcta;
                    botonArD.Text = elJuego.LaPregunta.Incorrecta1;
                    botonCentro.Text = elJuego.LaPregunta.Incorrecta2;
                    botonAbI.Text = elJuego.LaPregunta.Incorrecta3;
                    botonAbD.Text = elJuego.LaPregunta.Incorrecta4;
                    break;
                case 2:
                    botonArI.Text = elJuego.LaPregunta.Incorrecta1;
                    botonArD.Text = elJuego.LaPregunta.Correcta;
                    botonCentro.Text = elJuego.LaPregunta.Incorrecta3;
                    botonAbI.Text = elJuego.LaPregunta.Incorrecta4;
                    botonAbD.Text = elJuego.LaPregunta.Incorrecta2;
                    break;
                case 3:
                    botonArI.Text = elJuego.LaPregunta.Incorrecta2;
                    botonArD.Text = elJuego.LaPregunta.Incorrecta3;
                    botonCentro.Text = elJuego.LaPregunta.Correcta;
                    botonAbI.Text = elJuego.LaPregunta.Incorrecta1;
                    botonAbD.Text = elJuego.LaPregunta.Incorrecta4;
                    break;
                case 4:
                    botonArI.Text = elJuego.LaPregunta.Incorrecta3;
                    botonArD.Text = elJuego.LaPregunta.Incorrecta4;
                    botonCentro.Text = elJuego.LaPregunta.Incorrecta1;
                    botonAbI.Text = elJuego.LaPregunta.Correcta;
                    botonAbD.Text = elJuego.LaPregunta.Incorrecta2;
                    break;
                case 5:
                    botonArI.Text = elJuego.LaPregunta.Incorrecta4;
                    botonArD.Text = elJuego.LaPregunta.Incorrecta3;
                    botonCentro.Text = elJuego.LaPregunta.Incorrecta1;
                    botonAbI.Text = elJuego.LaPregunta.Incorrecta2;
                    botonAbD.Text = elJuego.LaPregunta.Correcta;
                    break;


            }
        }
    }
}
