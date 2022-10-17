// See https://aka.ms/new-console-template for more information
using System;
namespace Program5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first input");
        string input1=Console.ReadLine();
        System.Console.WriteLine("Enter the second input");
        string input2=Console.ReadLine();
        int size1=input1.Length;
        int size2=input2.Length;
        if(size1==size2)
        {
            System.Console.WriteLine("The length of the both strings are equal ");
        }
        else
        {
            System.Console.WriteLine("not equal");
        }
    }
}
