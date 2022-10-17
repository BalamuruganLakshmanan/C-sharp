// See https://aka.ms/new-console-template for more information
using System;
namespace Proghram6;
class Program 
{
    public static void Main(string[] args)
    {
        int i,j,n,number1;
        System.Console.WriteLine("Enter the rows:");
        int rows=int.Parse(Console.ReadLine());
        number1=rows+4-1;
        for(i=1;i<=rows;i++)
        {
            for(n=number1;n>=1;n--)
            {
                System.Console.WriteLine(" ");
            }
            for(j=1;j<=i;j++)
            {
                System.Console.WriteLine("* ");
            }
            System.Console.WriteLine("\n");
            number1--;
        }
        
    }
}
