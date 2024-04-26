using MatriculaUPC_v2.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC_v2.repositorios
{
    public class CursoRepository
    {
        public List<CCurso> listaCursos { get; set; }

        public CursoRepository()
        {
            listaCursos = new List<CCurso>();
        }

        public void AgregarCurso(CCurso curso)
        {
            listaCursos.Add(curso);
        }

        public List<CCurso> ObtenerCursos()
        {
            return listaCursos;
        }
        public List<CAlumno> ObtenerAlumnosDeCurso(String codigoCurso)
        {
            CCurso curso = listaCursos.Find(c => c.CodigoCurso == codigoCurso);
            return curso.listaAlumnos;
        }

        public void AgregarAlumnoACurso(String codigoCurso, int tiu, String nombreAlumno)
        {
            CCurso curso = listaCursos.Find(c => c.CodigoCurso == codigoCurso);
            CAlumno alumno = new CAlumno();
            alumno.NombreCompleto = nombreAlumno;
            alumno.TIU = tiu;
            curso.listaAlumnos.Add(alumno);
        }


    }
}
