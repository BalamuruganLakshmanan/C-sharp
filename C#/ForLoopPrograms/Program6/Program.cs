// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program 
{
    public static void Main(string[] args)
    {
        int i,j;
        System.Console.WriteLine("Enter the rows");
        int rows=int.Parse(Console.ReadLine());
        for(i=1;i<=rows;i++)
        {
            for(j=1;j<=i;j++)
            {
                System.Console.WriteLine("*");
            }
            System.Console.WriteLine("\n");
        }
    }
}
