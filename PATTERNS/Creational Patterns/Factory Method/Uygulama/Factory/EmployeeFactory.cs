using Uygulama.Department;

namespace Uygulama.Factory
{
    public class EmployeeFactory : IFactory
    {
        public Employee Create()
        {
            Employee employee = new Employee(1,"Ahmet",10,"IT");
            return employee;
        }
    }
}