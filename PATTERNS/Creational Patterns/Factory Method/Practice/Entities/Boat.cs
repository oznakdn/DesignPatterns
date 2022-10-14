using Practice.Enums;

namespace Practice.Entities
{
    public class Boat:Vehicle
    {
        public Boat(string name, int maxSpeed, int year, string brand, int enginePower, string road, BoatCaseType boatCaseType)
        :base(name,maxSpeed,year,brand,enginePower,road)
        {
            this.Name = name;
            this.MaxSpeed = maxSpeed;
            this.Year = year;
            this.Brand = brand;
            this.EnginePower = enginePower;
            this.Road = road;
            this.BoatCaseType = boatCaseType;
            this.Go();
        }
        public BoatCaseType BoatCaseType{get;set;}
    }
}