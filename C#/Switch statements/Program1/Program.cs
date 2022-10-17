// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Grade");
        char option=char.Parse(Console.ReadLine().ToUpper());
        switch(option)
        {
            case 'A':
            {
                System.Console.WriteLine("Average");
                break;
            }
            case 'E':
            {
                System.Console.WriteLine("Excellent");
                break;
            }
            case 'V':
            {
                System.Console.WriteLine("Very Good ");
                break;
            }
            case 'G':
            {
                System.Console.WriteLine("Good");
                break;
            }
            case 'F':
            {
                System.Console.WriteLine("Fail");
                break;
            }
            default :
            System.Console.WriteLine("invalid");
            break;

        }
    }
}
