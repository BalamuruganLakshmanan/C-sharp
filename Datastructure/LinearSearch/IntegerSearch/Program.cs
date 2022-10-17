// See https://aka.ms/new-console-template for more information
using System;
namespace IntegerSearch;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[] element=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the input: ");
            element[i]=int.Parse(Console.ReadLine());
        }
        
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine(element[i]);
        }
        System.Console.WriteLine("Enter the search element : ");
        int searchelement=int.Parse(Console.ReadLine());
        for(int i=0;i<size;i++)
        {
            if(searchelement==element[i])
            {
                System.Console.WriteLine(searchelement+" found at "+"element["+i+"]" );
                break;
            }
            else
            {
                System.Console.WriteLine("Element not found ");
            }
        }
    }
}
