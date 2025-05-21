namespace GestAcaGUI
{
    partial class Caso3
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
            labelCursos = new Label();
            comboBoxCursos = new ComboBox();
            labelDNI = new Label();
            textBox1 = new TextBox();
            btnDNI = new Button();
            labelInfoAlumno = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            labelT3 = new Label();
            SuspendLayout();
            // 
            // labelCursos
            // 
            labelCursos.AutoSize = true;
            labelCursos.Font = new Font("Segoe UI", 12F);
            labelCursos.Location = new Point(38, 101);
            labelCursos.Name = "labelCursos";
            labelCursos.Size = new Size(133, 21);
            labelCursos.TabIndex = 0;
            labelCursos.Text = "Cursos a impartir:";
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.Font = new Font("Segoe UI", 12F);
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(177, 98);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(175, 29);
            comboBoxCursos.TabIndex = 1;
            comboBoxCursos.Text = "Selecciona un curso";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Segoe UI", 12F);
            labelDNI.Location = new Point(38, 251);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(208, 21);
            labelDNI.TabIndex = 2;
            labelDNI.Text = "Introduzca su DNI, por favor:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(252, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 29);
            textBox1.TabIndex = 3;
            // 
            // btnDNI
            // 
            btnDNI.Font = new Font("Segoe UI", 12F);
            btnDNI.Location = new Point(554, 247);
            btnDNI.Name = "btnDNI";
            btnDNI.Size = new Size(68, 33);
            btnDNI.TabIndex = 4;
            btnDNI.Text = "Buscar";
            btnDNI.UseVisualStyleBackColor = true;
            // 
            // labelInfoAlumno
            // 
            labelInfoAlumno.AutoSize = true;
            labelInfoAlumno.Font = new Font("Segoe UI", 12F);
            labelInfoAlumno.Location = new Point(56, 230);
            labelInfoAlumno.Name = "labelInfoAlumno";
            labelInfoAlumno.Size = new Size(0, 21);
            labelInfoAlumno.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(823, 461);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(98, 28);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.MouseEnter += btnConfirmar_MouseEnter;
            btnConfirmar.MouseLeave += btnConfirmar_MouseLeave;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(25, 461);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 28);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            btnCancelar.MouseLeave += btnCancelar_MouseLeave;
            // 
            // labelT3
            // 
            labelT3.AutoSize = true;
            labelT3.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelT3.ForeColor = Color.Brown;
            labelT3.Location = new Point(226, 9);
            labelT3.Name = "labelT3";
            labelT3.Size = new Size(432, 32);
            labelT3.TabIndex = 8;
            labelT3.Text = "INSCRIBIR ALUMNO EN UN CURSO";
            // 
            // Caso3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(946, 511);
            Controls.Add(labelT3);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(labelInfoAlumno);
            Controls.Add(btnDNI);
            Controls.Add(textBox1);
            Controls.Add(labelDNI);
            Controls.Add(comboBoxCursos);
            Controls.Add(labelCursos);
            Name = "Caso3";
            Text = "Caso3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCursos;
        private ComboBox comboBoxCursos;
        private Label labelDNI;
        private TextBox textBox1;
        private Button btnDNI;
        private Label labelInfoAlumno;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label labelT3;
    }
}