using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion2.Model
{
    public interface IEnteInstituto
    {
        string CodigoInterno { get; set; }

        string ConstruirLlaveSecreta(string nombreEnte);
    }
}
