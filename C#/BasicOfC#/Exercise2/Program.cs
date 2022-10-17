// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first Number");
        int firstNumber= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Second Number");
        int secondNumber= int.Parse(Console.ReadLine());
        int addition=firstNumber+secondNumber;
        int subtraction=firstNumber-secondNumber;
        int multiplication=firstNumber*secondNumber;
        int division=firstNumber/secondNumber;
        int modulus=firstNumber%secondNumber;
        Console.WriteLine(firstNumber+"+"+secondNumber+"="+addition);
        Console.WriteLine(firstNumber+"-"+secondNumber+"="+subtraction);
        Console.WriteLine(firstNumber+"x"+secondNumber+"="+multiplication);
        Console.WriteLine(firstNumber+"/"+secondNumber+"="+division);
        Console.WriteLine(firstNumber+"%"+secondNumber+"="+modulus);
    }
}
