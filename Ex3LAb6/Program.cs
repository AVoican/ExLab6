using System;

namespace Ex3LAb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Elev elev1 = new Elev("Voican", "Andrei", new int[] { 9 , 9 , 9 });
            Elev elev2 = new Elev("Girjoaba","Radu", new int[] { 5 , 5 , 5 });
            Elev elev3 = new Elev("Tatu","Tiberiu",new int[] { 7, 7, 7 });
            
            Elev[] listaElevi = { elev1, elev2, elev3};

            Catalog catalog = new Catalog( listaElevi);

            catalog.Tipareste();

            Console.WriteLine("Premiantul clasei este ");
            catalog.CalculeazaPremiantul().Tipareste();
        }
        /// <summary>
        /// modeleaza clasa "Catalog"
        /// </summary>
        class Catalog
        {
            private readonly string clasa = "a 10-a I";
            public Elev[] elevi;

            public Catalog(Elev[] elevi)
            {
                this.elevi = elevi;
            }
            /// <summary>
            /// returneaza elevul cu media cea mai mare
            /// </summary>
            /// <returns></returns>
            public Elev CalculeazaPremiantul()
            {
                double mediaMaxima = 0;
                double mediaElev = 0;
                Elev premiant = null;

                foreach (Elev elev in this.elevi)
                {

                    mediaElev = elev.MediaElevului();

                    if (mediaMaxima < mediaElev)
                    {
                        mediaMaxima = mediaElev;
                        premiant = elev;
                    }
                }

                return premiant;

            }
            /// <summary>
            /// tipareste datele din catalog
            /// </summary>
            public void Tipareste()
            {
                Console.WriteLine($"Clasa {this.clasa}.");
                foreach(Elev elev in this.elevi)
                {
                    elev.Tipareste();

                }
            }
        }

        class Elev
        {
            private readonly string nume;
            private readonly string prenume;
            public int[] note;

            public Elev(string nume,string prenume, int[] note)
            {
                this.nume = nume;
                this.prenume = prenume;
                this.note = note;
            }
            /// <summary>
            /// Calculeaza media unui elev.
            /// </summary>
            /// <param name="note"></param>
            /// <returns></returns>
            public double MediaElevului()
            {
                double media = 0;
                for(int i=0; i < this.note.Length; i++)
                {
                    media += this.note[i];
                }

                media /= this.note.Length;

                return media;
            }
            /// <summary>
            /// Tipareste datele unui elev.
            /// </summary>
            public void Tipareste()
            {
                Console.WriteLine($"{this.nume} {this.prenume}");
                
                for (int i = 0; i < this.note.Length; i++)
                {
                    Console.Write($"{this.note[i]}, ");
                }
                Console.WriteLine($" cu media: {this.MediaElevului()}");
            }
        }
    }
}
