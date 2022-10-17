// See https://aka.ms/new-console-template for more information
using System;
namespace Program10;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the user name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter the password");
        string password=Console.ReadLine();
        if(name=="user" && password=="pass")
        {
            System.Console.WriteLine("Password entered successfully!");
        }
        else
        {
            System.Console.WriteLine("wrong password");
        }
    }
}
