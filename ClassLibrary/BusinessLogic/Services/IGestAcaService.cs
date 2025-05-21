using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestAca.Entities;


namespace GestAca.Services
{
    public interface IGestAcaService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddTeacher(Teacher teacher);
		void AddClassroom(Classroom classroom);
        void AddCourse(Course course);
        void AddTaughtCourse(TaughtCourse tcourse);


        //
        // A partir de aquí los necesarios para los CU solicitados
        //
        IEnumerable<TaughtCourse> GetAllTaughtCourses();
        ICollection<KeyValuePair<string, bool>> ClassroomInformation(Course course);
        ICollection<Classroom> GetAvailableClassroomsForTaughtCourse(TaughtCourse taughtCourse);
        void AssignClassroomToCourse(TaughtCourse taughtCourse, Classroom classroom);
        IEnumerable<Teacher> GetCompatibleTeachers(TaughtCourse tc);
        ICollection<KeyValuePair<string, bool>> CourseInformation(Course course);
        void AddTeacherToTaughtCourse(Teacher teacher, TaughtCourse tcourse);
        ICollection<TaughtCourse> GetCoursePostAct();
        ICollection<Student> GetAllStudentsFromTaughtCourse(TaughtCourse tcourse);
        Student getStudentByDNI(string dni);
        void AddStudentToTaughtCourse(Student student, TaughtCourse tcourse, bool uniquepayment);
        ICollection<KeyValuePair<string, bool>> GetStudentFromCourse(TaughtCourse tc);
        void AddClassroomToTaughtCourse(Classroom classroom, TaughtCourse tcourse);
        void AddStudent(Student student);


    }
}
