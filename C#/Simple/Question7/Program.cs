// See https://aka.ms/new-console-template for more information
using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input ");
        int input=int.Parse(Console.ReadLine());
        if(input<100)
        {
            System.Console.WriteLine("Less than 100");
        }
        else if(input>=100 && input<200)
        {
            System.Console.WriteLine("Between 100 and 200");
        }
        else if(input>200)
        {
            System.Console.WriteLine("Over 200");
        }
    }
}
