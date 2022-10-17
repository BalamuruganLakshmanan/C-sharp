// See https://aka.ms/new-console-template for more information
using System;
namespace Question13;
class Program 
{
    public static void Main(string[] args)
    {
        int n=2;
        for (int i=1;i<=20;i++)
        {
            int output=n*i;
            System.Console.WriteLine(n+"X"+i+"="+output);
        }
    }
}
