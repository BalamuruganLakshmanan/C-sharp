// See https://aka.ms/new-console-template for more information
using System;
namespace Program8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the sugar level information ");
        int sugarLevel=int.Parse(Console.ReadLine());
        if(sugarLevel<90)
        {
            System.Console.WriteLine("Low sugar");
        }
        else if(sugarLevel>=90 && sugarLevel<130)
        {
            System.Console.WriteLine("Normal");
        }
        else if(sugarLevel>=130 && sugarLevel<140)
        {
            System.Console.WriteLine("Medius");
        }
        else if(sugarLevel>=140 && sugarLevel<170)
        {
            System.Console.WriteLine("high sugar – try to reduce it from now");
        }
        else if(sugarLevel>170)
        {
            System.Console.WriteLine("You are a very high Sugar Patient ");
        }
    }
}
