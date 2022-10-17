// See https://aka.ms/new-console-template for more information
using System;
namespace Program4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the number (Table to be calculated) :");
        int number=int.Parse(Console.ReadLine());
        for (int i=1;i<=10;i++)
        {
            int multiplication=i*number;
            System.Console.WriteLine(number+" X "+i+"="+multiplication );
        }
    }
}