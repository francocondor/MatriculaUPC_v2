using MatriculaUPC_v2.entidades;
using MatriculaUPC_v2.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaUPC_v2
{
    public partial class FormReportes : Form
    {
        private MatriculaUPCService matriculaUPCService;
        public FormReportes(MatriculaUPCService matriculaUPCService)
        {
            InitializeComponent();
            this.matriculaUPCService = matriculaUPCService;
            MostrarCursosConMasAlumnos();
            MostrarCursosSinAlumnos();
            MostrarAlumnoConMayorTIU();
        }

        private void MostrarCursosConMasAlumnos()
        {
            CCurso cursoConMasAlumnos = matriculaUPCService.ObtenerCursoConMasAlumnos();
            if (cursoConMasAlumnos != null)
            {
                txtCursoConMasAlumnos.Text = "Curso con más alumnos: " + cursoConMasAlumnos.NombreCurso;
            }
            else
            {
                txtCursoConMasAlumnos.Text = "";
            }
        }

        private void btnExiste_Click(object sender, EventArgs e)
        {
            //txtCursoBuscar.Text
            CCurso curso = matriculaUPCService.ObtenerCursos().Find(c => c.CodigoCurso == txtCursoBuscar.Text);
            if (curso != null)
            {
                txtExisteCurso.Text = "Si existe";
            }
            else
            {
                txtExisteCurso.Text = "No existe";
            }
        }

        private void btnVerCursosMatriculados_Click(object sender, EventArgs e)
        {
            int tiu = Convert.ToInt32(txtCodigoAlumno.Text);
            dgCursosAlumno.DataSource = null;
            dgCursosAlumno.DataSource = new BindingList<CCurso>(matriculaUPCService.ObtenerCursosMatriculados(tiu));
        }

        private void MostrarCursosSinAlumnos()
        {
            dgCursosSinAlumnos.DataSource = null;
            dgCursosSinAlumnos.DataSource = new BindingList<CCurso>(matriculaUPCService.ObtenerCursosSinAlumnos());
        }

        private void MostrarAlumnoConMayorTIU()
        {
            CAlumno alumno = matriculaUPCService.ObtenerAlumnoConMayorTIU();
            if (alumno != null)
            {
                txtCodigoMayorAlumno.Text = alumno.TIU.ToString();
            }
            
        }
    }
}
