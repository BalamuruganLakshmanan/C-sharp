// See https://aka.ms/new-console-template for more information
using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the rows ");
        int rows=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the column ");
        int column=int.Parse(Console.ReadLine());
        for(int i=1;i<=rows;i++)
        {
            for(int j=column;j>=1;j--)
            {
                System.Console.WriteLine(" ");
            }
            for(int j= 1;j<=i;j++)
            {
                System.Console.WriteLine(("*")+" ");
            }
            System.Console.WriteLine("\n");
            column--;
            
               
           
           
            
            
        }
    }
}
