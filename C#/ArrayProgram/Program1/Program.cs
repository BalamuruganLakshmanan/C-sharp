// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the elements in the array");
        int limit=int.Parse(Console.ReadLine());
        int[] element=new int[limit];
        for(int i=0;i<limit;i++)
        {
            System.Console.WriteLine("Enter the number");
            element[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("The elements are: ");
        for(int i=0;i<limit;i++)
        {
            System.Console.WriteLine(element[i]+" ");
        }
    }
}
