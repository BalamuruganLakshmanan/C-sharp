// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the  amount of celcius");
        float celcius=float.Parse(Console.ReadLine());
        double kelvin= celcius + 273.15 ;
        int num1=9;
        int num2=5;
        float fahrenheit=((celcius*num1/num2)+(32));
        Console.WriteLine("Kelvin=" +kelvin);
        Console.WriteLine("fahrenheit="+fahrenheit);
        System.Console.WriteLine();
        Console.ReadLine();
        
    }
}