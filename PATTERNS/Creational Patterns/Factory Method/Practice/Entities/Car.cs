using Practice.Enums;

namespace Practice.Entities
{
    public class Car:Vehicle
    {

        public Car(string name, int maxSpeed, int year, string brand, int enginePower, string road, int transmissionCount, string traction, CarCaseType carCaseType)
        :base(name,maxSpeed,year,brand,enginePower,road)
        {
            this.Name = name;
            this.MaxSpeed = maxSpeed;
            this.Year = year;
            this.Brand = brand;
            this.EnginePower = enginePower;
            this.Road = road;
            this.TransmissionCount = transmissionCount;
            this.Traction = traction;
            this.carCaseType = carCaseType;
            this.Go();
        }
        public int TransmissionCount { get; set; }
        public string Traction { get; set; }
        public CarCaseType carCaseType { get; set; }
    }
}