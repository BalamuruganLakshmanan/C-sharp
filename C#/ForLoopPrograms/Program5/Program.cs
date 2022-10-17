// See https://aka.ms/new-console-template for more information
using System;
namespace Program5;
class Program 
{
    public static void Main(string[] args)
    {
        int sum=0;
        System.Console.WriteLine("Input number of terms :");
        int input=int.Parse(Console.ReadLine());
        for(int i =1;i<=input;i++)
        {
            if(i%2!=0)
            {
                sum=sum+i;
                System.Console.WriteLine("The odd numbers are "+i);
            }
           
        }
         System.Console.WriteLine("The Sum of odd Natural Number upto"+input+" terms :"+sum);
    }
}
