// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input a");
        int a=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the input b");
        int b=int.Parse(Console.ReadLine());
        int total=(a*a)+(2*a*b)+(b*b);
        System.Console.WriteLine("Ouput:"+total);   

    }
}
