// See https://aka.ms/new-console-template for more information
using System;
namespace Program5;
class Program 
{
    public static void Main(string[] args)
    {
        Primenumber( );
        void Primenumber( )
        {
            int count=0;
            System.Console.WriteLine("Enter the number");
            int number=int.Parse(Console.ReadLine());
            for(int i=1;i<=number;i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                System.Console.WriteLine(number+" is a Prime number");
            }
            else
            {
                System.Console.WriteLine(number+" is not a prime  number");
            }

        }
    }
}
