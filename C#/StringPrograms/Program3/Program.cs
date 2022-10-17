// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program 
{
    public static void Main(string[] args)
    {
        string word1="";
        System.Console.WriteLine("Enter the input string");
        string word=Console.ReadLine();
        char[] temp=word.ToCharArray();
        int size=temp.Length;
        for(int i=(size-1);i>=0;i--)
        {
            word1=word1+" "+temp[i];

        }
        System.Console.WriteLine("The characters of the string in reverse are : "+word1);
    }
}
