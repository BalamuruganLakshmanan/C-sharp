// See https://aka.ms/new-console-template for more information
using System;
namespace Program7;
class Program 
{
    public static void Main(string[] args)
    {
        int sum1=0,sum2=0;
        System.Console.WriteLine("Enter the input string");
        string word=Console.ReadLine().ToLower();
        char[] temp=word.ToCharArray();
        foreach (char i in temp)
        {
            if(i=='a' || i=='e' || i=='i' || i=='o' || i=='u')
            {
                sum1+=1;

            }
            else
            {
                sum2+=1;
            }
        }
        System.Console.WriteLine("The total number of vowel in the string is :"+sum2);
        System.Console.WriteLine("The total number of consonant in the string is : "+sum1);
    }
}