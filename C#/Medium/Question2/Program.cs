// See https://aka.ms/new-console-template for more information
using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        int number1=0,number2=1,number3;
        System.Console.WriteLine("Enter the limit: ");
        int limit=int.Parse(Console.ReadLine());
        System.Console.WriteLine(+number2+" ");
        for (int i=1;i<limit;i++)
        {
            number3=number1+number2;
            number1=number2;
            number2=number3;
            System.Console.WriteLine(number3);

        }
    }
}
