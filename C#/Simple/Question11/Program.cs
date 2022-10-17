// See https://aka.ms/new-console-template for more information
using System;
namespace Question11;
class Program 
{
    public static void Main(string[] args)
    {
        int output=1;
        System.Console.WriteLine("Enter X: ");
        int x=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Y: ");
        int y=int.Parse(Console.ReadLine());
        for (int i=1;i<=y;i++)
        {
            output*=x;
            

            

        }
         System.Console.WriteLine(output);
        
    }
}