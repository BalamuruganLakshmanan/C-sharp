// See https://aka.ms/new-console-template for more information
using System;
namespace Program10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your password");
        string password=Console.ReadLine();
        if(password=="HiTeam")
        {
            System.Console.WriteLine("Right Password");
        }
        else
        {
            System.Console.WriteLine("Wrong Password");
        }
    }
}
