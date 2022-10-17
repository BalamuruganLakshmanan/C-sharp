using System.Runtime.CompilerServices;
// See https://aka.ms/new-console-template for more information
using System;
namespace Program11;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date =DateTime.Now;
        System.Console.WriteLine("Current date time is: "+date);
        for(int i=1 ;i<=12;i++)
        {
            Console.WriteLine(" {0}",date.ToString("MMMM"));
            date=date.AddMonths(1);

        }
    }
}
