using GestAca.Entities;
using GestAca.Persistence;
using GestAca.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestAcaGUI
{
    public partial class Caso1 : Form
    {
        private IGestAcaService igestAcaService;
        private TaughtCourse selectedCourse;
        private Teacher selectedTeacher;
        private IEnumerable<TaughtCourse> cursos;
        private IEnumerable<Teacher> profesores;

        public Caso1(IGestAcaService igestAcaService)
        {
            this.igestAcaService = igestAcaService;
   

            InitializeComponent();

            // Vincular eventos de ComboBox
            comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;
            comboBoxProfesor.SelectedIndexChanged += comboBoxProfesor_SelectedIndexChanged;

            // Vincular eventos de botones
            btnAnyadir.Click += btnAnyadir_Click;
            btnCancelar.Click += btnCancelar_Click;

            btnAnyadir.MouseEnter += btnAnyadir_MouseEnter;
            btnAnyadir.MouseLeave += btnAnyadir_MouseLeave;

            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            btnCancelar.MouseLeave += btnCancelar_MouseLeave;
            /*
            1. El sistema mostrará todos los cursos a impartir. 
            2. El usuario seleccionará un curso. 
            3. El sistema mostrará la información detallada del 
            curso incluyendo si el mismo ya tiene un profesor 
            asignado. 
            4. El sistema mostrará todos los profesores que 
            pueden impartir dicho curso atendiendo a las 
            posibles restricciones horarias que puedan existir. 
            Un profesor no puede dar un curso si en el lapso de 
            tiempo que dura está ya ocupado impartiendo otro. 
            5. El usuario seleccionará el profesor que lo impartirá. 
            6. El sistema asignará el profesor al curso. 
            */


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

        public void mostrarProfesores()
        {
            profesores = this.igestAcaService.GetCompatibleTeachers(selectedCourse);

            comboBoxProfesor.Items.Clear();
            comboBoxProfesor.DisplayMember = "Name"; // Indica la propiedad a mostrar
            foreach (Teacher p in profesores)
            {
                comboBoxProfesor.Items.Add(p); // Añade el objeto completo
            }
        }

        // Método para obtener el objeto seleccionado
        public Teacher ObtenerProfesorSeleccionado()
        {
            return comboBoxProfesor.SelectedItem as Teacher; // Devuelve el objeto Teacher seleccionado
        }

        private TaughtCourse getCourseById(int id)
        {
            foreach (TaughtCourse c in this.cursos)
            {
                if (c.Id == id)
                    return c;
            }
            return null;
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedCourse = (TaughtCourse)comboBoxCursos.SelectedItem; 
            labelInfo.Text = comboBoxCursos.Text;
            mostrarProfesores();
        }

        private void comboBoxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedTeacher = (Teacher)comboBoxProfesor.SelectedItem; 
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            this.selectedCourse = (TaughtCourse)comboBoxCursos.SelectedItem;
            this.selectedTeacher = (Teacher)comboBoxProfesor.SelectedItem;
            if (selectedTeacher != null)
            {
                try
                {
                    this.igestAcaService.AddTeacherToTaughtCourse(selectedTeacher, selectedCourse);
                } catch (ServiceException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Profesor añadido al curso correctamente.");
            }else
            {
                MessageBox.Show("Error al añadir profesor.");
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnyadir_MouseEnter(object sender, EventArgs e)
        {
            this.btnAnyadir.BackColor = Color.LightBlue;
        }

        private void btnAnyadir_MouseLeave(object sender, EventArgs e)
        {
            this.btnAnyadir.BackColor = Color.White;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            this.btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancelar.BackColor = Color.White;
        }
    }
}
