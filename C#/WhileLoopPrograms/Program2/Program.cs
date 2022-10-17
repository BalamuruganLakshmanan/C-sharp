// See https://aka.ms/new-console-template for more information
using System;
namespace Program2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the count:");
        int count=int.Parse(Console.ReadLine());
        int i=1;
        int sum=0;
        while(i<=count)
        {
           sum=sum+(i*i);
           i++;
        }
        System.Console.WriteLine("Sum of squared Number is: "+sum);
    }
}
