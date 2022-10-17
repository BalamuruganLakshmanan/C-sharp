// See https://aka.ms/new-console-template for more information
using System;
namespace Program2;
class Program 
{
    public static void Main(string[] args)
    {
        float sum=0;
        System.Console.WriteLine("Enter the limit");
        int limit=int.Parse(Console.ReadLine());
        for (int i=1;i<=limit;i++)
        {
            sum=sum+i;
        }
        System.Console.WriteLine("The sum of the number is "+sum);
        float average=(sum)/limit;
        System.Console.WriteLine("Average "+average);
    }
}
