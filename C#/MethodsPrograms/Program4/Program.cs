// See https://aka.ms/new-console-template for more information
using System;
namespace Program3;
class Program 
{
    public static void Main(string[] args)
    {
         Fibnoccis( );
        void Fibnoccis( )
        {
            System.Console.WriteLine("Enter the limit");
            int limit=int.Parse(Console.ReadLine());
            int number1=0,number2=1,number3;
            System.Console.WriteLine(number1+" "+number2+" ");
            while((limit-2) !=0)
            {
                number3=number1+number2;
                System.Console.WriteLine(number3);
                number1=number2;
                number2=number3;
                --limit;
            }
           
        }
    }
}
