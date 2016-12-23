using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion2.Model
{

    public class Alumno: Persona
    {
        public EstadosAlumno Estado { get; set; }
        public string Email { get; set; }
        public string NickName { get; private set; }

        public string ListaInasitencias () {
            return Inasitencias.ToString();
        }

        public override string ConstruirResumen()
        {
            return $"{NombreCompleto}, {NickName}, {Telefono}";
        }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string NombreCompleto
        {
            get
            {
                return base.NombreCompleto.ToUpper();
            }
        }



    }
}
