// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program 
{
    public static void Main(string[] args)
    {
        int i,j,n,number,number1=1;
        System.Console.WriteLine("Enter the number of rows:");
        int rows=int.Parse(Console.ReadLine());
        number=rows+4-1;
        for(i=1;i<=rows;i++)
        {
            for(n=number;n>=1;n--)
            {
                System.Console.WriteLine(" ");
            }
            for(j=1;j<=i;j++)
            {
                System.Console.WriteLine((number1++)+" ");
            }
            System.Console.WriteLine("\n");
            number--;
        }
    }
}