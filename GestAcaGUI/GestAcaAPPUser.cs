using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestAca.Services;

namespace GestAcaGUI
{
    public partial class GestAcaAPPUser : Form
    {
        IGestAcaService service { get; set; }

        public GestAcaAPPUser(IGestAcaService service)
        {

            InitializeComponent();
            this.service = service;
        }

        private void inscribirUnAlumnoEnUnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCaso3 = new Caso3(this.service);
            frmCaso3.ShowDialog();
            frmCaso3.mostrarCursos();
        }

        private void listadoDeLosAlumnosDeUnCursoAImpartirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCaso4 = new Caso4(this.service);
            frmCaso4.ShowDialog();
        }
    }
}
