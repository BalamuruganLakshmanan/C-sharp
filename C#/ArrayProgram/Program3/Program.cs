// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program 
{
    public static void Main(string[] args)
    {
        int sum=0;
        System.Console.WriteLine("Enter the size of the elements: ");
        int size=int.Parse(Console.ReadLine());
        int[] element=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the input");
            element[i]=int.Parse(Console.ReadLine());

        }
        for(int i=0;i<size;i++)
        {
            sum=sum+element[i];
        }
        System.Console.WriteLine("The sum of the elemnets in the array is "+sum);
    }
}
