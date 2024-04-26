using MatriculaUPC_v2.servicios;

namespace MatriculaUPC_v2
{
    public partial class Form1 : Form
    {
        private MatriculaUPCService matriculaUPCService;
        public Form1()
        {
            InitializeComponent();
            matriculaUPCService = new MatriculaUPCService();
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            // Abrir un Formulario con la lista de cursos
            FormVerYAgregarCursos form = new FormVerYAgregarCursos(matriculaUPCService);
            form.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes(matriculaUPCService);
            form.ShowDialog();
        }
    }
}
