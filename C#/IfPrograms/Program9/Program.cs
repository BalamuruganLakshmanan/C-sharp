// See https://aka.ms/new-console-template for more information
using System;
namespace Program9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the  Month Name");
        string monthName=Console.ReadLine();
        if(monthName=="December"||monthName=="January" || monthName=="February" )
        {
            System.Console.WriteLine("Winter");
        }
        else if(monthName=="March" || monthName=="April" || monthName=="May")
        {
            System.Console.WriteLine("Spring");
        }
        else if(monthName=="June" || monthName=="July" || monthName=="August")
        {
            System.Console.WriteLine("Summer");
        }
        else if( monthName=="September" || monthName=="October"  || monthName=="November")
        {
            System.Console.WriteLine("Rainfall");
        }
        

        
    }
}
