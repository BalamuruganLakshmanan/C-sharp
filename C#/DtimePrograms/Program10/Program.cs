// See https://aka.ms/new-console-template for more information
using System;
namespace Program10;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date: ");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime date1=date.AddDays(1);
        DateTime date2=date.AddDays(-1);
        System.Console.WriteLine("yesterday : "+date2);
        System.Console.WriteLine("Tomorrow : "+date1);
    }
}
