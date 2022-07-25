using System;

namespace Ex2Lab6
{
    class Program
    {
        /// <summary>
        /// Scrieti un program care va modela un autoturism. Un autoturism va avea o marca(string), un numar de inmatriculare(string)
        /// si o capacitate cilindrica(int).
        /// Autoturismul va avea:
        /// -Campurile corespunzaoare caracteristicilor autoturismului
        /// -Un constructor care va initializa campurile acestuia
        /// -O metoda "Tiparire" care va afisa pe consola descrierea acestuia sub forma: "marca, Nr inmatriculare, capacitate cilindirca".
        /// Folositi: Clase, campuri, metode, modificatori de acces adecvati, comentarii xml pentru metode.
        /// Creati doa obiecte in functia Main si tipariti caracteristicile.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Autoturism masina1 = new Autoturism("Bemve","SB 01 BOSS", 2000);
            Autoturism masina2 = new Autoturism("Mertan", "SB 01 ION", 3498);

            masina1.Tipareste();
            masina2.Tipareste();

        }
        /// <summary>
        /// Modeleaza un autoturism.
        /// </summary>
        class Autoturism
        {
            private readonly string marca;
            private readonly string numarInmatriculare;
            private readonly int capacitateCilindrica;
            /// <summary>
            /// Construieste autoturismul cu parametrii dati.
            /// </summary>
            /// <param name="marca"></param>
            /// <param name="numarInmatriculare"></param>
            /// <param name="capacitateCilindrica"></param>
            public Autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
            {
                this.marca = marca;
                this.numarInmatriculare = numarInmatriculare;
                this.capacitateCilindrica = capacitateCilindrica;
            }
            /// <summary>
            /// Afiseaza caracteristicile autoturismului in consola.
            /// </summary>
            public void Tipareste()
            {
                Console.WriteLine($"{this.marca} {this.numarInmatriculare} {this.capacitateCilindrica}");
            }
        }
    }
}
