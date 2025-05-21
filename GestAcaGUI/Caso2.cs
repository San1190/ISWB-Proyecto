using GestAca.Entities;
using GestAca.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestAcaGUI
{
    public partial class Caso2 : Form
    {
        private IGestAcaService igestAcaService;
        private TaughtCourse selectedCourse;
        private Classroom selectedClassroom;
        private IEnumerable<TaughtCourse> cursos;
        private IEnumerable<Classroom> aulas;

        public Caso2(IGestAcaService igestAcaService)
        {
            this.igestAcaService = igestAcaService;

            InitializeComponent();

            // Vincular eventos
            btnAceptar.Click += btnAceptar_Click;
            btnCancelar.Click += btnCancelar_Click;

            //Vincular combobox
            comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;

            // Inicializar el caso de uso
            mostrarCursos();
        }

        public void mostrarCursos()
        {
            // Obtener la lista de cursos
            cursos = this.igestAcaService.GetAllTaughtCourses();

            // Limpiar los elementos existentes en el ComboBox
            comboBoxCursos.Items.Clear();

            // Configurar el DisplayMember para mostrar el nombre del curso
            comboBoxCursos.DisplayMember = "Course.Name"; // Muestra la propiedad "Name" de la relación Course.

            // Añadir los objetos TaughtCourse completos al ComboBox
            foreach (TaughtCourse c in cursos)
            {
                comboBoxCursos.Items.Add(c); // Añade el objeto completo
            }
        }

        public void mostrarAulasDisponibles()
        {
            // Obtener las aulas disponibles para el curso seleccionado
            aulas = this.igestAcaService.GetAvailableClassroomsForTaughtCourse(selectedCourse);

            // Limpiar los elementos existentes en el ComboBox
            comboBoxAulas.Items.Clear();

            // Configurar el DisplayMember para mostrar el nombre del aula
            comboBoxAulas.DisplayMember = "Name"; // Ajustar según la propiedad del aula.

            // Añadir los objetos Classroom completos al ComboBox
            comboBoxAulas.Items.Add(aulas);
            foreach (Classroom c in aulas)
            {
                comboBoxAulas.Items.Add(c); // Añade el objeto completo
            }
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el curso seleccionado
            this.selectedCourse = comboBoxCursos.SelectedItem as TaughtCourse;

            // Mostrar información del curso
            if (comboBoxCursos.SelectedItem != null && comboBoxCursos.SelectedIndex != -1)
            {
                labelInfoCurso.Text = $"Curso: {selectedCourse.Course.Name}\n" +
                                      $"Inicio: {selectedCourse.StartDateTime.ToShortDateString()}\n" +
                                      $"Fin: {selectedCourse.EndDate.ToShortDateString()}\n" +
                                      $"Duración: {selectedCourse.SessionDuration} horas\n" +
                                      $"Aula asignada: {(selectedCourse.Classroom != null ? selectedCourse.Classroom.Name : "Ninguna")}";

                // Mostrar aulas disponibles
                mostrarAulasDisponibles();
            }

        }

        private void comboBoxAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el aula seleccionada
            this.selectedClassroom = comboBoxAulas.SelectedItem as Classroom;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxCursos.SelectedItem == null || comboBoxCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxAulas.SelectedItem == null || comboBoxAulas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un aula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el curso y el aula seleccionados
            this.selectedCourse = comboBoxCursos.SelectedItem as TaughtCourse;
            this.selectedClassroom = comboBoxAulas.SelectedItem as Classroom;

            if (this.selectedCourse == null || this.selectedClassroom == null)
            {
                MessageBox.Show("Debe seleccionar un curso y un aula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignar el aula al curso
            try
            {
                igestAcaService.AddClassroomToTaughtCourse(selectedClassroom, selectedCourse);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"El aula {selectedClassroom.Name} ha sido asignada al curso {selectedCourse.Course.Name}.", "Asignación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin realizar cambios
            this.Close();
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.LightBlue;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.White;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
        }
    }
}