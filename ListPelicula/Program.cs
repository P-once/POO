using System;
using System.Collections.Generic;

namespace Pelicula
{
    public class Pelicula
    {   
        string Nombre;

        public Pelicula(string N)
        {
            Nombre = N;
        }
        public void Imprime()
        {
            Console.WriteLine(Nombre);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> Peliculas = new List<Pelicula>();

            Peliculas.Add(new Pelicula("Titanic"));
            Peliculas.Add(new Pelicula("Jojo Rabbit"));
            Peliculas.Add(new Pelicula("1917"));
            Peliculas.Add(new Pelicula("Avatar"));

            foreach(Pelicula P in Peliculas)
            {
            P.Imprime();
            }
        }
    }
}