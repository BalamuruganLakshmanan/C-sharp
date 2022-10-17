// See https://aka.ms/new-console-template for more information
using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the money");
        int money=int.Parse(Console.ReadLine());
        double oneusd=0.0122;
        double oneeur=0.0127;
        double onecny=0.0879;
        double newamount1=money*oneusd;
        double newamount2=money*oneeur;
        double newamount3=money*onecny;
        System.Console.WriteLine("Rate: "+money+" Rs");
        System.Console.WriteLine("USD: "+newamount1);
        System.Console.WriteLine("EUR: "+newamount2);
        System.Console.WriteLine("CNY: "+newamount3);
    }
}