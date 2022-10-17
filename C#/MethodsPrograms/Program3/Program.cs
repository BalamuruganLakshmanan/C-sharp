// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program 
{
    public static void Main(string[] args)
    {
        void Swap( )
        {
            int a=5;
            int b=6,c;
            c=a;
            a=b;
            c=a;
            System.Console.WriteLine("Now the 1st number is : "+a +"and the 2nd number is :"+c);

        }
        Swap( );
    }
}
