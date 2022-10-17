// See https://aka.ms/new-console-template for more information
using System;
namespace Program4;
class Program 
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the value");
        bool value=int.TryParse(Console.ReadLine(),out number);
        while(value==false)
        {
            System.Console.WriteLine("Enter the value");
            value=int.TryParse(Console.ReadLine(),out number);
        }
        if(number >= 1 && number <=10)
        {
            System.Console.WriteLine(number);

        }
        
        
    }
}
