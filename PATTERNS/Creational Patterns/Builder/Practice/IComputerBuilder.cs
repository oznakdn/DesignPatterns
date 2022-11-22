using Practice.Models;

namespace Practice;

    public interface IComputerBuilder
    {
        Ram BuildRam();
        Cpu BuildCpu();
        HardDrive BuildHardDrive();
        GraphicCard BuildGraphicCard();
        Display BuildDisplay();
        Computer BuildComputer();
        
    }
