// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date time : ");
       DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
        System.Console.WriteLine("Year :"+date.ToString("yyyy"));
        System.Console.WriteLine("Month : "+date.ToString("MM"));
        System.Console.WriteLine("Day : "+date.ToString("dd"));
        System.Console.WriteLine("Hour : "+date.ToString("HH"));
        System.Console.WriteLine("Minute : "+date.ToString("mm"));
        System.Console.WriteLine("Second : "+date.ToString("ss"));
    }
}
