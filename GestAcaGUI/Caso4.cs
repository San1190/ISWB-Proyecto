using GestAca.Entities;
using GestAca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestAcaGUI
{
    public partial class Caso4 : Form
    {
        private readonly IGestAcaService igestAcaService;
        private TaughtCourse selectedCourse;

        public Caso4(IGestAcaService igestAcaService)
        {
            this.igestAcaService = igestAcaService;

            InitializeComponent();

            // Inicializar el caso de uso
            MostrarCursos();

            // Vincular eventos
            comboBoxCursos.SelectedIndexChanged += ComboBoxCursos_SelectedIndexChanged;
            btnCerrar.Click += btnCerrar_Click;
        }

        private void MostrarCursos()
        {
            // Obtener la lista de cursos disponibles
            IEnumerable<TaughtCourse> cursos = igestAcaService.GetAllTaughtCourses();

            // Limpiar el ComboBox
            comboBoxCursos.Items.Clear();

            // Configurar el DisplayMember para mostrar el nombre del curso
            comboBoxCursos.DisplayMember = "Course.Name";

            // Añadir los cursos al ComboBox
            foreach (TaughtCourse curso in cursos)
            {
                comboBoxCursos.Items.Add(curso);
            }
        }

        private void ComboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el curso seleccionado
            selectedCourse = comboBoxCursos.SelectedItem as TaughtCourse;

            // Mostrar alumnos inscritos
            MostrarAlumnos();
        }

        private void MostrarAlumnos()
        {
            if (selectedCourse == null)
            {
                MessageBox.Show("Por favor, seleccione un curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los alumnos inscritos en el curso seleccionado
            IEnumerable<Enrollment> inscripciones = selectedCourse.Enrollments;

            // Limpiar el ListBox
            listBoxAlumnos.Items.Clear();

            // Agregar información de los alumnos al ListBox
            foreach (Enrollment inscripcion in inscripciones)
            {
                string metodoPago = inscripcion.UniquePayment ? "Pago único" : "Cuotas mensuales";
                string alumnoInfo = $"{inscripcion.Student.Name} - {metodoPago}";
                listBoxAlumnos.Items.Add(alumnoInfo);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.LightBlue;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.White;
        }
    }
}
