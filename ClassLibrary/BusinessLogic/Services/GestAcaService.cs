﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using GestAca.Entities;
using GestAca.Persistence;


namespace GestAca.Services
{
    public class GestAcaService : IGestAcaService
    {
        private readonly IDAL dal;

        public GestAcaService(IDAL dal)
        {
            this.dal = dal;
        }

        /// <summary>
        /// Borra todos los datos de la BD
        /// </summary>
        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        /// <summary>
        /// Salva todos los cambios que haya habido en el contexto de la aplicación desde la última vez que se hizo Commit
        /// </summary>
        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            // Dar de alta unos profesores para poder usarlos luego
            AddTeacher(new Teacher("C/San Cristobal 10", "11111111A", "Prof1", 46022, "SSN11111111A"));
            AddTeacher(new Teacher("Av. La Informatica 20", "22222222B", "Prof2", 46022, "SSN22222222B"));
            AddTeacher(new Teacher("C/Sulfurosa 30", "33333333C", "Prof3", 46022, "SSN33333333B"));

            // Dar de alta unas aulas para poder usarlas luego
            AddClassroom(new Classroom(2, "1P"));
            AddClassroom(new Classroom(10, "1A"));
            AddClassroom(new Classroom(5, "1G"));

            // Dar de alta unos cursos para poder usarlos luego
            Course aCourse1 = new Course("Curso Introductorio Ingenieria Software", "Software Engineering");
            AddCourse(aCourse1);
            Course aCourse2 = new Course("Curso Introductorio de Estructuras de datos", "Data Structures");
            AddCourse(aCourse2);
            AddCourse(new Course("Curso avanzado de Aerodinámica", "Advance aerodynamics"));

            //Curso empezado en 03/25 Válido para prácticas y recuperación. Se podrán apuntar nuevos estudiantes
            DateTime startDateTime = new DateTime(2025, 3, 24, 9, 30, 0);
            DateTime endDate = new DateTime(2025, 5, 19);
            TaughtCourse aTaughtCourse1 = new TaughtCourse(endDate, 1, 3, 120, startDateTime, "Monday", 1500, aCourse1);
            AddTaughtCourse(aTaughtCourse1);

            // Curso empezado en 04/24
            startDateTime = new DateTime(2024, 4, 15, 12, 0, 0);
            endDate = new DateTime(2024, 11, 30);
            TaughtCourse aTaughtCourse2 = new TaughtCourse(endDate, 2, 2, 120, startDateTime, "Wednesday", 1000, aCourse2);
            AddTaughtCourse(aTaughtCourse2);


        }

        /// <summary>
        /// Persiste un profesor
        /// </summary>
        /// <param name="teacher"></param>
        /// <exception cref="ServiceException"></exception>
        public void AddTeacher(Teacher teacher)
        {
            // Restricción: No puede haber dos personas con el mismo Id (dni)
            if (dal.GetById<Teacher>(teacher.Id) == null)
            {
                dal.Insert<Teacher>(teacher);
                dal.Commit();
            }
            else
                throw new ServiceException("There is another person with Id " + teacher.Id);
        }

        /// <summary>
        /// Persiste un aula
        /// </summary>
        /// <param name="Classroom"></param>
        /// <exception cref="ServiceException"></exception>
        public void AddClassroom(Classroom classroom)
        {
            // Restricción: No puede haber dos aulas con el mismo nombre
            if (!dal.GetWhere<Classroom>(x => x.Name == classroom.Name).Any())
            {
                dal.Insert<Classroom>(classroom);
                dal.Commit();
            }
            else
                throw new ServiceException("There is another classroom with Name " + classroom.Name);
        }

        /// <summary>
        /// Salva en la BD un curso 
        /// </summary>
        /// <param name="course"></param>
        /// <exception cref="ServiceException"></exception> 
        public void AddCourse(Course course)
        {
            // Restricción: No puede haber dos cursos con el mismo Name
            if (!dal.GetWhere<Course>(x => x.Name == course.Name).Any())
            {
                // Sólo se salva si no hay Name
                dal.Insert<Course>(course);
                dal.Commit();
            }
            else
                throw new ServiceException("Course with name " + course.Name + " already exists.");
        }

        /// <summary>
        /// Persiste el curso a impartir
        /// </summary>
        /// <param name="tcourse"></param>
        /// <exception cref="ServiceException"></exception>
        public void AddTaughtCourse(TaughtCourse tcourse)
        {
            // Restricción: No puede haber dos TaughtCourses con el mismo Id
            if (dal.GetById<TaughtCourse>(tcourse.Id) == null)
            {
                dal.Insert<TaughtCourse>(tcourse);
                dal.Commit();
            }
            else
                throw new ServiceException("Taught Course with Id " + tcourse.Id + " already exists.");
        }

        //
        // A partir de aquí vuestros métodos
        //
        public void AddStudent(Student student)
        {
            // Restricción: No puede haber dos personas con el mismo Id (dni)
           
                dal.Insert<Student>(student);
                dal.Commit();
            
       

        }

        public void AddClassroomToTaughtCourse(Classroom classroom, TaughtCourse tcourse)
        {
            tcourse.Classroom = classroom;
            classroom.TaughtCourses.Add(tcourse);
        }



        //CASO 1
        // 1.
        public IEnumerable<TaughtCourse> GetAllCourses()
        {
            return dal.GetAll<TaughtCourse>();
        }

        //3.
        public ICollection<KeyValuePair<string, bool>> CourseInformation(Course course)
        {
            ICollection<KeyValuePair<string, bool>> result = new List<KeyValuePair<string, bool>>();
            var prof = false;

            foreach (TaughtCourse tc in course.TaughtCourses)
            {
                if (tc.Teachers != null)
                {
                    prof = true;
                }
            }

            if (!prof)
            {
                throw new ServiceException("No teachers found");
            }

            result.Add(new KeyValuePair<string, bool>(course.Description, prof));

            return result;
        }



        //4.
        public IEnumerable<Teacher> GetCompatibleTeachers(TaughtCourse tc)
        {
            List<Teacher> teachers = dal.GetAll<Teacher>().ToList();


            teachers.RemoveAll(teacher => !teacher.IsScheduleCompatibleWith(tc));

            return teachers;
        }

        //6.
        public void AddTeacherToTaughtCourse(Teacher teacher, TaughtCourse tcourse)
        {
            tcourse.Teachers.Add(teacher);
            teacher.TaughtCourses.Add(tcourse);
        }



        //Listado de los alumnos de un curso
        public ICollection<Student> GetAllStudentsFromTaughtCourse(TaughtCourse tcourse)
        {
            ICollection<Student> students = new List<Student>();
            foreach (Enrollment enrollment in tcourse.Enrollments)
            {
                students.Add(enrollment.Student);
            }
            return students;
        }







        //CASO 2
        // 1.
        //Mostrar todos los cursos a impartir
        public IEnumerable<TaughtCourse> GetAllTaughtCourses()
        {
            return dal.GetAll<TaughtCourse>();
        }

        // 3.
        public ICollection<KeyValuePair<string, bool>> ClassroomInformation(Course course)
        {
            ICollection<KeyValuePair<string, bool>> result = new List<KeyValuePair<string, bool>>();
            var clas = false;

            foreach (TaughtCourse tc in course.TaughtCourses)
            {
                if (tc.Classroom != null)
                {
                    clas = true;
                }
            }

            if (!clas)
            {
                throw new ServiceException("No classrooms found");
            }

            result.Add(new KeyValuePair<string, bool>(course.Description, clas));

            return result;
        }






        // 4.
        // Filtra las aulas que cumplen las restricciones (disponibilidad y capacidad)
        public ICollection<Classroom> GetAvailableClassroomsForTaughtCourse(TaughtCourse taughtCourse)
        {
            var classrooms = dal.GetAll<Classroom>();
            var availableClassrooms = new List<Classroom>();

            foreach (var classroom in classrooms)
            {
                // Comprobar que no haya conflicto de horarios
                bool isAvailable = classroom.TaughtCourses.All(tc =>
                    tc.StartDateTime >= taughtCourse.EndDate || tc.EndDate <= taughtCourse.StartDateTime);

                // Comprobar capacidad  
                bool hasCapacity = classroom.MaxCapacity >= taughtCourse.Enrollments.Count;

                if (isAvailable && hasCapacity)
                {
                    availableClassrooms.Add(classroom);
                }
            }

            return availableClassrooms;
        }

        // 6.
        // Asigna un aula a un curso y valida las restricciones de nuevo como seguridad adicional
        public void AssignClassroomToCourse(TaughtCourse taughtCourse, Classroom classroom)
        {
            // Validar restricciones
            if (classroom.MaxCapacity < taughtCourse.Enrollments.Count)
            {
                throw new ServiceException("The classroom capacity is insufficient for the enrolled students.");
            }

            if (!classroom.TaughtCourses.All(tc =>
                tc.StartDateTime >= taughtCourse.EndDate || tc.EndDate <= taughtCourse.StartDateTime))
            {
                throw new ServiceException("The classroom is already in use during the selected time.");
            }

            // Asignar aula al curso
            taughtCourse.Classroom = classroom;
            classroom.TaughtCourses.Add(taughtCourse);
            dal.Commit();
        }








        //CASO3
        // 1.
        //Lista de cursos a impartir despues de la fecha actual
        public ICollection<TaughtCourse> GetCoursePostAct()
        {
            var list = dal.GetAll<TaughtCourse>();

            ICollection<TaughtCourse> result = new List<TaughtCourse>();


            foreach (TaughtCourse taughtCourse in list)
            {
                //comprobar que la fecha sea posterior
                if (taughtCourse.StartDateTime > DateTime.Now)
                {
                    result.Add(taughtCourse);
                }

            }

            return result;


        }

        // 5.
        //Bucar alumno por dni
        public Student getStudentByDNI(string dni)
        {
            var list = dal.GetAll<Student>();

            foreach (Student student in list)
            {
                if (student.Id == dni)
                {
                    return student;
                }




            }

            throw new ServiceException("Student don't found");
        }


        // 7.
        //Introducir un alumno a un curso
        public void AddStudentToTaughtCourse(Student student, TaughtCourse taughtCourse, bool uniquePayment)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student cannot be null.");
            }

            if (taughtCourse == null)
            {
                throw new ArgumentNullException(nameof(taughtCourse), "TaughtCourse cannot be null.");
            }

            // Verificar si el estudiante ya está inscrito en el curso
            if (student.Enrollments.Any(e => e.TaughtCourse == taughtCourse))
            {
                throw new ServiceException("Student is already enrolled in this course.");
            }

            // Obtener las aulas disponibles
            var classrooms = dal.GetAll<Classroom>();

            Classroom associatedClassroom = null;

            foreach (var classroom in classrooms)
            {
                if (classroom.TaughtCourses.Contains(taughtCourse))
                {
                    associatedClassroom = classroom;
                    break; // Encontramos el aula asociada al curso
                }
            }

            if (associatedClassroom == null)
            {
                throw new ServiceException("No classroom found for the given taught course.");
            }

            // Verificar si el aula tiene capacidad
            if (associatedClassroom.MaxCapacity <= taughtCourse.Enrollments.Count)
            {
                throw new ServiceException("The classroom is full.");
            }

            // Crear el nuevo Enrollment
            Enrollment enrollment = new Enrollment(taughtCourse.StartDateTime, uniquePayment, student, taughtCourse);

            // Actualizar las colecciones
            taughtCourse.Enrollments.Add(enrollment);
            student.Enrollments.Add(enrollment);

            // Confirmar los cambios
            dal.Commit();
        }




        //CASO 4

        //1. Sistema muestra lista de cursos a impartir -> llamar a la función GetAllTaughtcourse()

        //2. Usuario escoge uno de los cursos -> se escoge automático? es decir, sin método?

        //3.Sistema muestra alumnos inscritos a dicho curso -> basta con llamar a GetAllStudentsFromTaughtCourse() o  es necesario otro método que solo muestre el nombre del alumno y si paga el cusrdo completo o por cuotas mensuales?

        //método que solo muestre el nombre del alumno y si paga el cusrdo completo o por cuotas mensuales
        public ICollection<KeyValuePair<string, bool>> GetStudentFromCourse(TaughtCourse tc)
        {
            ICollection<Student> students = GetAllStudentsFromTaughtCourse(tc);
            ICollection<KeyValuePair<string, bool>> studentInfo = new List<KeyValuePair<string, bool>>();

            foreach (Student student in students)
            {
                bool UniquePayment = false;

                // Asumiendo que cada objeto en Enrollments tiene un campo 'HasPaid' o algo similar
                foreach (var enrollment in student.Enrollments)
                {
                    if (enrollment.UniquePayment) 
                    {
                        UniquePayment = true;
                        break; // Si ya encontramos que ha pagado, no necesitamos revisar más
                    }
                }

                studentInfo.Add(new KeyValuePair<string, bool>(student.Name, UniquePayment));
            }

            return studentInfo;
        }






    }
}

