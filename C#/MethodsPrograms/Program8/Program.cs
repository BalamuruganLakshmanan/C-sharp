// See https://aka.ms/new-console-template for more information
using System;
namespace Program8;
class Program 
{
    public static void Main(string[] args)
    {
        Percentage( );
        void Percentage( )
        {
            System.Console.WriteLine("Enter the Mark1: ");
            int mark1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mark2: ");
            int mark2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mark3: ");
            int mark3=int.Parse(Console.ReadLine());
            double sum=mark1+mark2+mark3;
            double percent=(sum/300)*100;
            System.Console.WriteLine("Percentage: "+percent);
        }
        
    }
}
