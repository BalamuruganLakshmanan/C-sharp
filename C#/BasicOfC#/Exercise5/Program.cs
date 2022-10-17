// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the physics Mark");
        int physicsMark=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the chemistry Mark");
        int chemistryMark=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the maths mark");
        int mathsMark=int.Parse(Console.ReadLine());
        int sum=physicsMark+chemistryMark+mathsMark;
        int percent=(sum/3);
        System.Console.WriteLine("Sum=" +sum);
        System.Console.WriteLine("Percentage="+percent);
    }
}
