using Uygulama.Elevator;

Console.WriteLine("ResponsibleElevatorTest");

IElevator elevator = new ResponsibleElevator();
elevator.OpenDoor();  // Get into the elevator
elevator.Go(Floor.FIFTH);

elevator.OpenDoor(); // Somebody is coming :)
elevator.Go(Floor.FIRST);
elevator.Go(Floor.FIFTH);





