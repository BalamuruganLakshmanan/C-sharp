// See https://aka.ms/new-console-template for more information
using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        string newword="";
        System.Console.WriteLine("Enter the first word");
        string word=Console.ReadLine();
        System.Console.WriteLine("Enter the second word");
        string word2=Console.ReadLine();
        char[] temp1=word.ToCharArray();
        char[] temp2=word2.ToCharArray();
        foreach(char i in temp1)
        {
            for(int j=0;j<temp2.Length;j++)
            {
                if(i==temp2[j])
                {
                    newword="It is anagram";
                }
                else
                {
                    newword="It is not anagram";
                }
            }
        }
        System.Console.WriteLine(newword);

    }
}