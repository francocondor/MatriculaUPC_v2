namespace MatriculaUPC_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVerCursos = new Button();
            btnReportes = new Button();
            SuspendLayout();
            // 
            // btnVerCursos
            // 
            btnVerCursos.Location = new Point(93, 56);
            btnVerCursos.Name = "btnVerCursos";
            btnVerCursos.Size = new Size(149, 23);
            btnVerCursos.TabIndex = 0;
            btnVerCursos.Text = "VER CURSOS";
            btnVerCursos.UseVisualStyleBackColor = true;
            btnVerCursos.Click += btnVerCursos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(93, 105);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(149, 23);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "REPORTES";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 199);
            Controls.Add(btnReportes);
            Controls.Add(btnVerCursos);
            Name = "Form1";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerCursos;
        private Button btnReportes;
    }
}
