namespace GestAcaGUI
{
    partial class Caso4
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
            labelCurso = new Label();
            comboBoxCursos = new ComboBox();
            labelAlumnos = new Label();
            labelInfoAlumnos = new Label();
            btnCerrar = new Button();
            listBoxAlumnos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelCurso
            // 
            labelCurso.AutoSize = true;
            labelCurso.Font = new Font("Segoe UI", 12F);
            labelCurso.Location = new Point(39, 70);
            labelCurso.Name = "labelCurso";
            labelCurso.Size = new Size(54, 21);
            labelCurso.TabIndex = 0;
            labelCurso.Text = "Curso:";
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.Font = new Font("Segoe UI", 12F);
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(99, 67);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(165, 29);
            comboBoxCursos.TabIndex = 1;
            comboBoxCursos.Text = "Selecciona un curso";
            // 
            // labelAlumnos
            // 
            labelAlumnos.AutoSize = true;
            labelAlumnos.Font = new Font("Segoe UI", 12F);
            labelAlumnos.Location = new Point(39, 130);
            labelAlumnos.Name = "labelAlumnos";
            labelAlumnos.Size = new Size(216, 21);
            labelAlumnos.TabIndex = 2;
            labelAlumnos.Text = "Alumnos inscritos en el curso:";
            // 
            // labelInfoAlumnos
            // 
            labelInfoAlumnos.AutoSize = true;
            labelInfoAlumnos.Font = new Font("Segoe UI", 12F);
            labelInfoAlumnos.Location = new Point(64, 163);
            labelInfoAlumnos.Name = "labelInfoAlumnos";
            labelInfoAlumnos.Size = new Size(0, 21);
            labelInfoAlumnos.TabIndex = 3;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(684, 410);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(80, 28);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            btnCerrar.MouseLeave += btnCerrar_MouseLeave;
            // 
            // listBoxAlumnos
            // 
            listBoxAlumnos.FormattingEnabled = true;
            listBoxAlumnos.ItemHeight = 15;
            listBoxAlumnos.Location = new Point(261, 130);
            listBoxAlumnos.Name = "listBoxAlumnos";
            listBoxAlumnos.Size = new Size(483, 259);
            listBoxAlumnos.TabIndex = 6;
            listBoxAlumnos.SelectedIndexChanged += listBoxAlumnos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(491, 32);
            label1.TabIndex = 7;
            label1.Text = "LISTADO DE LOS ALUMNOS DEL CURSO";
            // 
            // Caso4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBoxAlumnos);
            Controls.Add(btnCerrar);
            Controls.Add(labelInfoAlumnos);
            Controls.Add(labelAlumnos);
            Controls.Add(comboBoxCursos);
            Controls.Add(labelCurso);
            Name = "Caso4";
            Text = "Caso4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCurso;
        private ComboBox comboBoxCursos;
        private Label labelAlumnos;
        private Label labelInfoAlumnos;
        private Button btnCerrar;
        private ListBox listBoxAlumnos;
        private Label label1;
    }
}