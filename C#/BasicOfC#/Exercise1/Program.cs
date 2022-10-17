// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Name");
        string myName=Console.ReadLine();
        Console.WriteLine("Hello:" + myName);
        Console.WriteLine("Hello:{0}", myName);
        Console.WriteLine($"Hello:{myName}");
    }
}
