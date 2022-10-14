using Practice.Data;
using Practice.Entities;
using Practice.Enums;

namespace Practice.Factories
{
    public class CarFactory : IFactory
    {
        public Vehicle Add()
        {
            using var context = new AppDbContext();
            Car car = new Car("Car",220,2021,"Renault",1600,"Highway",5,"Front",CarCaseType.Sedan);
            context.Cars.Add(car);
            context.SaveChanges();
            return car;
        }
    }
}