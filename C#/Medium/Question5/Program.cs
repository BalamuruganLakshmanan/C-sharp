// See https://aka.ms/new-console-template for more information
using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the end number");
        int number=int.Parse(Console.ReadLine());
        for(int i=1;i<=number;i++)
        {
            if((i%4==0)&&(i%400!=0) ||(i%100!=0))
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
