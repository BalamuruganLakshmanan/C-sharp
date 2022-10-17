// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the speed in km/hr");
        int speed=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Time in seconds");
        int second=int.Parse(Console.ReadLine());
        double distance=(speed*second*5/18);
        System.Console.WriteLine("Output:" +distance +" Meters");
    }
}