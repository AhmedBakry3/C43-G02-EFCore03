using Assignment_Session_1_EF_Core.DbContexts;
using Assignment_Session_1_EF_Core.Models;
using Assignment_Session_3_EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Assignment_Session_3_EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region Complete many to many relationships in your project.
            //I Created M:M RelationShip For Sutd_Course Table
            //I Created M:M RelationShip For Course_Inst Table
            #endregion


            #region Apply CRUD Operations (Insert, Select, Update, Delete) to your database.

            #region Insert Data

            #region Inserting Data in Student Table 
            //List<Student> students = new List<Student>()
            //{
            //    new Student() { FName="Ahmed", LName="Bakry" , Address="Maadi",Age=23},
            //    new Student() { FName="Zeyad", LName="Mostafa" , Address="El Tahrir",Age=24},
            //    new Student() { FName="Ayman", LName="Mahmoud" , Address="Dokki",Age=25},
            //    new Student() { FName="Ahmed", LName="Ayman" , Address="Helwan",Age=26},
            //};

            //foreach (var item in students)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Detached
            //}

            //dbContext.Students.AddRange(students);

            //foreach (var item in students)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Added
            //}

            //dbContext.SaveChanges();

            //foreach (var item in students)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Unchanged
            //}
            #endregion

            #region Inserting Data in Course Tables

            //List<Course> courses = new List<Course>()
            //{
            //    new Course() {Name ="ASP.NET", Duration= 120 , Description="Web development" },
            //    new Course() {Name ="Fluter", Duration= 130 , Description="Mobile development" },
            //    new Course() {Name ="Python", Duration= 140 , Description="Python development" },
            //    new Course() {Name ="Java", Duration= 150 , Description="Java development" },
            //};

            //foreach (var item in courses)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Detached
            //}

            //dbContext.Courses.AddRange(courses);

            //foreach (var item in courses)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Added
            //}

            //dbContext.SaveChanges();

            //foreach (var item in courses)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Unchanged
            //}
            #endregion

            #region Inserting Data in Instructor Table
            //List<Instructor> instructors = new List<Instructor>()
            //{
            //    new Instructor(){Name="Ahmed", Salary =5000, Bouns=11,HourRate=10, Address="Maadi"},
            //    new Instructor(){Name="Mohamed", Salary =6000, Bouns=12,HourRate=11, Address="Dokki"},
            //    new Instructor(){Name="Mostafa", Salary =7000, Bouns=13,HourRate=12, Address="El Tahrir"},
            //    new Instructor(){Name="Zeyad", Salary =8000, Bouns=14,HourRate=13, Address="Helwan"},
            //};

            //foreach (var item in instructors)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Detached
            //}

            //dbContext.Instructors.AddRange(instructors);

            //foreach (var item in instructors)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Added
            //}

            //dbContext.SaveChanges();

            //foreach (var item in instructors)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Unchanged
            //}
            #endregion

            #region Insering Data in Stud_Course Tables

            //List<Stud_Course> stud_Courses = new List<Stud_Course>()
            //        {
            //            new Stud_Course(){Stud_ID=1,Course_ID=1,Grade=50 },
            //            new Stud_Course(){Stud_ID=2,Course_ID=2,Grade=60 },
            //            new Stud_Course(){Stud_ID=3,Course_ID=3,Grade=70 },
            //            new Stud_Course(){Stud_ID=4,Course_ID=4,Grade=80 },
            //        };

            //foreach (var item in stud_Courses)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Detached
            //}

            //dbContext.Set<Stud_Course>().AddRange(stud_Courses);

            //foreach (var item in stud_Courses)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Added
            //}

            //dbContext.SaveChanges();

            //foreach (var item in stud_Courses)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Unchanged
            //}


            #endregion

            #region Inserting Data in Course_Inst Table

            //List<Course_Inst> course_Insts = new List<Course_Inst>()
            //{
            //    new Course_Inst(){Course_ID=1,Inst_ID=1,Evaluate=50},
            //    new Course_Inst(){Course_ID=2,Inst_ID=2,Evaluate=60},
            //    new Course_Inst(){Course_ID=3,Inst_ID=3,Evaluate=70},
            //    new Course_Inst(){Course_ID=4,Inst_ID=4,Evaluate=80},
            //};
            //foreach (var item in course_Insts)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Detached
            //}
            //dbContext.Set<Course_Inst>().AddRange(course_Insts);

            //foreach (var item in course_Insts)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Added
            //}

            //dbContext.SaveChanges();

            //foreach (var item in course_Insts)
            //{
            //    Console.WriteLine(dbContext.Entry(item).State); //Unchanged
            //}
            #endregion
            #endregion

            #region Select Data 

            #region Select Data From Student
            //var students = dbContext.Students.AsNoTracking().FirstOrDefault(S=>S.FName == "Ahmed");

            //if (students is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(students).State); //Detached

            //    Console.WriteLine(students.Id); //1

            //    Console.WriteLine(dbContext.Entry(students).State); //Detached

            //}
            #endregion

            #region Select Data From Course
            //var Courses = dbContext.Courses.AsNoTracking().FirstOrDefault(C => C.Name == "Python");

            // if (Courses is not null)
            //{                
            //        Console.WriteLine(dbContext.Entry(Courses).State); //Detached

            //        Console.WriteLine(Courses.Description); //Python development

            //    Console.WriteLine(dbContext.Entry(Courses).State); //Detached
            //}
            #endregion

            #region Select Data From Instructor

            //var Instrusctors = dbContext.Instructors.AsNoTracking().Where(I => I.HourRate > 10).FirstOrDefault();

            //if(Instrusctors is not  null)
            //{
            //    if (Instrusctors is not null)
            //    {
            //        Console.WriteLine(dbContext.Entry(Instrusctors).State); //Detached

            //        Console.WriteLine(Instrusctors.Name); //Mohamed

            //        Console.WriteLine(dbContext.Entry(Instrusctors).State); //Detached
            //    }
            //}
            #endregion

            #region Select Data From Stud_Couse 
            //var Stud_Course = dbContext.Set<Stud_Course>().AsNoTracking().FirstOrDefault(SC=>SC.Grade>50);

            //if (Stud_Course is not null) 

            //{
            //            Console.WriteLine(dbContext.Entry(Stud_Course).State); //Detached

            //            Console.WriteLine(Stud_Course.Stud_ID); //2

            //            Console.WriteLine(dbContext.Entry(Stud_Course).State); //Detached
            //}
            #endregion

            #region Select Data From Course_Inst

            //var Course_Inst = dbContext.Set<Course_Inst>().AsNoTracking().FirstOrDefault(CI=>CI.Evaluate>5);

            //if (Course_Inst is not null) 
            //{

            //    Console.WriteLine(dbContext.Entry(Course_Inst).State); //Detached

            //    Console.WriteLine(Course_Inst.Course_ID); //1

            //    Console.WriteLine(dbContext.Entry(Course_Inst).State); //Detached
            //}
            #endregion
            #endregion

            #region Update Data 

            #region Update Data in Student Table 
            //var students = dbContext.Students.FirstOrDefault(S => S.Id==1);

            //if (students is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(students).State); //Unchanged

            //    students.FName = "Salma";

            //    Console.WriteLine(dbContext.Entry(students).State); //Modified

            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(students).State); //Unchanged
            //}
            #endregion

            #region Update Data in Course Table
            //var Course = dbContext.Courses.FirstOrDefault(C=>C.Name == "Python");

            //if (Course is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(Course).State); //Unchanged

            //    Course.Name = "JavaScript";

            //    Console.WriteLine(dbContext.Entry(Course).State); //Modified

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Course).State); //Unchanged
            //}
            #endregion

            #region Update Data in Instructor Table
            //var Instructors = dbContext.Instructors.FirstOrDefault(I => I.Name == "Ahmed");

            //if (Instructors is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(Instructors).State); //Unchanged

            //    Instructors.Name = "Mohamed";

            //    Console.WriteLine(dbContext.Entry(Instructors).State); //Modified

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Instructors).State); //Unchanged
            //}
            #endregion

            #region Update Data in Stud_Couse Table

            //var Stud_Course = dbContext.Set<Stud_Course>().FirstOrDefault(SC=>SC.Grade == 50);

            //if (Stud_Course is not null)

            //{
            //    Console.WriteLine(dbContext.Entry(Stud_Course).State); //Unchanged

            //    Stud_Course.Grade = 100;

            //    Console.WriteLine(dbContext.Entry(Stud_Course).State); //Modified

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Stud_Course).State); //Unchanged
            //}
            #endregion

            #region Update Data in Course_Inst Table

            //var Course_inst = dbContext.Set<Course_Inst>().FirstOrDefault(CI=>CI.Evaluate == 50);

            //if(Course_inst is not null ) 
            //{
            //    Console.WriteLine(dbContext.Entry(Course_inst).State); //Unchanged

            //    Course_inst.Evaluate = 80;

            //    Console.WriteLine(dbContext.Entry(Course_inst).State); //Modified

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Course_inst).State); //Unchanged
            //}
            #endregion
            #endregion

            #region Delete Data
            #region Delete Data From Student Table
            //var Students = dbContext.Students.FirstOrDefault(E=>E.LName=="Ayman");

            //if (Students is not null)
            //{

            //    Console.WriteLine(dbContext.Entry(Students).State); //Unchanged

            //    dbContext.Students.Remove(Students);

            //    Console.WriteLine(dbContext.Entry(Students).State); //Deleted

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Students).State); //Detached

            //}
            #endregion

            #region Delete Data From Course Table
            //var Course = dbContext.Courses.FirstOrDefault(C => C.Name == "Python");

            //if (Course is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(Course).State); //Unchanged

            //    dbContext.Courses.Remove(Course);

            //    Console.WriteLine(dbContext.Entry(Course).State); //Deleted

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Course).State); //Detached
            //}
            #endregion

            #region Delete Data From Instructor Table
            //var Instructors = dbContext.Instructors.FirstOrDefault(I => I.Name == "Ahmed");

            //if (Instructors is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(Instructors).State); //Unchanged

            //    dbContext.Instructors.Remove(Instructors);

            //    Console.WriteLine(dbContext.Entry(Instructors).State); //Deleted

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Instructors).State); //Detached
            //}
            #endregion

            #region Delete From Stud_Course Table

            //var Stud_Course = dbContext.Set<Stud_Course>().FirstOrDefault(SC=>SC.Grade == 60);

            //if (Stud_Course is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(Stud_Course).State); //Unchanged

            //    dbContext.Set<Stud_Course>().Remove(Stud_Course);

            //    Console.WriteLine(dbContext.Entry(Stud_Course).State); //Deleted

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Stud_Course).State); //Detached
            //}
            #endregion

            #region Delete From Course_Inst Table
            //var Course_Inst = dbContext.Set<Course_Inst>().FirstOrDefault(CI=>CI.Evaluate == 60);

            //if (Course_Inst is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(Course_Inst).State); //Unchanged

            //    dbContext.Set<Course_Inst>().Remove(Course_Inst);

            //    Console.WriteLine(dbContext.Entry(Course_Inst).State); //Deleted

            //    dbContext.SaveChanges();

            //    Console.WriteLine(dbContext.Entry(Course_Inst).State); //Detached
            //}
            #endregion
            #endregion
            #endregion

            #region Try to retrieve data using eager & lazy loading.

            #region By Using Eager Loading

            #region Get Grade In student_Course & CourseId From Student By Using Eager Loading

            //var student = dbContext.Students.Include(S => S.stud_Courses)
            //                               .FirstOrDefault(S => S.Id == 1);

            //if (student is not null)
            //{
            //    Console.WriteLine($"StudentFirstName : {student.FName}"); //Salma

            //    foreach (var item in student.stud_Courses)
            //    {
            //        Console.WriteLine($"Course ID: {item.Course_ID} , StudentGradeInCourse: {item.Grade}");//Course ID: 1 , StudentGradeInCourse: 100.00
            //        //Related Data load By Using Eager Loading
            //    }
            //}
            #endregion

            #region Get Instructor_ID & Evaluate From Course By Using Eager Loading
            //var Course = dbContext.Courses.Include(C => C.course_inst)
            //                              .FirstOrDefault(C => C.CourseId == 1);

            //if (Course is not null)
            //{
            //    Console.WriteLine(Course.Name); //ASP.NET

            //    foreach (var item in Course.course_inst)
            //    {
            //        Console.WriteLine($"InstructorID : {item.Inst_ID} , Evaluate : {item.Evaluate}"); //InstructorID : 1 , Evaluate : 80
            //        Related Data load By Using Eager Loading
            //    }
            //};
            #endregion


            #endregion

            #region By Using Lazy Loading

            #region Get Grade In student_Course & CourseId From Student By Using Eager Loading

            var student = dbContext.Students.FirstOrDefault(S => S.Id == 1);

            if (student is not null)
            {
                Console.WriteLine($"StudentFirstName : {student.FName}"); //Salma

                foreach (var item in student.stud_Courses)
                {
                    Console.WriteLine($"Course ID: {item.Course_ID} , StudentGradeInCourse: {item.Grade}");//Course ID: 1 , StudentGradeInCourse: 100.00
                    //Related Data load By Using Lazy Loading
                }
            }
            #endregion

            #region Get Instructor_ID & Evaluate From Course By Using Lazy Loading
            var Course = dbContext.Courses.FirstOrDefault(C => C.CourseId == 1);

            if (Course is not null)
            {
                Console.WriteLine(Course.Name); //ASP.NET

                foreach (var item in Course.course_inst)
                {
                    Console.WriteLine($"InstructorID : {item.Inst_ID} , Evaluate : {item.Evaluate}"); //InstructorID : 1 , Evaluate : 80
                    //Related Data load By Using Lazy Loading
                }
            };

            #endregion


            #endregion
            #endregion

        }
    }
}
