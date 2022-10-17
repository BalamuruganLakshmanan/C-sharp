// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius");
        int radius=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the height");
        double height=double.Parse(Console.ReadLine());
        double volume=3.14*(radius*radius)*height;
        System.Console.WriteLine("Volume:" +volume);
    }
}
