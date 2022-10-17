// See https://aka.ms/new-console-template for more information
using System;
namespace Program7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Customer ID:");
        int customerId=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the customer Name:");
        string customerName=Console.ReadLine();
        System.Console.WriteLine("Enter the unit consumed");
        int unitConsumed=int.Parse(Console.ReadLine());
        if(unitConsumed>0 && unitConsumed<=199)
        {
            double amount=unitConsumed*1.20;
        }
        else if(unitConsumed>=200 && unitConsumed<400)
        {
            double amount=unitConsumed*1.50;
        }
        else if(unitConsumed>=400 &&unitConsumed<600)
        {
            double amount=unitConsumed*1.80;
        }
        else if(unitConsumed>=600)
        {
            double amount=unitConsumed*2.00;
        }
        double unitAmount=;

    }
}
