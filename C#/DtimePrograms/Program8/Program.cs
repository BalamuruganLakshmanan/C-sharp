using System;
namespace Program8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date1: ");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter the date2: ");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        if(date1>date2)
        {
            System.Console.WriteLine(date2+"Lesser than "+date1);
        }
        else 
        {
            System.Console.WriteLine(date1+"is Lesser than "+date2);
        }
    }
}
