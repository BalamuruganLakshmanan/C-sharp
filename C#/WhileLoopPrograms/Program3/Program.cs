// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());
        int number1=0;
        int number2=1;
        int number3;
        System.Console.WriteLine(number1+" "+number2+" ");
        while((number-1)!=0)
        {
            number3=number1+number2;
            System.Console.WriteLine(number3+" ");
            number1=number2;
            number2=number3;
            --number;
        }
    }
}
