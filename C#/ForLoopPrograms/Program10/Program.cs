// See https://aka.ms/new-console-template for more information
using System;
namespace Program10;
class Program 
{
    public static void Main(string[] args)
    {
        int i,temp=0;
        System.Console.WriteLine("Enter the Number");
        int number=int.Parse(Console.ReadLine());
        for(i=1;i<=number;i++)
        {
            if(number%i==0)
            {
                temp++;
            }
        }
        if(temp==2)
        {
            System.Console.WriteLine("The given number is prime");
        }
        else
        {
            System.Console.WriteLine("The number is not Prime");
        }
    }
}
