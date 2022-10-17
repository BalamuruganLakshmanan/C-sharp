// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the price amount");
        int price=int.Parse(Console.ReadLine());
        double total=price+(price*0.18);
        System.Console.WriteLine("Total=" +total);
    }
}
