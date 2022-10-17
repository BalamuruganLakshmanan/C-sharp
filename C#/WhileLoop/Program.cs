// See https://aka.ms/new-console-template for more information
using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<=25)
        {
            if(i%2==0)
            {
                System.Console.WriteLine("Even Number is" +i);
            }
            i++;
            
        }
        int number;
        System.Console.WriteLine("Enter the number:");
        bool temp=int.TryParse(Console.ReadLine(),out number);
        while(temp==false)
        {
           System.Console.WriteLine("Invalid input format.Please enter the input in number format");
           System.Console.WriteLine("Enter the number:");
           temp=int.TryParse(Console.ReadLine(),out number);
        }       
    }
}
