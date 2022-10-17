// See https://aka.ms/new-console-template for more information
using System;
namespace Program2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array");
        int size =int.Parse(Console.ReadLine());
        int [] element=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the input: ");
            element[i]=int.Parse(Console.ReadLine());
            
        }
        System.Console.WriteLine("The elements stored in the array: ");
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine(element[i]+" ");
        }
        System.Console.WriteLine("The reversed element from the array: ");
        for(int i=size-1;i>=0;i--)
        {
            System.Console.WriteLine(element[i]+" ");
        }
    }
}
