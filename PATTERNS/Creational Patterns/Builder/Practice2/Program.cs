// See https://aka.ms/new-console-template for more information
using Practice2;
using Practice2.Models;

Console.WriteLine("Hello, World!");

IComputerBuilder builder = new ComputerBuilder();
Computer computer = builder.Build();