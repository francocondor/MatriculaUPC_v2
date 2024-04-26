namespace MatriculaUPC_v2
{
    partial class FormVerYAgregarCursos
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
            label1 = new Label();
            label2 = new Label();
            txtCodigoCurso = new TextBox();
            txtNombreCurso = new TextBox();
            btnAgregarCurso = new Button();
            btnVerAlumnos = new Button();
            dgCursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCursos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 46);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Curso";
            // 
            // txtCodigoCurso
            // 
            txtCodigoCurso.Location = new Point(160, 15);
            txtCodigoCurso.Name = "txtCodigoCurso";
            txtCodigoCurso.Size = new Size(100, 23);
            txtCodigoCurso.TabIndex = 2;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(160, 46);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(100, 23);
            txtNombreCurso.TabIndex = 3;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.Location = new Point(45, 99);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(125, 23);
            btnAgregarCurso.TabIndex = 4;
            btnAgregarCurso.Text = "Agregar Curso";
            btnAgregarCurso.UseVisualStyleBackColor = true;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // btnVerAlumnos
            // 
            btnVerAlumnos.Location = new Point(185, 99);
            btnVerAlumnos.Name = "btnVerAlumnos";
            btnVerAlumnos.Size = new Size(147, 23);
            btnVerAlumnos.TabIndex = 5;
            btnVerAlumnos.Text = "Ver Alumnos";
            btnVerAlumnos.UseVisualStyleBackColor = true;
            btnVerAlumnos.Click += btnVerAlumnos_Click;
            // 
            // dgCursos
            // 
            dgCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCursos.Location = new Point(45, 157);
            dgCursos.Name = "dgCursos";
            dgCursos.Size = new Size(287, 150);
            dgCursos.TabIndex = 6;
            // 
            // FormVerYAgregarCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 450);
            Controls.Add(dgCursos);
            Controls.Add(btnVerAlumnos);
            Controls.Add(btnAgregarCurso);
            Controls.Add(txtNombreCurso);
            Controls.Add(txtCodigoCurso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormVerYAgregarCursos";
            Text = "FormVerYAgregarCursos";
            ((System.ComponentModel.ISupportInitialize)dgCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodigoCurso;
        private TextBox txtNombreCurso;
        private Button btnAgregarCurso;
        private Button btnVerAlumnos;
        private DataGridView dgCursos;
    }
}