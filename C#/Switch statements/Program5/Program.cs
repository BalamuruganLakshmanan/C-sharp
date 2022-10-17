// See https://aka.ms/new-console-template for more information
using System;
namespace Program5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine( "Enter your choice:");
        string option=Console.ReadLine();
        switch(option)
        {
            case "India":
            {
                System.Console.WriteLine("1.Gambir");
                System.Console.WriteLine("2.Ashwin");
                break;
            }
            case "Pakistan":
            {
                System.Console.WriteLine("Player1");
                System.Console.WriteLine("Player2");
                break;
            }
            case "Bangladesh":
            {
                System.Console.WriteLine("Player3");
                System.Console.WriteLine("Player4");
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
