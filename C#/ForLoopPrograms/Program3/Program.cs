// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program 
{
    public static void Main(string[] args)
    {
        int cube;
        System.Console.WriteLine("Enter the limit:");
        int limit=int.Parse(Console.ReadLine());
        for (int i =1;i<=limit;i++)
        {
            cube=i*i*i;
            System.Console.WriteLine("Number is "+i+"and the cube is"+cube);
        }
        
    }
}
