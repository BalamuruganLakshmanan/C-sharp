// See https://aka.ms/new-console-template for more information
using System;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        string newWord=" ";
        System.Console.WriteLine("Enter the Main string");
        string mainString=Console.ReadLine();
        System.Console.WriteLine("Enter the sub string");
        string subString=Console.ReadLine();
        string[] main1=mainString.Split(subString);
        foreach (string i in main1)
        {
            newWord=newWord+i;
        }
        int size=newWord.Length;
        System.Console.WriteLine("String searched count is"+(size-1));
    }
}
