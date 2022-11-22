using Practice3.Models;

namespace Practice3;

    public interface IComputerBuilder
    {
        IComputerBuilder BuildRam();
        IComputerBuilder BuildCpu();
        IComputerBuilder BuildHardDrive();
        IComputerBuilder BuildGraphicCard();
        IComputerBuilder BuildDisplay();
        Computer Build();
        
    }
