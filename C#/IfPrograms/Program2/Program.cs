// See https://aka.ms/new-console-template for more information
using System;
namespace Program2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your age:");
        int age=int.Parse(Console.ReadLine());
        if(age>=18)
        {
            System.Console.WriteLine("Congratulation! ");
            System.Console.WriteLine("You are eligible for casting your vote.");
        }
        else
        {
            System.Console.WriteLine("You are not eligible for casting your vote.");

         }
    }
}
