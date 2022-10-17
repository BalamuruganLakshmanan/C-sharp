// See https://aka.ms/new-console-template for more information
using System;
namespace Program;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());
        int n,number1,sum=0;
        for(number1=number;number !=0;number=number/10)
        {
            n=number%10;
            sum=sum+(n*n*n);

        }
        if(number1==sum)
        {
            System.Console.WriteLine("The number is Armstrong");
        }
        else
        {
            System.Console.WriteLine("Not a Armstrong Number");
        }
        
    }
}
