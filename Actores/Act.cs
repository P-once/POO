using System;

namespace Pelicula
{
    public class Pelicula
    {
        string Nombre;
        string Director;
        string Pais;
        int Año;
        private List<Actor> Actores;

        public Pelicula()
        {
            Nombre = "No nombre";
        }

        public AgregarActor(string Act, int Año)
        {
            int AñoNacimiento;
            Actores.Add(new Actor(Act));
        }
        public Pelicula(string N, int A)
        {
            Nombre = N;
            Año = A;
            Actores = new List<Actor>();
        }

        public void ImprimeActores()
        {
            foreach (Actor A in Actores)
            {
                Console.WriteLine(Actores);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula Peli1 = new Pelicula("La La Land", 2016);
            Peli1.AgregarActor(new Actor("Ryan Gosling", 1980));
            Peli1.AgregarActor(new Actor("Emma Stone", 1988));

            Peli1.ImprimeActores();
        }
    }
}
