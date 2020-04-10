using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysacad
{
    class comision
    {
        public inscripcion_a_materias inscripcion_a_materia { get; set; }
        public docentes docente { get; set; }
        public aulas aula { get; set; }
        public turnos turno { get; set; }
        public carreras carrera { get; set; }
        public string dia_horario { get; set; }
        public DateTime fecha_inicio { get; set; }
    }

}
