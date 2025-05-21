namespace GestAcaGUI
{
    partial class Caso2
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
            labelInfoCurso = new Label();
            labelAulas = new Label();
            comboBoxAulas = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            labelT2 = new Label();
            SuspendLayout();
            // 
            // labelCursos
            // 
            labelCursos.AutoSize = true;
            labelCursos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCursos.Location = new Point(53, 75);
            labelCursos.Name = "labelCursos";
            labelCursos.Size = new Size(61, 21);
            labelCursos.TabIndex = 0;
            labelCursos.Text = "Cursos:";
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.Font = new Font("Segoe UI", 12F);
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(120, 72);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(175, 29);
            comboBoxCursos.TabIndex = 1;
            comboBoxCursos.Text = "Selecciona un curso";
            // 
            // labelInfoCurso
            // 
            labelInfoCurso.AutoSize = true;
            labelInfoCurso.Location = new Point(462, 66);
            labelInfoCurso.Name = "labelInfoCurso";
            labelInfoCurso.Size = new Size(0, 15);
            labelInfoCurso.TabIndex = 2;
            // 
            // labelAulas
            // 
            labelAulas.AutoSize = true;
            labelAulas.Font = new Font("Segoe UI", 12F);
            labelAulas.Location = new Point(53, 276);
            labelAulas.Name = "labelAulas";
            labelAulas.Size = new Size(131, 21);
            labelAulas.TabIndex = 3;
            labelAulas.Text = "Aulas disponibles";
            // 
            // comboBoxAulas
            // 
            comboBoxAulas.Font = new Font("Segoe UI", 12F);
            comboBoxAulas.FormattingEnabled = true;
            comboBoxAulas.Location = new Point(190, 273);
            comboBoxAulas.Name = "comboBoxAulas";
            comboBoxAulas.Size = new Size(165, 29);
            comboBoxAulas.TabIndex = 4;
            comboBoxAulas.Text = "Selecciona un aula";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(815, 435);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(90, 33);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(24, 435);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            btnCancelar.MouseLeave += btnCancelar_MouseLeave;
            // 
            // labelT2
            // 
            labelT2.AutoSize = true;
            labelT2.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelT2.ForeColor = Color.Brown;
            labelT2.Location = new Point(212, 9);
            labelT2.Name = "labelT2";
            labelT2.Size = new Size(504, 32);
            labelT2.TabIndex = 7;
            labelT2.Text = "ASIGNAR AULA A UN CURSO A IMPARTIR";
            // 
            // Caso2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(935, 491);
            Controls.Add(labelT2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(comboBoxAulas);
            Controls.Add(labelAulas);
            Controls.Add(labelInfoCurso);
            Controls.Add(comboBoxCursos);
            Controls.Add(labelCursos);
            Name = "Caso2";
            Text = "Caso2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCursos;
        private ComboBox comboBoxCursos;
        private Label labelInfoCurso;
        private Label labelAulas;
        private ComboBox comboBoxAulas;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label labelT2;
    }
}