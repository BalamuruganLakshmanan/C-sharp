using System;
namespace Program2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date time: ");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
        System.Console.WriteLine("Complete date:"+date.ToString("dd/MM/yyyy  HH:mm:ss tt"));
        System.Console.WriteLine("Short date: "+date.ToShortDateString());
        System.Console.WriteLine("Long date Time: "+date.ToLongDateString());
        System.Console.WriteLine("12 hrs Format: "+date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        System.Console.WriteLine("Date: "+date.ToString("dd/MM/yyyy",null));
        System.Console.WriteLine("Time : "+date.ToString("HH:mm:ss tt"));
        
        
    }
}
