// See https://aka.ms/new-console-template for more information
using System;
namespace Program9;
class Program 
{
    public static void Main(string[] args)
    {
        for(int i=1994;i<2015;i++)
        {
            if(DateTime.IsLeapYear(i))
            {
                System.Console.WriteLine(i +"is leap year");
            }
        }
    }
}
