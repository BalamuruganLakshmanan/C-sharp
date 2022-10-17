// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program
{
    public static void Main(string[] args)
    {
        string choice;
        do
        {
            System.Console.WriteLine("Enter the range:");
            int range=int.Parse(Console.ReadLine());
            int number1=0;
            int number2=1;
            int number3;
            System.Console.WriteLine(number1+" "+number2+ " ");
            while((range-2) !=0)
            {
                number3=number1+number2;
                System.Console.WriteLine(number3);
                number1=number2;
                number2=number3;
                --range;
            }
            System.Console.WriteLine("do you want to repeat this process");
            choice=Console.ReadLine().ToLower();
            if(choice!="yes" && choice!="NO")
            {
                System.Console.WriteLine("INVALID INPUT");
            }
        }while(choice=="yes");
    }
}