using Practice.Factories;

System.Console.WriteLine("Car add");
IFactory newCar = new CarFactory();
IFactory newBoat = new BoatFactory();
newCar.Add(); 
newBoat.Add();
