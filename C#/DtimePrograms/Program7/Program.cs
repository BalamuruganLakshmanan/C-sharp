// See https://aka.ms/new-console-template for more information
using System;
namespace Program7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a date1 : ");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
        System.Console.WriteLine("Enter a date2 : ");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);

        if(date1<date2)
        {
            System.Console.WriteLine(date1+ " is earlier than  "+date2);
        }
        else 
        {
            System.Console.WriteLine(date2+" is earlier than "+date1);
        }
    }
}
