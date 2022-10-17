// See https://aka.ms/new-console-template for more information
using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        string words="";
        System.Console.WriteLine("Enter the string");
        string input=Console.ReadLine();
        char[] temps=input.ToCharArray();
        int size=input.Length;
         for(int j=(size-1);j>=0;j--)
            {
                words=words+temps[j];
            }
        if(words==input)
        {
            System.Console.WriteLine("Is a palindrome");
        }
    }
}
