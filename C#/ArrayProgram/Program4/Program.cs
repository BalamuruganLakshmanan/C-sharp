using System.Runtime.ConstrainedExecution;
// See https://aka.ms/new-console-template for more information
using System;
namespace Program4;
class Program 
{
    public static void Main(string[] args)
    {
        int maximum=0;
        int minimum=0;
        System.Console.WriteLine("Enter the number of element in the array: ");
        int size =int.Parse(Console.ReadLine());
        int[]  element=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("enter the input values: ");
            element[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<size;i++)
        {
            if(element[i]> maximum)
            {
                maximum=element[i];
            }
            else
            {
                minimum=element[i];
            }
        }
        System.Console.WriteLine("The maximum element is : "+maximum);
        System.Console.WriteLine("The Minimum element is "+minimum);
    }
}
