namespace MatriculaUPC_v2
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCursoConMasAlumnos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCursoBuscar = new TextBox();
            label3 = new Label();
            txtCodigoAlumno = new TextBox();
            btnExiste = new Button();
            txtExisteCurso = new TextBox();
            btnVerCursosMatriculados = new Button();
            dgCursosAlumno = new DataGridView();
            dgCursosSinAlumnos = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            txtCodigoMayorAlumno = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgCursosAlumno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCursosSinAlumnos).BeginInit();
            SuspendLayout();
            // 
            // txtCursoConMasAlumnos
            // 
            txtCursoConMasAlumnos.Location = new Point(185, 22);
            txtCursoConMasAlumnos.Name = "txtCursoConMasAlumnos";
            txtCursoConMasAlumnos.Size = new Size(266, 23);
            txtCursoConMasAlumnos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 1;
            label1.Text = "Curso con más Alumnos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 72);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo curso";
            // 
            // txtCursoBuscar
            // 
            txtCursoBuscar.Location = new Point(124, 69);
            txtCursoBuscar.Name = "txtCursoBuscar";
            txtCursoBuscar.Size = new Size(133, 23);
            txtCursoBuscar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 119);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Codigo alumno";
            // 
            // txtCodigoAlumno
            // 
            txtCodigoAlumno.Location = new Point(125, 119);
            txtCodigoAlumno.Name = "txtCodigoAlumno";
            txtCodigoAlumno.Size = new Size(132, 23);
            txtCodigoAlumno.TabIndex = 5;
            // 
            // btnExiste
            // 
            btnExiste.Location = new Point(270, 57);
            btnExiste.Name = "btnExiste";
            btnExiste.Size = new Size(75, 44);
            btnExiste.TabIndex = 6;
            btnExiste.Text = "Buscar existe";
            btnExiste.UseVisualStyleBackColor = true;
            btnExiste.Click += btnExiste_Click;
            // 
            // txtExisteCurso
            // 
            txtExisteCurso.Location = new Point(351, 69);
            txtExisteCurso.Name = "txtExisteCurso";
            txtExisteCurso.Size = new Size(100, 23);
            txtExisteCurso.TabIndex = 7;
            // 
            // btnVerCursosMatriculados
            // 
            btnVerCursosMatriculados.Location = new Point(270, 119);
            btnVerCursosMatriculados.Name = "btnVerCursosMatriculados";
            btnVerCursosMatriculados.Size = new Size(181, 23);
            btnVerCursosMatriculados.TabIndex = 8;
            btnVerCursosMatriculados.Text = "Cursos Matriculados";
            btnVerCursosMatriculados.UseVisualStyleBackColor = true;
            btnVerCursosMatriculados.Click += btnVerCursosMatriculados_Click;
            // 
            // dgCursosAlumno
            // 
            dgCursosAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCursosAlumno.Location = new Point(29, 181);
            dgCursosAlumno.Name = "dgCursosAlumno";
            dgCursosAlumno.Size = new Size(422, 150);
            dgCursosAlumno.TabIndex = 9;
            // 
            // dgCursosSinAlumnos
            // 
            dgCursosSinAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCursosSinAlumnos.Location = new Point(501, 57);
            dgCursosSinAlumnos.Name = "dgCursosSinAlumnos";
            dgCursosSinAlumnos.Size = new Size(367, 150);
            dgCursosSinAlumnos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 25);
            label4.Name = "label4";
            label4.Size = new Size(170, 15);
            label4.TabIndex = 11;
            label4.Text = "Cursos que no tienen Alumnos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 240);
            label5.Name = "label5";
            label5.Size = new Size(175, 15);
            label5.TabIndex = 12;
            label5.Text = "Alumno con mayor numero TIU";
            // 
            // txtCodigoMayorAlumno
            // 
            txtCodigoMayorAlumno.Location = new Point(501, 276);
            txtCodigoMayorAlumno.Name = "txtCodigoMayorAlumno";
            txtCodigoMayorAlumno.Size = new Size(184, 23);
            txtCodigoMayorAlumno.TabIndex = 13;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(txtCodigoMayorAlumno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgCursosSinAlumnos);
            Controls.Add(dgCursosAlumno);
            Controls.Add(btnVerCursosMatriculados);
            Controls.Add(txtExisteCurso);
            Controls.Add(btnExiste);
            Controls.Add(txtCodigoAlumno);
            Controls.Add(label3);
            Controls.Add(txtCursoBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCursoConMasAlumnos);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgCursosAlumno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCursosSinAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCursoConMasAlumnos;
        private Label label1;
        private Label label2;
        private TextBox txtCursoBuscar;
        private Label label3;
        private TextBox txtCodigoAlumno;
        private Button btnExiste;
        private TextBox txtExisteCurso;
        private Button btnVerCursosMatriculados;
        private DataGridView dgCursosAlumno;
        private DataGridView dgCursosSinAlumnos;
        private Label label4;
        private Label label5;
        private TextBox txtCodigoMayorAlumno;
    }
}