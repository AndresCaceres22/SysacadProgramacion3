using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    class inscripcion_a_examenes
    {
        public alumnos alumno { get; set; }
        public materias materia { get; set; }
        public DateTime fecha_examen { get; set; }
        public tipo_examen examen { get; set; }
        public turnos turno { get; set; }
        public aulas aula { get; set; }
    }

}
