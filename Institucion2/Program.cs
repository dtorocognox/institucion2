using Institucion2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] lista = new Persona[3];

            lista[0] = new Alumno("Xxxxx", "Xxxxx") { Id = 1, Telefono = "123", Email="dtoro@cgonox.com"};

            lista[1] = new Profesor() { Id = 2, Nombre = "David", Apellido = "Toro", Telefono = "123", Catedra="Programación"};

            lista[2] = new Profesor() { Id = 3, Nombre = "William", Apellido = "Torvalds", Edad= 25, Telefono = "123", Catedra="Algebra"};


            //Console.WriteLine(Persona.ContadorPersonas);

            //Console.WriteLine(alumno1.ConstruirResumen());
            //Console.WriteLine(profesor1.ConstruirResumen());

            foreach(Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine($"{p.ConstruirResumen()}");
            }


            Console.ReadLine();



        }
    }
}
