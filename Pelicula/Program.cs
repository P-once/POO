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

        public void SetNombre(string N)
        {
            Nombre = N;
        }

        public void SetAño(int A)
        {
            Año = A;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public int GetAño()
        {
            return Año;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelicula Peli1 = new Pelicula();
            Peli1.SetNombre("Jojo Rabbit");
            Peli1.SetAño(2019);

            Pelicula Peli2 = new Pelicula();
            Peli2.SetNombre("Titanic");
            Peli2.SetAño(1997);

            Console.WriteLine("{0}({1})", Peli1.GetNombre(), Peli1.GetAño());
            Console.WriteLine("{0}({1})", Peli2.GetNombre(), Peli2.GetAño());
        }
    }
}
