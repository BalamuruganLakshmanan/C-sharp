// See https://aka.ms/new-console-template for more information
using System;
namespace Program2;
class Program 
{
    public static void Main(string[] args)
    {
        string word1="";        
        System.Console.WriteLine("Enter the input string");
        string word=Console.ReadLine();
        char[] words=word.ToCharArray();
        foreach(char i in words)
        {
            word1=word1+" "+i;
        }
        System.Console.WriteLine(word1);

        
    }
}
