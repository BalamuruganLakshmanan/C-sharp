using System;
namespace Program4;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2016,11,07);
        System.Console.WriteLine("Day for the week  "+date.ToString("dd/MM/yyyy")+" is "+date.DayOfWeek);
    }
}