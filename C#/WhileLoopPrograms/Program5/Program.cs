// See https://aka.ms/new-console-template for more information
using System;
namespace Program5;
class Program
{
    public static void Main(string[] args)
    {
        int n=0,number1=0;
        
        int sum=0;
        while(n<3)
        {
            System.Console.WriteLine("Enter the Number");
            number1=int.Parse(Console.ReadLine());
            
            sum=sum+number1;            
            n++;
            

        }
        System.Console.WriteLine($"sum of digit of{number1}{number1}{number1} is{sum}");
        
    }
}
