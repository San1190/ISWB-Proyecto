namespace GestAcaGUI
{
    partial class GestAcaAPPUser
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
            menuStrip1 = new MenuStrip();
            añadirToolStripMenuItem = new ToolStripMenuItem();
            inscribirUnAlumnoEnUnCursoToolStripMenuItem = new ToolStripMenuItem();
            listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem = new ToolStripMenuItem();
            labelBU = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { añadirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // añadirToolStripMenuItem
            // 
            añadirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscribirUnAlumnoEnUnCursoToolStripMenuItem, listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem });
            añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            añadirToolStripMenuItem.Size = new Size(54, 20);
            añadirToolStripMenuItem.Text = "Añadir";
            // 
            // inscribirUnAlumnoEnUnCursoToolStripMenuItem
            // 
            inscribirUnAlumnoEnUnCursoToolStripMenuItem.Name = "inscribirUnAlumnoEnUnCursoToolStripMenuItem";
            inscribirUnAlumnoEnUnCursoToolStripMenuItem.Size = new Size(314, 22);
            inscribirUnAlumnoEnUnCursoToolStripMenuItem.Text = "Inscribir un alumno en un curso ";
            inscribirUnAlumnoEnUnCursoToolStripMenuItem.Click += inscribirUnAlumnoEnUnCursoToolStripMenuItem_Click;
            // 
            // listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem
            // 
            listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem.Name = "listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem";
            listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem.Size = new Size(314, 22);
            listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem.Text = "Listado de los alumnos de un curso a impartir";
            listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem.Click += listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem_Click;
            // 
            // labelBU
            // 
            labelBU.AutoSize = true;
            labelBU.Font = new Font("Palatino Linotype", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelBU.ForeColor = Color.Brown;
            labelBU.Location = new Point(118, 165);
            labelBU.Name = "labelBU";
            labelBU.Size = new Size(484, 53);
            labelBU.TabIndex = 1;
            labelBU.Text = "BIENVENIDO USUARIO";
            // 
            // GestAcaAPPUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBU);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GestAcaAPPUser";
            Text = "GestAcaAPPUser";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem inscribirUnAlumnoEnUnCursoToolStripMenuItem;
        private ToolStripMenuItem listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem;
        private Label labelBU;
    }
}