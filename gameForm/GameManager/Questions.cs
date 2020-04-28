using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public class Questions
    {
        private string pregunta;
        private string respCorrecta;
        private string respIncorrecta1;
        private string respIncorrecta2;
        private string respIncorrecta3;
        private string respIncorrecta4;

        #region Preguntas

        static Questions p01 = new Questions("¿Quien compuso Imagine?", "John", "Paul", "Ringo", "George", "Pete Best");
        static Questions p02 = new Questions("¿Que equipo salió campeón del torneo Nacional 1983?", "River", "Ferro", "Boca", "Velez", "Racing");
        static Questions p03 = new Questions("¿Cuál es el idioma más antiguo de los que sobreviven en Europa?", "Vasco", "Español", "Frances", "Inglés", "Catalán");
        static Questions p04 = new Questions("¿Cuánto duró la Guerra de los Cien Años?", "116", "100", "101", "90", "124");
        static Questions p05 = new Questions("¿Cuál es la lengua más hablada del mundo?", "Chino", "Inglés", "Español", "Ruso", "Arabe");
        static Questions p06 = new Questions("¿Cuál es el país europeo del que provienen las familias de la mayor parte de los habitantes de Argentina?", "Italia", "Alemania", "España", "Francia", "Inglaterra");
        static Questions p07 = new Questions("¿Cuál es la ciudad más poblada de África?", "El Cairo", "Ankara", "Nairobi", "Marrakech", "Tripoli");
        static Questions p08 = new Questions("¿Quién fue el director y a la vez protagonista de la película “Ciudadano Kane”?", "Orson Wells", "Martin Scorsese", "Alfred Hitchcock", "Woody Allen", "Tim Burton");
        static Questions p09 = new Questions("¿Cómo se llama la madre de Simba en la película de Disney “El Rey León”?", "Sarabi", "Nala", "Shenzi", "Kiara", "Zuri");
        static Questions p10 = new Questions("¿A qué banda de música metal pertenece el disco Master of Puppets?", "Metallica", "AC/DC", "KISS", "Led Zeppelin", "Megadeth");
        static Questions p11 = new Questions("¿Qué nombre tenía el caballo de Don Quijote de la Mancha?", "Rocinante", "Tornado", "Babieca", "Turfito", "Bucéfalo");
        static Questions p12 = new Questions("¿Alrededor de qué planeta orbitan los satélites Ganímedes, Calisto, Ío y Europa?", "Júpiter", "Saturno", "Urano", "Neptuno", "Marte");
        static Questions p13 = new Questions("¿Cómo se llama la planta a partir de la cual suele ser elaborado el tequila?", "Agave", "Ruda", "Pisco", "Enebro", "Centeno");
        static Questions p14 = new Questions("¿Qué deporte jugado con un bate y una pelota es el más popular en la India?", "Críquet", "Baseball", "Softball", "Polo", "Croquet");
        static Questions p15 = new Questions("¿Qué arte marcial es conocido como “el boxeo tailandés”?", "Muay Thai", "Kung Fu", "Karate", "MMA", "Taekwon-Do");
        static Questions p16 = new Questions("¿Cuál de los 7 enanitos no tenía barba?", "Mudito", "Gruñon", "Feliz", "Sabio", "Mocoso");
        static Questions p17 = new Questions("¿En qué ciudad vivía el Mago de Oz?", "Esmeralda", "Hopkins", "Gillikin", "Winkie", "Hogwarts");
        static Questions p18 = new Questions("¿Cuál es el dedo más sensible de la mano?", "Indice", "Meñique", "Anular", "Pulgar", "Del medio");
        static Questions p19 = new Questions("¿Cuál era la ciudad natal de Marco Polo?", "Venecia", "Roma", "Florencia", "Atenas", "Troya");
        static Questions p20 = new Questions("¿Qué país era la Galia para los romanos?", "Francia", "Alemania", "España", "Suiza", "Holanda");
        static Questions p21 = new Questions("¿En qué país está el río Po?", "Italia", "Japón", "Tailandia", "Madagascar", "Guyana");
        static Questions p22 = new Questions("¿Contra qué equipo jugó River Plate su primer partido en la B nacional de 2011?", "Chacarita", "Almagro", "Atlanta", "Platense", "Quilmes");
        static Questions p23 = new Questions("¿Cual de estos paises no posee el color rojo en su bandera?", "Somalia", "Egipto", "Iraq", "Iran", "Libia");
        static Questions p24 = new Questions("¿Cual de estas marcas no fabrica motocicletas?", "Ford", "BMW", "Suzuki", "Peugeot", "Yamaha");
        static Questions p25 = new Questions("¿Cual de estos actores ha ganado más de un Oscar como mejor actor?", "Marlon Brando", "Brad Pitt", "Nicolas Cage", "Johnny Depp", "Gary Oldman");
        static Questions p26 = new Questions("¿Quien fue el presidente más joven que tuvo Argentina?", "Avellaneda", "Perón", "Macri", "Illia", "Rivadavia");
        static Questions p27 = new Questions("¿Cual de estas provincias declaró su autonomía primero?", "Corrientes", "Santa Fé", "Buenos Aires", "Tucumán", "Cordoba");
        static Questions p28 = new Questions("¿Cuál de estos expresidentes argentinos NO tuvo más de un mandato presidencial?", "Sarmiento", "Roca", "Perón", "Yrigoyen", "CFK");
        static Questions p29 = new Questions("¿A la unión de rugby de qué provincia representan ''Los Dogos'' en el Campeonato Argentino de Rugby?", "Córdoba", "Buenos Aires", "Santa Fé", "Mendoza", "La Pampa");
        static Questions p30 = new Questions("¿Cuál de estos candidatos presidenciales tuvo menor cantidad de votos en las PASO 2019?", "Albarracín", "Biondini", "Espert", "del Caño", "Castañeira");
        static Questions p31 = new Questions("¿Cuál de estos canales ha emitido más veces la gala de premios Martin Fierro?", "El Trece", "Telefe", "Canal 9", "América", "Canal 7 TVP");
        static Questions p32 = new Questions("¿En qué año empezó a funcionar ''Clementina'' la primera computadora que llegó al país?", "1961", "1954", "1976", "1969", "1958");
        static Questions p33 = new Questions("¿Cuál de estas disciplinas le dió a Argentina su primera medalla de oro en juegos olímpicos?", "Polo", "Futbol", "Boxeo", "Tenis", "Natacion");
        static Questions p34 = new Questions("¿En cual de estos juegos olímpicos Argentina obtuvo más medallas(totales)?", "Londres 1948", "Atenas 2004", "Londres 2012", "Moscú 1980", "París 1924");
        static Questions p35 = new Questions("Durante la última dictadura militar cuál de estos personajes NO fué presidente?", "Massera", "Videla", "Viola", "Galtieri", "Bignone");
        static Questions p36 = new Questions("¿Cuál de estos artistas ganó el primer premio Gardel de Oro?", "Sandro", "Mercedes Sosa", "Jairo", "Babasonicos", "Cerati");
        static Questions p37 = new Questions("¿Cuál de estos artistas ha ganado más veces el premio Gardel de Oro?", "Charly Garcia", "Luis Alberto Spinetta", "Gustavo Cerati", "La Bersuit", "Leon Gieco");
        static Questions p38 = new Questions("¿Cuál de estas aplicaciones tiene mas descargas en el Play Store de android?", "Instagram", "Vimeo", "Snapchat", "Twitter", "Youtube");
        static Questions p39 = new Questions("¿Cuál de estos personajes aparece en la serie animada Los Simpsons con 5 dedos en las manos?", "Jesús", "Yao Ming", "Barack Obama", "Paul McCartney", "Ronaldo");
        static Questions p40 = new Questions("¿En que país comenzó la epidemia del coronavirus?", "China", "Japón", "Filipinas", "India", "Mongolia");
        static Questions p41 = new Questions("¿En que país comenzó la epidemia del coronavirus?", "China", "Japón", "Filipinas", "India", "Mongolia");
        static Questions p42 = new Questions("¿Contra qué equipo realizó Marcelo Gallardo su debut como director técnico de River Plate?", "Ferro", "Huracán", "Estudiantes LP", "Olimpo", "Vélez");
        static Questions p43 = new Questions("¿En cuál de estos equipos NO jugó Maradona?", "Real Madrid", "Boca", "Nápoli", "Barcelona", "Newell's");
        static Questions p44 = new Questions("¿Cuál de estas bandas NO participó de la primera edición del Cosquin Rock en el año 2001?", "Callejeros", "Dividos", "Kapanga", "Los Piojos", "Las Pelotas");
        static Questions p45 = new Questions("¿En qué año falleció Lady Di?", "1997", "1996", "1999", "1998", "1993");
        static Questions p46 = new Questions("¿Cuál de estos barrios pertenece a la Ciudad Autónoma de Buenos Aires?", "Villa Mitre", "San Martin", "Lanús", "Munro", "Florida");
        static Questions p47 = new Questions("¿Cuál de estos bancos NO pertence a la red Banelco?", "Credicoop", "Galicia", "Comafi", "Macro", "Patagonia");
        static Questions p48 = new Questions("¿Cuál de estas empresas no pertence (aún) a Elon Musk?", "Google", "Tesla", "Space X", "Neuralink", "Hyperloop");
        static Questions p49 = new Questions("¿De cuál de estas bandas fué bajista Ricardo Iorio?", "Hermética", "Rata Blanca", "Malón", "Riff", "Sui Generis");
        static Questions p50 = new Questions("¿Cuantas estrellas conforman el guerrero de la constelacion de Orion?", "21", "3", "17", "32", "45");
        static Questions p51 = new Questions("¿Cuantos kilos pesa 1 millon de monedas de 1 peso (borde plateado y centro dorado)?", "6.350 Kg.", "4.652 Kg.", "5.861 Kg.", "7.459 Kg.", "1.358 Kg.");
        static Questions p52 = new Questions("¿En que año se emitio el primer capitulo de Los Simpsons?", "1989", "1990", "1988", "1992", "1985");
        static Questions p53 = new Questions("¿En que año fue la explosion de la Central Nuclear de Chernobyl?", "1986", "1981", "1985", "1982", "1979");
        static Questions p54 = new Questions("¿Cuantos huesos tiene un ser humano adulto?", "206", "190", "215", "352", "1.952");
        static Questions p55 = new Questions("¿Cual de estos paises limitrofes tiene mas kilometros de frontera con Argentina?", "Chile", "Uruguay", "Brasil", "Bolivia", "Paraguay");
        static Questions p56 = new Questions("¿Cual de estas bebidas posee mayor graduacion alcoholica?", "Absenta", "Cerveza", "Fernet", "Vino", "Sake");
        static Questions p57 = new Questions("¿Cual de estos exministros de economia duro mas tiempo en el cargo?", "Cavallo", "Lavagna", "Boudou", "Lousteau", "Capitanich");
        static Questions p58 = new Questions("¿Cuantos premios Oscar gano Brad Pitt hasta marzo 2020?", "2", "3", "5", "1", "4");
        static Questions p59 = new Questions("¿Cual de estos deportes tienen mas jugadores en cancha?", "Rugby", "Futbol", "Basquet", "Pato", "Handball");

        #endregion

        #region Constructores
        public Questions()
        {
            this.Pregunta = "";
            this.Correcta = "";
            this.Incorrecta1 = "";
            this.Incorrecta2 = "";
            this.Incorrecta3 = "";
            this.Incorrecta4 = "";
        }
        public Questions(string pregunta, string correcta, string incorrecta1, string incorrecta2, string incorrecta3, string incorrecta4)
        {
            this.Pregunta = pregunta;
            this.Correcta = correcta;
            this.Incorrecta1 = incorrecta1;
            this.Incorrecta2 = incorrecta2;
            this.Incorrecta3 = incorrecta3;
            this.Incorrecta4 = incorrecta4;
        }
        #endregion 

        #region Propiedades
        public string Pregunta
        {
            get
            {
                return this.pregunta;
            }
            set
            {
                this.pregunta = value;
            }
        }
        public string Correcta
        {
            get
            {
                return this.respCorrecta;
            }
            set
            {
                this.respCorrecta = value;
            }
        }
        public string Incorrecta1
        {
            get
            {
                return this.respIncorrecta1;
            }
            set
            {
                this.respIncorrecta1 = value;
            }
        }
        public string Incorrecta2
        {
            get
            {
                return this.respIncorrecta2;
            }
            set
            {
                this.respIncorrecta2 = value;
            }
        }
        public string Incorrecta3
        {
            get
            {
                return this.respIncorrecta3;
            }
            set
            {
                this.respIncorrecta3 = value;
            }
        }
        public string Incorrecta4
        {
            get
            {
                return this.respIncorrecta4;
            }
            set
            {
                this.respIncorrecta4 = value;
            }
        }
        #endregion

        #region Metodos

        public static List<Questions> IniciarJuego(List<Questions> laLista, Questions laPregunta)
        {
            laLista.Add(laPregunta);
            return laLista;
        }

        public static void ArmarLaLista(List<Questions> laLista)
        {
            IniciarJuego(laLista, p01);
            IniciarJuego(laLista, p02);
            IniciarJuego(laLista, p03);
            IniciarJuego(laLista, p04);
            IniciarJuego(laLista, p05);
            IniciarJuego(laLista, p06);
            IniciarJuego(laLista, p07);
            IniciarJuego(laLista, p08);
            IniciarJuego(laLista, p09);
            IniciarJuego(laLista, p10);
            IniciarJuego(laLista, p11);
            IniciarJuego(laLista, p12);
            IniciarJuego(laLista, p13);
            IniciarJuego(laLista, p14);
            IniciarJuego(laLista, p15);
            IniciarJuego(laLista, p16);
            IniciarJuego(laLista, p17);
            IniciarJuego(laLista, p18);
            IniciarJuego(laLista, p19);
            IniciarJuego(laLista, p20);
            IniciarJuego(laLista, p21);
            IniciarJuego(laLista, p22);
            IniciarJuego(laLista, p23);
            IniciarJuego(laLista, p24);
            IniciarJuego(laLista, p25);
            IniciarJuego(laLista, p26);
            IniciarJuego(laLista, p27);
            IniciarJuego(laLista, p28);
            IniciarJuego(laLista, p29);
            IniciarJuego(laLista, p30);
            IniciarJuego(laLista, p31);
            IniciarJuego(laLista, p32);
            IniciarJuego(laLista, p33);
            IniciarJuego(laLista, p34);
            IniciarJuego(laLista, p35);
            IniciarJuego(laLista, p36);
            IniciarJuego(laLista, p37);
            IniciarJuego(laLista, p38);
            IniciarJuego(laLista, p39);
            IniciarJuego(laLista, p40);
            IniciarJuego(laLista, p41);
            IniciarJuego(laLista, p42);
            IniciarJuego(laLista, p43);
            IniciarJuego(laLista, p44);
            IniciarJuego(laLista, p45);
            IniciarJuego(laLista, p46);
            IniciarJuego(laLista, p47);
            IniciarJuego(laLista, p48);
            IniciarJuego(laLista, p49);
            IniciarJuego(laLista, p50);
            IniciarJuego(laLista, p51);
            IniciarJuego(laLista, p52);
            IniciarJuego(laLista, p53);
            IniciarJuego(laLista, p54);
            IniciarJuego(laLista, p55);
            IniciarJuego(laLista, p56);
            IniciarJuego(laLista, p57);
            IniciarJuego(laLista, p58);
            IniciarJuego(laLista, p59);
        }

        public Questions ElegirPregunta(List<Questions> laLista)
        {
            Questions retorno = new Questions();
            Random indice = new Random();

            retorno = laLista[indice.Next(0, laLista.Count())];

            return retorno;
        }



        #endregion

    }
}
