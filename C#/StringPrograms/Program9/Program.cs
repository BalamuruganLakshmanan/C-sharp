// See https://aka.ms/new-console-template for more information
using System;
namespace Program9;
class Program 
{
    public static void Main(string[] args)
    {
        string output="";
        System.Console.WriteLine("Enter the input string ");
        string input=Console.ReadLine();
        string[] temp=input.Split();
        int size=temp.Length;
        System.Console.WriteLine("Enter the string to search ");
        string input1=Console.ReadLine();
        foreach(string i in temp)
        {
            if(input1==i)
            {
                output="The substring exists in the string";
            }
            else
            {
                output="The substring not exists in the string";
            }

        }
        System.Console.WriteLine(output);
        
    }
}
