using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestAca.Entities;
using GestAca.Persistence;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace DBTest
{


    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new GestAcaDbContext());

            CreateSampleDB(dal);
            PrintSampleDB(dal);
        }


        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();

            Console.WriteLine("CREANDO LOS DATOS Y ALMACENANDOLOS EN LA BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE CURSOS");
            //public Course(string descr, string name)
            Course aCourse1 = new Course("Curso Introductorio Ingenieria Software", "Ingenieria de Software");
            dal.Insert<Course>(aCourse1);
            dal.Commit();
            Course aCourse2 = new Course("Curso Introductorio de Estructuras de datos", "Estructuras de datos");
            dal.Insert<Course>(aCourse2);
            dal.Commit();

            // Populate here the rest of the database
            // Add missing code here
            Teacher aTeacher1 = new Teacher("Picassent", "746578473Q", "Juansa", 46220, "754368233");
            dal.Insert<Teacher>(aTeacher1);
            dal.Commit();
            Teacher aTeacher2 = new Teacher("Alcasser", "351222123R", "Miguel", 46228, "123124413");
            dal.Insert<Teacher>(aTeacher2);
            dal.Commit();
            Teacher aTeacher3 = new Teacher("Silla", "251232123S", "Flich", 46229, "124124413");
            dal.Insert<Teacher>(aTeacher3);
            dal.Commit();

            TaughtCourse aTaughtCourse1 = new TaughtCourse(new DateTime(2024, 12, 23), 123, 4, 120, new DateTime(2024, 10, 23), "Monday", 1200, aCourse1);
            TaughtCourse aTaughtCourse2 = new TaughtCourse(new DateTime(2025, 1, 23), 124, 3, 120, new DateTime(2024, 10, 23), "Tuesday", 1200, aCourse2);


            dal.Insert<TaughtCourse>(aTaughtCourse1);
            dal.Insert<TaughtCourse>(aTaughtCourse2);
            dal.Commit();

            Student[] students = new Student[10];

            students[0] = new Student("Valencia", "E2R", "Jose", 46200, "ES801233123412731859");
            students[1] = new Student("Picassent", "E2O", "Adrian", 46220, "ES801233123412731859");
            students[2] = new Student("Valencia", "E2P", "Miguel", 46200, "ES801233123412731859");
            students[3] = new Student("Picanya", "E2Q", "Vicent", 46210, "ES801233165412731859");
            students[4] = new Student("Valencia", "E2Y", "Jose Carlos", 46200, "ES803453123412731859");
            students[5] = new Student("Valencia", "E2X", "Juansa", 46200, "ES801233128752731859");
            students[6] = new Student("Montserrat", "E2Z", "Daniel Gil", 46192, "ES801273123412731859");
            students[7] = new Student("Valencia", "E3A", "Ignacio", 46200, "ES801231234512731859");
            students[8] = new Student("Valencia", "E3B", "Eusebio", 46200, "ES801235123412731859");
            students[9] = new Student("Valencia", "E3C", "Clara", 46200, "ES801234123412731859");

            for (int i = 0; i < students.Length; i++)
            {
                dal.Insert<Student>(students[i]);
            }

            dal.Commit();

            Enrollment[] enrollments = new Enrollment[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                if (i == 2) enrollments[i] = new Enrollment(System.DateTime.Now, false, students[i], aTaughtCourse1);
                else
                {
                    enrollments[i] = new Enrollment(System.DateTime.Now, true, students[i], aTaughtCourse1);
                }
                dal.Insert<Enrollment>(enrollments[i]);
            }
            dal.Commit();

            Classroom c1 = new Classroom(15, "DSIC1");
            Classroom c2 = new Classroom(20, "DSIC2");

            c1.TaughtCourses.Add(aTaughtCourse1);
            c2.TaughtCourses.Add(aTaughtCourse2);

            dal.Insert<Classroom>(c1);
            dal.Insert<Classroom>(c2);
            dal.Commit();

            Absence a1 = new Absence(new DateTime(2024, 10, 24, 12, 00, 00));
            Absence a2 = new Absence(new DateTime(2024, 10, 25, 15, 00, 00));

            dal.GetById<Enrollment>(enrollments[0].Id).Absences.Add(a1);
            dal.GetById<Enrollment>(enrollments[0].Id).Absences.Add(a2);
            dal.Commit(); //Faltaba esta part

        }


        private void PrintSampleDB(IDAL dal)
        {
            Console.WriteLine("\n\nMOSTRANDO LOS DATOS DE LA BD");
            Console.WriteLine("============================\n");

            Console.WriteLine("\nCursos creados:");
            foreach (Course c in dal.GetAll<Course>())
                Console.WriteLine("   Name: " + c.Name + " Description: " + c.Description);

            // Show the rest of the database
            Console.WriteLine("\nProfesores creados:");
            foreach (Teacher t in dal.GetAll<Teacher>())
                Console.WriteLine("   ID: " + t.Id + " Name: " + t.Name);

            Console.WriteLine("\nImparticiones de cursos creados:");
            foreach (Course c in dal.GetAll<Course>())
            {
                Console.WriteLine("   Name: " + c.Name + " Description: " + c.Description);
                foreach (TaughtCourse tc in c.TaughtCourses)
                    Console.WriteLine("      ID: " + tc.Id + " START: " + tc.StartDateTime + " END: " + tc.EndDate);
            }

            Console.WriteLine("\nInscripciones por curso a impartir:");
            foreach (Course c in dal.GetAll<Course>())
            {
                Console.WriteLine("   Name: " + c.Name + " Description: " + c.Description);
                foreach (TaughtCourse tc in c.TaughtCourses)
                {
                    Console.WriteLine("      ID: " + tc.Id + " START: " + tc.StartDateTime + " END: " + tc.EndDate);
                    foreach (Enrollment en in tc.Enrollments)
                        Console.WriteLine("      ---> Student: " + en.Student.Name + " Enrollment Date: " + en.EnrollmentDate);
                }

            }

            Console.WriteLine("\nAulas creadas y sus asignaciones");
            foreach (Classroom o in dal.GetAll<Classroom>())
            {
                Console.WriteLine("   Name: " + o.Name + " Capacity: " + o.MaxCapacity);
                foreach (TaughtCourse tc in o.TaughtCourses)
                    Console.WriteLine("      CourseID: " + tc.Id + " START: " + tc.StartDateTime + " END: " + tc.EndDate + " People: " + tc.Enrollments.Count);
            }

            Console.WriteLine("\nFaltas de asistencia por alumno");
            foreach (Student s in dal.GetAll<Student>())
            {
                Console.WriteLine("   Student Name: " + s.Name);
                foreach (Enrollment en in s.Enrollments)
                {
                    Console.WriteLine("      Enrollment in: " + en.TaughtCourse.Id + " Course name: " + en.TaughtCourse.Course.Name + " Absences: " + en.Absences.Count);
                    foreach (Absence ab in en.Absences)
                        Console.WriteLine("         Date: " + ab.Date);
                }

            }
        }

    }

}