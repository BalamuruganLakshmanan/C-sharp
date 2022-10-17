// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the limit");
        int n=int.Parse(Console.ReadLine());
        for (int i=1;i<=n;i++)
        {
            System.Console.WriteLine(i);
           
        }
    }
}
