// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the integer:");
        int integer=int.Parse(Console.ReadLine());
        if(integer%2==0)
        {
            System.Console.WriteLine(integer +" is an Even integer");
        }
        else
        {
            System.Console.WriteLine(integer +" is an Odd integer");
        }
    }
}
