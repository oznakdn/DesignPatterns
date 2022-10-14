using Practice.Data;
using Practice.Entities;
using Practice.Enums;

namespace Practice.Factories
{
    public class MotorcycleFactory : IFactory
    {
        public Vehicle Add()
        {
            Motorcycle newMotorcycle = new Motorcycle("Motorcycle",120,2022,"Yamaha",1100,"Highway",MotorcycleCaseType.Commuter);
            using var context = new AppDbContext();
            context.Motorcycles.Add(newMotorcycle);
            context.SaveChanges();
            return newMotorcycle;
        }
    }
}