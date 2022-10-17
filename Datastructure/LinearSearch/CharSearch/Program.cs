// See https://aka.ms/new-console-template for more information
using System;
namespace Charsearch;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter  the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        char[] element=new char[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the character: ");
            element[i]=char.Parse(Console.ReadLine());
        }
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine(element[i]);
        }
        System.Console.WriteLine("Enter the search  element: ");
        char searchElement=char.Parse(Console.ReadLine());
        for(int i=0;i<size;i++)
        {
            if(searchElement==element[i])
            {
                System.Console.WriteLine(searchElement+" found at"+"element["+i+"]");
                break;
            }
            else 
            {
                System.Console.WriteLine("Element is not found ");
            }
        }
    }
   
}
