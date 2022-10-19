using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice2.Entities;

namespace Practice2.Factory
{
    public class SchoolFactory : ISchoolFactory
    {


        public ISchool CreateStudent(Student student)
        {
            return new Student(student.No, student.StudentName, student.StudentSurname);
        }


        public ISchool CreateTeacher(Teacher teacher)
        {
            return new Teacher(teacher.No, teacher.TeacherName, teacher.TeacherSurname);
        }
    }
}