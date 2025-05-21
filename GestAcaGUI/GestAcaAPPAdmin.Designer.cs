namespace GestAcaGUI
{
    partial class GestAcaAPPAdmin
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
            asignarProfesorAUnCursoAImpartirToolStripMenuItem = new ToolStripMenuItem();
            asignarAulaAUnCursoAImpartirToolStripMenuItem = new ToolStripMenuItem();
            labelBA = new Label();
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
            añadirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asignarProfesorAUnCursoAImpartirToolStripMenuItem, asignarAulaAUnCursoAImpartirToolStripMenuItem });
            añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            añadirToolStripMenuItem.Size = new Size(54, 20);
            añadirToolStripMenuItem.Text = "Añadir";
            // 
            // asignarProfesorAUnCursoAImpartirToolStripMenuItem
            // 
            asignarProfesorAUnCursoAImpartirToolStripMenuItem.Name = "asignarProfesorAUnCursoAImpartirToolStripMenuItem";
            asignarProfesorAUnCursoAImpartirToolStripMenuItem.Size = new Size(276, 22);
            asignarProfesorAUnCursoAImpartirToolStripMenuItem.Text = "Asignar profesor a un curso a impartir ";
            asignarProfesorAUnCursoAImpartirToolStripMenuItem.Click += asignarProfesorAUnCursoAImpartirToolStripMenuItem_Click;
            // 
            // asignarAulaAUnCursoAImpartirToolStripMenuItem
            // 
            asignarAulaAUnCursoAImpartirToolStripMenuItem.Name = "asignarAulaAUnCursoAImpartirToolStripMenuItem";
            asignarAulaAUnCursoAImpartirToolStripMenuItem.Size = new Size(276, 22);
            asignarAulaAUnCursoAImpartirToolStripMenuItem.Text = "Asignar aula a un curso a impartir ";
            asignarAulaAUnCursoAImpartirToolStripMenuItem.Click += asignarAulaAUnCursoAImpartirToolStripMenuItem_Click;
            // 
            // labelBA
            // 
            labelBA.AutoSize = true;
            labelBA.Font = new Font("Palatino Linotype", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelBA.ForeColor = Color.Brown;
            labelBA.Location = new Point(55, 172);
            labelBA.Name = "labelBA";
            labelBA.Size = new Size(650, 53);
            labelBA.TabIndex = 1;
            labelBA.Text = "BIENVENIDO ADMINISTRADOR";
            // 
            // GestAcaAPPAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GestAcaAPPAdmin";
            Text = "GestAcaAPPAdmin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem asignarProfesorAUnCursoAImpartirToolStripMenuItem;
        private ToolStripMenuItem asignarAulaAUnCursoAImpartirToolStripMenuItem;
        private Label labelBA;
    }
}