// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program
{
    public static void Main(string[] args)
    {
        string choice;
        do
        {
            System.Console.WriteLine("Enter the input");
            int input=int.Parse(Console.ReadLine());
            if(input%2==0)
            {
                System.Console.WriteLine("The given number is even");
            }
            else 
            {
                System.Console.WriteLine("The given number is odd");
            }
            System.Console.WriteLine("Enter the input choice yes or no:");
            choice=Console.ReadLine().ToLower();
            if(choice!="yes" && choice !="no")
            {
                System.Console.WriteLine("Invalid input");
            }
            
        }while(choice=="yes");
    }
}
