using System;

namespace Pelicula
{
    public class Pelicula
    {
        string Nombre;
        string Director;
        string Pais;
        int Año;

        public Pelicula()
        {
            Nombre = "No nombre";
        }

        public void SetPelicula(string N, int A)
        {
            Nombre = N;
            Año = A;
        }

        public void Imprime()
        {
            Console.WriteLine(Nombre + " " + Año);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula Peli1 = new Pelicula();
            Pelicula Peli2 = new Pelicula();

            Peli1.SetPelicula("Titanic", 1997);
            Peli2.SetPelicula("Jojo Rabbit", 2019);

            Peli1.Imprime();
            Peli2.Imprime();
        }
    }
}
