// See https://aka.ms/new-console-template for more information
using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the starting number:");
        int start=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the difference: ");
        int difference=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number of elemnents: ");
        int element=int.Parse(Console.ReadLine());
        for(int i=1;i<element;i++)
        {
            int total=start+difference;
            start=total;
            System.Console.WriteLine(total);
        }
    }
}
