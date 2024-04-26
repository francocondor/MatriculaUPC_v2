namespace MatriculaUPC_v2
{
    partial class FormVerAlumnosCurso
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
            txtTIU = new TextBox();
            txtNombreCompleto = new TextBox();
            btnAgregarAlumno = new Button();
            dgAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "TIU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE ALUMNO";
            // 
            // txtTIU
            // 
            txtTIU.Location = new Point(164, 20);
            txtTIU.Name = "txtTIU";
            txtTIU.Size = new Size(100, 23);
            txtTIU.TabIndex = 2;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(164, 62);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(100, 23);
            txtNombreCompleto.TabIndex = 3;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(25, 126);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(75, 23);
            btnAgregarAlumno.TabIndex = 4;
            btnAgregarAlumno.Text = "Agregar";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // dgAlumnos
            // 
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Location = new Point(24, 184);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.Size = new Size(240, 150);
            dgAlumnos.TabIndex = 5;
            // 
            // FormVerAlumnosCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 450);
            Controls.Add(dgAlumnos);
            Controls.Add(btnAgregarAlumno);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtTIU);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormVerAlumnosCurso";
            Text = "ALUMNOS MATRICULADOS";
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTIU;
        private TextBox txtNombreCompleto;
        private Button btnAgregarAlumno;
        private DataGridView dgAlumnos;
    }
}