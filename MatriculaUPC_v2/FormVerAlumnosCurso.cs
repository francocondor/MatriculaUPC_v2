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
    public partial class FormVerAlumnosCurso : Form
    {
        private MatriculaUPCService matriculaUPCService;
        private CCurso curso;
        public FormVerAlumnosCurso(MatriculaUPCService matriculaUPCService, CCurso curso)
        {
            InitializeComponent();
            this.matriculaUPCService = matriculaUPCService;
            this.curso = curso;
            // cambiar titulo
            this.Text = "Alumnos del curso " + curso.NombreCurso;
            ActualizarAlumnos();
        }

        private void ActualizarAlumnos()
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = new BindingList<CAlumno>(matriculaUPCService.ObtenerAlumnosDeCurso(curso.CodigoCurso));
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            int tiu = Convert.ToInt32(txtTIU.Text);
            matriculaUPCService.AgregarAlumnoACurso(curso.CodigoCurso, tiu, txtNombreCompleto.Text);
            // Limpiar campos
            txtTIU.Text = "";
            txtNombreCompleto.Text = "";
            ActualizarAlumnos();

        }
    }
}
