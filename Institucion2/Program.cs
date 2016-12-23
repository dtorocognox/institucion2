using Institucion2.DataAccess;
using Institucion2.Misc;
using Institucion2.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Institucion2
{
    class Program
    {
        static void Main(string[] args)
        {



            var listaProfesores = new List<Profesor>();



            //string[] lineas = File.ReadAllLines("../../Misc/TrasmisorDeDatos.cs");
            string[] lineas = File.ReadAllLines("./Files/Profesores.txt");

            foreach (var L in lineas)
            {
                Console.WriteLine(L);
            }


            Console.ReadKey();

            int localId = 0;

            foreach (var linea in lineas)
            {
                listaProfesores.Add(new Profesor() { Nombre = linea, Id = localId++ });
            }

            var db = new InstitucionDB();

            db.Profesores.AddRange(listaProfesores);
            db.SaveChanges();

            var subconjunto = from prof in db.Profesores
                              where prof.Nombre.StartsWith("J")
                              select prof;

            foreach (var item in subconjunto)
            {
                item.CodigoInterno = "Strat with J";
                Console.WriteLine(item.Nombre);
            }

            db.SaveChanges();


            var profesorBorrable = from p in db.Profesores
                                   where profesorBorrable.Nombre.


            Console.ReadKey();

            var archivo = File.Open("profesoresBinarios.bin", FileMode.OpenOrCreate);

            var binFile = new BinaryWriter(archivo);

            foreach (var profe in listaProfesores)
            {
                var bytesNombre = Encoding.UTF8.GetBytes(profe.Nombre);
                archivo.Write(bytesNombre, 0, bytesNombre.Length);

                binFile.Write(profe.Nombre);
                binFile.Write(profe.Id);
            }


            binFile.Close();
            archivo.Close();


        
            Console.ReadKey();

            var profesor = new Profesor() {Id= 123, Nombre="Mateo", Apellido="Pereira", CodigoInterno="PROFESOR SMART" };

            var transmitter = new TrasmisorDeDatos();

            transmitter.FormatearYEnviar(profesor, formatter, "Alextroio");

            transmitter.InformacionEnviada += Transmitter_InformacionEnviada;




            Persona[] lista = new Persona[3];

            lista[0] = new Alumno("Xxxxx", "Xxxxx") { Id = 1, Telefono = "123", Email = "dtoro@cgonox.com" };

            lista[1] = new Profesor() { Id = 2, Nombre = "David", Apellido = "Toro", Telefono = "123", Catedra = "Programación" };

            lista[2] = new Profesor() { Id = 3, Nombre = "William", Apellido = "Torvalds", Edad = 25, Telefono = "123", Catedra = "Algebra" };


            //Console.WriteLine(Persona.ContadorPersonas);

            //Console.WriteLine(alumno1.ConstruirResumen());
            //Console.WriteLine(profesor1.ConstruirResumen());

            foreach (Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine($"{p.ConstruirResumen()}");

                IEnteInstituto ente = p;
                ente.ConstruirLlaveSecreta("Hola");
            }

            Console.WriteLine("S T R U C T S");
            CursoStruct c = new CursoStruct(70);
            c.Curso = "101-B";

            var nuevoC = new CursoStruct();
            nuevoC.Curso = "564-A";

            var cursoFreak = c;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"Curso c = {c.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreak.Curso}");

            Console.WriteLine("C L A S S E S");

            CursoClass c_class = new CursoClass(70);
            c_class.Curso = "101-B";

            var nuevoCc_class = new CursoStruct();
            nuevoCc_class.Curso = "564-A";

            var cursoFreakc_class = c_class;
            cursoFreakc_class.Curso = "666-G";

            Console.WriteLine($"Curso c = {c_class.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreakc_class.Curso}");

            Console.WriteLine("E N U M E R A C I O N E S");

            var alumnoEst = new Alumno("Xxxxx", "Xxxxx")
            {
                Id = 22,
                Edad = 25,
                Telefono = "123",
                Email = "dtoro@cgonox.com",
                Estado = EstadosAlumno.Activo
            };

            Persona personaX = alumnoEst;
            Console.WriteLine("Estados alumno " + alumnoEst.Estado);

            Console.WriteLine($"Tipo {typeof(EstadosAlumno)}");
            Console.WriteLine($"Tipo {typeof(Alumno)}");
            Console.WriteLine($"Tipo {alumnoEst.GetType()}");
            Console.WriteLine($"Tipo {personaX.GetType()}");
            Console.WriteLine($"Nombre {nameof(Alumno)}");
            Console.WriteLine($"Tamaño {sizeof(int)}");

            Console.ReadLine();

            ArrayList listaPersonas = new ArrayList();

            Persona[] david = new Persona[5];

            listaPersonas.Add(new Profesor() { Edad = 25 });
            listaPersonas.Add("3");

            Console.WriteLine((listaPersonas[0] as Persona).Edad);
            Console.WriteLine(listaPersonas[1]);
            Console.WriteLine(listaPersonas.Count);
            Console.ReadLine();

            List<Persona> listaPersonas2 = new List<Persona>();

            listaPersonas2.Add(new Alumno("Pedro", "Berrio") {Id = 123 });


            Class1 c1 = new Class1();
            Console.WriteLine(c1.LocalIPAddress());
            Console.ReadKey();
        }

        private static void Transmitter_InformacionEnviada(object sender, EventArgs e)
        {
            Console.WriteLine("Transformación de Información");
        }

        private static string formatter(string input)
        {
            byte[] stringBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(stringBytes);
        }
    }
}
