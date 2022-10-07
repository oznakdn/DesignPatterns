namespace Uygulama.Elevator
{
    public interface IElevator
    {
       
        void Go(Floor desiredFloor);

        void OpenDoor();

        void CloseDoor();
    }
}