// See https://aka.ms/new-console-template for more information
using System;
namespace ByNoOfArguments;
class Program 
{
    static void Display( int number)
        {
            System.Console.WriteLine("Number "+number);
        }

    static void Display(int number1,int number2)
    {
        System.Console.WriteLine("Augument 1: "+number1);
        System.Console.WriteLine("Augument 2: "+number2);

    }
    public static void Main(string[] args)
    {
        Display(100);
        Display(100,10);
        
    }
}
