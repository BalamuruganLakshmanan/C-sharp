// See https://aka.ms/new-console-template for more information
using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the degrees on celsius");
        double degree=double.Parse(Console.ReadLine());
        double farenheit=degree*(9/5)+32;
        System.Console.WriteLine(degree+" degree on celsius to farenheit "+farenheit+".00");
    }
}