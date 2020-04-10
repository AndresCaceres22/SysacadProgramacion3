using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    public class alumnos : personas
    {
        public int legajo { get; set; }
        public string nacionalidad { get; set; }
        public carreras carrera { get; set; }

    }

}
