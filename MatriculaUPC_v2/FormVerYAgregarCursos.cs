using MatriculaUPC_v2.entidades;
using MatriculaUPC_v2.repositorios;
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
    public partial class FormVerYAgregarCursos : Form
    {
        private MatriculaUPCService matriculaUPCService;
        public FormVerYAgregarCursos(MatriculaUPCService matriculaUPCService)
        {
            InitializeComponent();
            this.matriculaUPCService = matriculaUPCService;
            ActualizarCursos();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            matriculaUPCService.AgregarCurso(txtCodigoCurso.Text, txtNombreCurso.Text);
            // limpiar los campos
            txtCodigoCurso.Text = "";
            txtNombreCurso.Text = "";
            ActualizarCursos();
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            // ver el curso seleccionado
            CCurso curso = (CCurso)dgCursos.CurrentRow.DataBoundItem;
            FormVerAlumnosCurso form = new FormVerAlumnosCurso(matriculaUPCService, curso);
            form.ShowDialog();
        }

        private void ActualizarCursos()
        {
            dgCursos.DataSource = null;
            dgCursos.DataSource = new BindingList<CCurso>(matriculaUPCService.ObtenerCursos());
        }
    }
}
