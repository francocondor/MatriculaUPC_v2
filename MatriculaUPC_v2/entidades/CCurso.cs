using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC_v2.entidades
{
    public class CCurso
    {
        public String CodigoCurso { get; set; }
        public String NombreCurso { get; set; }
        public List<CAlumno> listaAlumnos { get; set; }

        public CCurso()
        {
            listaAlumnos = new List<CAlumno>();
        }
    }
}
