using System;

namespace Pelicula
{
    public class Pelicula
    {
        string Nombre;
        string Director;
        string Pais;
        int Año;

        public Pelicula(string N, int A)
        {
            Nombre = N;
            Año = A;
        }
        public void Imprime()
        {
            Console.WriteLine(Nombre + " " + Año);
        }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> Peliculas = new List<Pelicula>();
            Pelicula.Add(new Pelicula("Titanic", 1997));
            Pelicula.Add(new Pelicula("Jojo Rabbit", 2019));
            Pelicula.Add(new Pelicula("1917", 2019));

            foreach(string P in Pelicula)
            console.writline(P.Imprime);
        }
    }
}
