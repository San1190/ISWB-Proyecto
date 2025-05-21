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
    public partial class GestAcaAPPAdmin : Form
    {
        IGestAcaService service { get; set; }
        public GestAcaAPPAdmin(IGestAcaService service)
        {

            InitializeComponent();
            this.service = service;
        }

        private void asignarProfesorAUnCursoAImpartirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCaso1 = new Caso1(this.service);
            frmCaso1.ShowDialog();
        }

        private void asignarAulaAUnCursoAImpartirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCaso2 = new Caso2(this.service);
            frmCaso2.ShowDialog();
        }
    }
}
