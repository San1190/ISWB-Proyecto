namespace GestAcaGUI
{
    partial class Caso1
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
            comboBoxCursos = new ComboBox();
            labelCurso = new Label();
            labeltitulo = new Label();
            labelProf = new Label();
            comboBoxProfesor = new ComboBox();
            btnAnyadir = new Button();
            btnCancelar = new Button();
            labelInfo = new Label();
            SuspendLayout();
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.Font = new Font("Segoe UI", 12F);
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(185, 98);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(162, 29);
            comboBoxCursos.TabIndex = 0;
            comboBoxCursos.Text = "Selecciona un curso";
            comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;
            // 
            // labelCurso
            // 
            labelCurso.AutoSize = true;
            labelCurso.Font = new Font("Segoe UI", 12F);
            labelCurso.Location = new Point(12, 96);
            labelCurso.Name = "labelCurso";
            labelCurso.Size = new Size(150, 21);
            labelCurso.TabIndex = 1;
            labelCurso.Text = "Selecciona un curso:";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labeltitulo.ForeColor = Color.Brown;
            labeltitulo.Location = new Point(185, 9);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(568, 32);
            labeltitulo.TabIndex = 2;
            labeltitulo.Text = "ASIGNAR PROFESOR A UN CURSO A IMPARTIR";
            // 
            // labelProf
            // 
            labelProf.AutoSize = true;
            labelProf.Font = new Font("Segoe UI", 12F);
            labelProf.Location = new Point(12, 357);
            labelProf.Name = "labelProf";
            labelProf.Size = new Size(228, 21);
            labelProf.TabIndex = 3;
            labelProf.Text = "Profesor que impartirá el curso:";
            // 
            // comboBoxProfesor
            // 
            comboBoxProfesor.Font = new Font("Segoe UI", 12F);
            comboBoxProfesor.FormattingEnabled = true;
            comboBoxProfesor.Location = new Point(255, 359);
            comboBoxProfesor.Name = "comboBoxProfesor";
            comboBoxProfesor.Size = new Size(281, 29);
            comboBoxProfesor.TabIndex = 4;
            comboBoxProfesor.Text = "Selecciona un profesor";
            comboBoxProfesor.SelectedIndexChanged += comboBoxProfesor_SelectedIndexChanged;
            // 
            // btnAnyadir
            // 
            btnAnyadir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnyadir.Location = new Point(820, 531);
            btnAnyadir.Name = "btnAnyadir";
            btnAnyadir.Size = new Size(88, 29);
            btnAnyadir.TabIndex = 5;
            btnAnyadir.Text = "Añadir";
            btnAnyadir.UseVisualStyleBackColor = true;
            btnAnyadir.Click += btnAnyadir_Click;
            btnAnyadir.MouseEnter += btnAnyadir_MouseEnter;
            btnAnyadir.MouseLeave += btnAnyadir_MouseLeave;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 531);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            btnCancelar.MouseLeave += btnCancelar_MouseLeave;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 12F);
            labelInfo.Location = new Point(412, 98);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 21);
            labelInfo.TabIndex = 7;
            labelInfo.UseMnemonic = false;
            // 
            // Caso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(920, 572);
            Controls.Add(labelInfo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAnyadir);
            Controls.Add(comboBoxProfesor);
            Controls.Add(labelProf);
            Controls.Add(labeltitulo);
            Controls.Add(labelCurso);
            Controls.Add(comboBoxCursos);
            Name = "Caso1";
            Text = "Caso1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCursos;
        private Label labelCurso;
        private Label labeltitulo;
        private Label labelProf;
        private ComboBox comboBoxProfesor;
        private Button btnAnyadir;
        private Button btnCancelar;
        private Label labelInfo;
    }
}