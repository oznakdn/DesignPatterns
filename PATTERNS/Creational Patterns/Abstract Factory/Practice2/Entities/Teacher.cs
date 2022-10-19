using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice2.Entities
{
    public class Teacher:ISchool
    {
        public int No { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }

        public Teacher(int no, string teacherName, string teacherSurname)
        {
            No = no;
            TeacherName = teacherName;
            TeacherSurname = teacherSurname;
        }

        public void Add()
        {
            Console.WriteLine($"No: {No} Name: {TeacherName} Surname: {TeacherSurname}");
            
        }

        public void List()
        {
            var teachers = new List<Teacher>{};
             foreach (var item in teachers)
             {
                Console.WriteLine(item.No);
                Console.WriteLine(item.TeacherName);
                Console.WriteLine(item.TeacherSurname);

             }
        }
    }
}