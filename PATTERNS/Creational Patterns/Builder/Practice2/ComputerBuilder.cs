using Practice2.Models;

namespace Practice2;
public class ComputerBuilder : IComputerBuilder
{
    private Computer computer;
   
    public Computer Build()
    {
       computer = new();
       BuildRam();
       BuildCpu();
       BuildDisplay();
       BuildHardDrive();
       BuildGraphicCard();
       Console.WriteLine("Computer was created!");
       return computer;
    }

    private void BuildCpu()
    {
        Cpu cpu = new();
        computer.SetCpu(cpu);
    }

    private void BuildDisplay()
    {
        Display display = new();
        computer.SetDisplay(display);
    }

    private void BuildGraphicCard()
    {
        GraphicCard graphicCard = new();
        computer.SetGraphicCard(graphicCard);
    }

    private void BuildHardDrive()
    {
        HardDrive hardDrive = new();
        computer.SetHardDrive(hardDrive);
    }

    private void BuildRam()
    {
        Ram ram = new();
        computer.SetRam(ram);
    }
}
