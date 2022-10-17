// See https://aka.ms/new-console-template for more information
using System;
namespace StringSearch;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        string[] element=new string[size];
        for (int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the string: ");
            element[i]=Console.ReadLine();
            
        }
        System.Console.WriteLine("The elements in the list are: ");
        for (int i=0;i<size;i++)
        {
            System.Console.WriteLine(element[i]);
        }
        System.Console.WriteLine("Enter the string to search: ");
        string searchString=Console.ReadLine();
        for (int i=0;i<size;i++)
        {
            if(searchString==element[i])
            {
                System.Console.WriteLine(searchString+" found at element["+i+"]");
                break;
            }
            else
            {
                System.Console.WriteLine("Element not found ");
            }
        }
        
    }
}

