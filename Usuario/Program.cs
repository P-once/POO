using System;
using System.Collections.Generic;

namespace Usuario
{
    class CorreoE
    {
        string Correo;

        public CorreoE(string C)
        {
            Correo = C;
        }
        public string GetCorreo()
        {
            return Correo;
        }
    }

    class Usuario
    {
        string Nombre;
        List <CorreoE> Correos;

        public Usuario(string N)
        {
            Nombre = N;
            Correos = new List<CorreoE>(); 
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void AgregaCorreo(CorreoE C)
        {
            Correos.Add(C);
        }

        public void Print()
        {
            Console.WriteLine(Nombre);
            foreach(CorreoE C in Correos)
            {
                Console.WriteLine(C.GetCorreo());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Usuario P1 = new Usuario("Usuario");
            Console.WriteLine(P1.GetNombre());
            P1.AgregaCorreo(new CorreoE("Usuario@ejemplo.com"));
            P1.AgregaCorreo(new CorreoE("Usuario@gmail.com"));
            P1.Print();
        }
    }
}
