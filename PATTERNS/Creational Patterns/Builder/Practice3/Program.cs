// See https://aka.ms/new-console-template for more information
using Practice3;

Console.WriteLine("Hello, World!");
IComputerBuilder computer =ComputerBuilder.GetBuilder();
computer.BuildCpu();
computer.BuildDisplay();
computer.BuildRam();
computer.Build();
