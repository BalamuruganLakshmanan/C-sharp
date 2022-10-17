// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program3
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the year:");
        int year=int.Parse(Console.ReadLine());
        if((year%4==0) && (year%100!=0) || (year%400==0))
        {
            System.Console.WriteLine(year +" is a leap year");
        }
        else
        {
            System.Console.WriteLine(year  +" is not a leap year");
        }
    }
}
