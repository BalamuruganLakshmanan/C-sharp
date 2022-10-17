// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string name=Console.ReadLine();
        int size=name.Length;
        System.Console.WriteLine("The length of the word is "+size);
    }
}
