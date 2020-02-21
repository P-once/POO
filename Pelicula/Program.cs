using System;

namespace Pelicula
{
    public class Pelicula
    {
        public string Nombre;
        public string Director;
        public string Pais;
        public int Año;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula Peli1 = new Pelicula();
            Peli1.Nombre = "Jojo Rabbit";
            Peli1.Año = 2019;

            Pelicula Peli2 = new Pelicula();
            Peli2.Nombre = "Titanic";
            Peli2.Año = 1997;

            Console.WriteLine(Peli1.Nombre);
            Console.WriteLine(Peli1.Año);
            Console.WriteLine(Peli2.Nombre);
            Console.WriteLine(Peli2.Año);
        }
    }
}
