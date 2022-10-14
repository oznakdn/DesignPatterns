namespace Practice.Entities
{
    public class Vehicle
    {

        public Vehicle(string name, int maxSpeed, int year, string brand, int enginePower, string road)
        {
            this.Name = name;
            this.MaxSpeed = maxSpeed;
            this.Year = year;
            this.Brand = brand;
            this.EnginePower = enginePower;
            this.Road = road;
            this.Go();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public int EnginePower { get; set; }
        public string Road { get; set; }
        
        private string roadDescription;
        public string RoadDescription
        {
            get => roadDescription;
            set 
            {
                Go();
            }
        }

        public void Go()
        {
            roadDescription = $"{Name} goes the {Road}";
        }




    }
}