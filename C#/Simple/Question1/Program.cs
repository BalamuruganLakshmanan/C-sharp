// See https://aka.ms/new-console-template for more information
using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number in inches");
        double number=double.Parse(Console.ReadLine());
        double centimeter=2.54;
        double answer=number*centimeter;
        System.Console.WriteLine(number+" inches="+answer+ " cm");    


    }
}
