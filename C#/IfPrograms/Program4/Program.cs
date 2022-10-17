// See https://aka.ms/new-console-template for more information
using System;
namespace Program4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number 1");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Number 2");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Number 3");
        int number3=int.Parse(Console.ReadLine());
        if(number1>number2 && number1>number3)
        {
            System.Console.WriteLine("1st Number is greatest among three");
        }
        else if(number2>number1 && number2>number3)
        {
            System.Console.WriteLine("2nd Number is greatest among three");
        }
        else
        {
            System.Console.WriteLine("3rd Number is greatest among three");
        }
    }
}
