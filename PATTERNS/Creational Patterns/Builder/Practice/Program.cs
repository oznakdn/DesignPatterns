// See https://aka.ms/new-console-template for more information
using Practice;
using Practice.Models;

Console.WriteLine("Hello, World!");

IComputerBuilder builder = new ComputerBuilder();
Computer computer = builder.BuildComputer();


Ram ram = builder.BuildRam();