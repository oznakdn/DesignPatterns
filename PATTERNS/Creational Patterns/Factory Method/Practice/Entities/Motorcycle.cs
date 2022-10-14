using Practice.Enums;

namespace Practice.Entities
{
    public class Motorcycle:Vehicle
    {
        public Motorcycle(string name, int maxSpeed, int year, string brand, int enginePower, string road,MotorcycleCaseType motorcycleCase)
        : base(name,maxSpeed,year,brand,enginePower,road)
        {
            this.Name = name;
            this.MaxSpeed = maxSpeed;
            this.Year = year;
            this.Brand = brand;
            this.EnginePower = enginePower;
            this.Road = road;
            this.MotorcycleCase = motorcycleCase;
            this.Go();
        }
    
            
        
        public MotorcycleCaseType MotorcycleCase { get; set; }
        
        
    }
}