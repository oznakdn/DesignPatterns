using Practice.Data;
using Practice.Entities;
using Practice.Enums;

namespace Practice.Factories
{
    public class BoatFactory : IFactory
    {
        public Vehicle Add()
        {
            Boat newBoat = new Boat("Boat", 180, 2019, "Other Brand0", 3000, "Seaway", BoatCaseType.Composite);
            using var context = new AppDbContext();
            context.Boats.Add(newBoat);
            context.SaveChanges();
            return newBoat;
        }
    }
}