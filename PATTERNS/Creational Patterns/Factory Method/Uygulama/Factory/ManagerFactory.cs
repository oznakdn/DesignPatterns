using Uygulama.Department;

namespace Uygulama.Factory
{
    public class ManagerFactory : IFactory
    {
        public Employee Create()
        {
            string department = "Production";
            Manager manager = new Manager(2,"Buse",20,department,department);
            return manager;
        }
    }
}