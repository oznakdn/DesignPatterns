namespace Practice2.Entities
{
    public class Student:ISchool
    {

        public int No { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }

        public Student(int no, string studentName, string studentSurname)
        {
             No = no;
             StudentName = studentName;
             StudentSurname = studentSurname;
        }

        public void Add()
        {
            Console.WriteLine($"No: {No} Name: {StudentName} Surname: {StudentSurname}");
        }

        public void List()
        {
             var studenst = new List<Student>
             {
                new Student (No=No,StudentName = StudentName, StudentSurname = StudentSurname)
             };
             foreach (var item in studenst)
             {
                Console.WriteLine(item.No);
                Console.WriteLine(item.StudentName);
                Console.WriteLine(item.StudentSurname);

             }
        }
    }
}