using Practice2.Entities;
using Practice2.Factory;

namespace Practice2
{
    public class Client
    {
        public Client(ISchoolFactory factory)
        {
    
            
            ISchool student = factory.CreateStudent(new Student(1,"Ali","OKUR"));
            student.Add();
            student.List();

        }
    }
}