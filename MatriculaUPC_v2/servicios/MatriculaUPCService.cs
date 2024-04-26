using MatriculaUPC_v2.entidades;
using MatriculaUPC_v2.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC_v2.servicios
{
    public class MatriculaUPCService
    {
        CursoRepository cursoRepository;

        // Inicializa el repositorio de cursos
        public MatriculaUPCService()
        {
            cursoRepository = new CursoRepository();
        }

        public void AgregarCurso(String codigoCurso, String nombreCurso)
        {
            CCurso curso = new CCurso();
            curso.CodigoCurso = codigoCurso;
            curso.NombreCurso = nombreCurso;
            cursoRepository.AgregarCurso(curso);
        }

        public List<CCurso> ObtenerCursos()
        {
            return cursoRepository.ObtenerCursos();
        }

        public void AgregarAlumnoACurso(String codigoCurso, int tiu, String nombreAlumno)
        {
            cursoRepository.AgregarAlumnoACurso(codigoCurso, tiu, nombreAlumno);
        }


        public List<CAlumno> ObtenerAlumnosDeCurso(String codigoCurso)
        {
            return cursoRepository.ObtenerAlumnosDeCurso(codigoCurso);
        }

        // Obtener curso con más alumnos
        public CCurso ObtenerCursoConMasAlumnos()
        {
            CCurso cursoConMasAlumnos = null;
            int maxAlumnos = 0;
            foreach (CCurso curso in cursoRepository.ObtenerCursos())
            {
                if (curso.listaAlumnos.Count > maxAlumnos)
                {
                    maxAlumnos = curso.listaAlumnos.Count;
                    cursoConMasAlumnos = curso;
                }
            }
            return cursoConMasAlumnos;
        }

        public List<CCurso> ObtenerCursosMatriculados(int tiu)
        {
            List<CCurso> cursosMatriculados = new List<CCurso>();
            foreach (CCurso curso in cursoRepository.ObtenerCursos())
            {
                if (curso.listaAlumnos.Any(a => a.TIU == tiu))
                {
                    cursosMatriculados.Add(curso);
                }
            }
            return cursosMatriculados;
        }

        public List<CCurso> ObtenerCursosSinAlumnos()
        {
            List<CCurso> cursosSinAlumnos = new List<CCurso>();
            foreach (CCurso curso in cursoRepository.ObtenerCursos())
            {
                if (curso.listaAlumnos.Count == 0)
                {
                    cursosSinAlumnos.Add(curso);
                }
            }
            return cursosSinAlumnos;
        }

        public CAlumno ObtenerAlumnoConMayorTIU()
        {
            List<CAlumno> alumnos = new List<CAlumno>();
            foreach (CCurso curso in cursoRepository.ObtenerCursos())
            {
                alumnos.AddRange(curso.listaAlumnos);
            }

            CAlumno alumnoConMayorTIU = alumnos.OrderByDescending(a => a.TIU).FirstOrDefault();
            return alumnoConMayorTIU;
        }
    }
}
