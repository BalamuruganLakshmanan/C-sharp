// See https://aka.ms/new-console-template for more information
using System;
namespace ExceptionHandling;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number1");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Number2");
        int number2=int.Parse(Console.ReadLine());
        try
        {
            int output=number1/number2;
            System.Console.WriteLine("output");
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine("An Exception occurred:{0}",e.Message);
            System.Console.WriteLine("An Exception occurred: {0}",e.StackTrace);
        }
        catch(FormatException e)
        {
            System.Console.WriteLine("An Exception occurred : {0}",e.Message);
            System.Console.WriteLine("An Exception occurred :{0}",e.StackTrace);

        }
    }
}
