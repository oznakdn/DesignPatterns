using Practice.Models;

namespace Practice;
public class ComputerBuilder : IComputerBuilder
{
    private Computer computer;
   
    public Computer BuildComputer()
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

    public Cpu BuildCpu()
    {
        Cpu cpu = new();
        computer.SetCpu(cpu);
        return cpu;
    }

    public Display BuildDisplay()
    {
        Display display = new();
        computer.SetDisplay(display);
        return display;
    }

    public GraphicCard BuildGraphicCard()
    {
        GraphicCard graphicCard = new();
        computer.SetGraphicCard(graphicCard);
        return graphicCard;
    }

    public HardDrive BuildHardDrive()
    {
        HardDrive hardDrive = new();
        computer.SetHardDrive(hardDrive);
        return hardDrive;
    }

    public Ram BuildRam()
    {
        Ram ram = new();
        computer.SetRam(ram);
        return ram;
    }
}
