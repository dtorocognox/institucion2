using Institucion2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion2.Misc
{
    public class TrasmisorDeDatos
    {
        public delegate string Formateer(string input);

        public void FormatearYEnviar(IEnteInstituto ente, Formateer localFormatter, string nombre)
        {
            var rawString = $"{ente.CodigoInterno}:{ente.ConstruirLlaveSecreta(nombre)}";

            rawString = localFormatter(rawString);

            Enviar(rawString);
        }

        private void Enviar(string rawString)
        {
            Console.WriteLine("Transmisión de datos " + rawString);

            if(InformacionEnviada != null)
            {
                InformacionEnviada(this, new EventArgs());
            }
        }

        public event EventHandler InformacionEnviada;
        //public string MyFormatter(string input)
        //{

        //}
    }
}
