// See https://aka.ms/new-console-template for more information
using System;
namespace Program5;
class Program 
{
    public static void Main(string[] args)
    {
        int[] list={18,19,1,5,7,3,20};
        int size=list.Length;
        for(int i=0;i<size;i++)
        {
            if(list[i]%2==0)
            {
                System.Console.WriteLine("The element is even "+list[i]);
            }
            else 
            {
                System.Console.WriteLine("The element is odd "+list[i]);
            }
        }
    }
}
