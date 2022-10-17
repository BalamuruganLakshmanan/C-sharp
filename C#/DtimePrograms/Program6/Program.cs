// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        DateTime date2=date.AddDays(40);
        System.Console.WriteLine("Today : "+date);
        System.Console.WriteLine(date2.DayOfWeek);
    }
}
