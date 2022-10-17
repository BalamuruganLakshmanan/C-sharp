// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program 
{
    public static void Main(string[] args)
    {
        Factorial();
        void Factorial()
        {
            int fact=1;
            System.Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
            for(int i=1;i<=number;i++)
            {
                fact=fact*i;
            }
        System.Console.WriteLine("The factorial of "+number+"! is "+fact);
        }
    }
}
