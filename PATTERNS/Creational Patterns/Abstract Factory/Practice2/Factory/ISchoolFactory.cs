using Practice2.Entities;

namespace Practice2.Factory
{
    public interface ISchoolFactory
    {
        ISchool CreateTeacher(Teacher teacher);
        ISchool CreateStudent(Student student);   
    }
}