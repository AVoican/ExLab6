using System;

namespace ExLab6
{/// <summary>
/// Un dulap are trei caracteristici: lungime latime si inaltime. Dulapul va avea o metoda care va calcula volumui acestuia.
/// Folositi o clasa care va modela un dulap.
/// -Clasa va avea 3 campuri private intergi:lungime, latime si inaltime.
/// -Cele trei campuri vor fi initializate cu ajutorul consstructorului.
/// -Scrieti o metoda care va calcula volumul dulapului pe baza celor 3 campuri.
/// Instantiati un dulap in functia Main, apelati metoda de calcul a volumui si afisati rezultatul.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dulap dulap = new Dulap();
            Console.WriteLine($"Volumul dulapului creat este de {dulap.CalculeazaVolumulDulapului()}m3.");
        }

        class Dulap
        {
            public double lungime;
            public double latime;
            public double inaltime;

            public Dulap()
            {
                lungime = 7;
                latime = 8;
                inaltime = 2;
            }

            public double CalculeazaVolumulDulapului()
            {
                double volumulDulapului = lungime * latime * inaltime;
                return volumulDulapului;
            }
        }
    }
}
