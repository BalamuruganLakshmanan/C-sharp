// See https://aka.ms/new-console-template for more information
using System;
namespace Program2;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        string option;
        do
        {
            System.Console.WriteLine("Enter a Number");
            int number=int.Parse(Console.ReadLine());
            if(number>0)
            {
                sum=sum+number;
            }
            System.Console.WriteLine("Do you want to continue");
            option=Console.ReadLine().ToLower();
            if(option !="yes" &&  option!="no")
            {
                System.Console.WriteLine("Invalid input");
            }
        }while(option=="yes");
        System.Console.WriteLine("The sum of entered numbers are "+sum );
    }
}
