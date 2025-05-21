using GestAca.Entities;
using GestAca.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestAcaGUI
{
    public partial class Caso3 : Form
    {
        private IGestAcaService igestAcaService;
        private TaughtCourse selectedCourse;
        private Student student;
        private IEnumerable<TaughtCourse> cursos;

        public Caso3(IGestAcaService igestAcaService)
        {
            this.igestAcaService = igestAcaService;

            InitializeComponent();

            // Vincular eventos
            btnDNI.Click += btnDNI_Click;
            btnConfirmar.Click += btnConfirmar_Click;
            btnCancelar.Click += btnCancelar_Click;
            comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;

            // Inicializar el caso de uso
            mostrarCursos();
        }

        public void mostrarCursos()
        {
            // Obtener la lista de cursos cuya fecha de inicio sea posterior a la actual
            cursos = igestAcaService.GetCoursePostAct();

            // Limpiar los elementos existentes en el ComboBox
            comboBoxCursos.Items.Clear();

            // Configurar el DisplayMember para mostrar el nombre del curso
            comboBoxCursos.DisplayMember = "Course.Name";

            // Añadir los objetos TaughtCourse completos al ComboBox
            foreach (TaughtCourse c in cursos)
            {
                comboBoxCursos.Items.Add(c);
            }
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el curso seleccionado
            selectedCourse = comboBoxCursos.SelectedItem as TaughtCourse;

            // Mostrar información del curso (si es necesario)
            if (selectedCourse != null)
            {
                labelCursos.Text = $"Seleccionado: {selectedCourse.Course.Name}";
            }
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            // Obtener el DNI ingresado
            string dni = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor, introduzca un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar el alumno por DNI
            try
            {
                student = igestAcaService.getStudentByDNI(dni);
            } catch
            {
                student = null;
            }

            if (student == null)
            {
                // Preguntar si desea dar de alta un nuevo alumno
                var result = MessageBox.Show("El alumno no está registrado. ¿Desea darlo de alta?", "Alumno no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Solicitar datos del nuevo alumno
                    CrearAlumno();
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            // Mostrar información del alumno encontrado
            labelInfoAlumno.Text = $"Alumno: {student.Name}\nDNI: {student.Id}\nDirección: {student.Address}\nIBAN: {student.IBAN}";
        }

        private void CrearAlumno()
        {
            // Pedir información del nuevo alumno
            string dni = Prompt.ShowDialog("Introduce el DNI del alumno:", "Alta de nuevo alumno");
            string nombre = Prompt.ShowDialog("Introduce el nombre del alumno:", "Alta de nuevo alumno");
            string direccion = Prompt.ShowDialog("Introduce la dirección:", "Alta de nuevo alumno");
            string iban = Prompt.ShowDialog("Introduce el IBAN:", "Alta de nuevo alumno");
            string codigoPostalStr = Prompt.ShowDialog("Introduce el código postal:", "Alta de nuevo alumno");

            if (!int.TryParse(codigoPostalStr, out int codigoPostal))
            {
                MessageBox.Show("El código postal no es válido. Operación cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el nuevo alumno
            student = new Student
            {
                Id = dni,
                Name = nombre,
                Address = direccion,
                IBAN = iban,
                ZipCode = codigoPostal
            };

            igestAcaService.AddStudent(student);

            MessageBox.Show("Alumno registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (selectedCourse == null)
            {
                MessageBox.Show("Debe seleccionar un curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (student == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un alumno antes de confirmar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el alumno ya está inscrito
            if (selectedCourse.Enrollments.Any(e => e.Student.Id == student.Id))
            {
                MessageBox.Show("El alumno ya está inscrito en este curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si hay capacidad en el curso
            if (selectedCourse.Classroom != null && selectedCourse.Classroom.MaxCapacity <= selectedCourse.Enrollments.Count)
            {
                MessageBox.Show("El curso no tiene capacidad disponible. Por favor, seleccione otro curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar inscripción
            try
            {
                igestAcaService.AddStudentToTaughtCourse(student, selectedCourse, true);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"El alumno {student.Name} ha sido inscrito en el curso {selectedCourse.Course.Name}.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.White;
        }
        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = Color.LightBlue;
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = Color.White;
        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label { Left = 50, Top = 20, Text = text, Width = 400 };
            TextBox textBox = new TextBox { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button { Text = "Confirmar", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}