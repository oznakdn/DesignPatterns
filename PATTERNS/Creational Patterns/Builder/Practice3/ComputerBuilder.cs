using Practice3.Models;

namespace Practice3;
public class ComputerBuilder : IComputerBuilder
{
    private static ComputerBuilder builder = new ComputerBuilder();
    private Computer computer;
    private ComputerBuilder()
    {
        computer = new();

    }

    public static ComputerBuilder GetBuilder()
    {
        return builder;
    }

    public Computer Build()
    {
        Console.WriteLine("Computer was created!");
        return computer;
    }



    public IComputerBuilder BuildCpu()
    {
        Cpu cpu = new();
        computer.SetCpu(cpu);
        return builder;
    }

    public IComputerBuilder BuildDisplay()
    {
        Display display = new();
        computer.SetDisplay(display);
        return builder;
    }

    public IComputerBuilder BuildGraphicCard()
    {
        GraphicCard graphicCard = new();
        computer.SetGraphicCard(graphicCard);
        return builder;
    }

    public IComputerBuilder BuildHardDrive()
    {
        HardDrive hardDrive = new();
        computer.SetHardDrive(hardDrive);
        return builder;
    }

    public IComputerBuilder BuildRam()
    {
        Ram ram = new();
        computer.SetRam(ram);
        return builder;
    }
}
