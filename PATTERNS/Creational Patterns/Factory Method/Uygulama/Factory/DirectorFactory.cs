using Uygulama.Department;

namespace Uygulama.Factory
{
    public class DirectorFactory:IFactory
    {
        
        public Employee Create()
        {
             Director director = new Director(1,"John",10,"Management","Management",10000);
             return director;
        }

    }
}