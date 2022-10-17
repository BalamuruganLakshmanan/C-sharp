// See https://aka.ms/new-console-template for more information
using System;
namespace Program4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first integer");
        int firstInteger=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second integer");
        int secondInteger=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the option");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                int sum=firstInteger+secondInteger;
                System.Console.WriteLine("The Addition of "+firstInteger+" and "+secondInteger+ " is "+sum);
                break;
            }
            case 2:
            {
                int subtraction=firstInteger-secondInteger;
                System.Console.WriteLine("The subtraction of"+firstInteger+" and "+secondInteger +" is "+subtraction);
                break;
            }
            case 3:
            {
                int multiplication=firstInteger*secondInteger;
                System.Console.WriteLine("The Multiplication of"+firstInteger+" and"+secondInteger+" is "+multiplication);
                break;
            }
            case 4:
            {
                int division=firstInteger/secondInteger;
                System.Console.WriteLine("The division of"+firstInteger+" and"+secondInteger+" is "+division);
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Exit");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}

