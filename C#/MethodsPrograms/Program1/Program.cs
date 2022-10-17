// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
namespace Methods;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number1:");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Number2");
        int number2=int.Parse(Console.ReadLine());
        int Addition(int data1,int data2)
        {
            int sum=data1+data2;
            return sum;
        }
        void Subtraction(int data3,int data4)
        {
            int difference=data3-data4;
            System.Console.WriteLine("The difference is "+difference);
        }
        int Multiplication( )
        {
            int product=number1*number2;
            System.Console.WriteLine();
            return product;
        }
        void Division( )
        {
            int  divisor=number1/number2;
            System.Console.WriteLine("Division:"+divisor);
        }
        int sum1=Addition(number1,number2);
        System.Console.WriteLine("Addition:"+sum1);
        Subtraction(number1,number2);
        int product1=Multiplication( );
        System.Console.WriteLine("Multiplication:"+product1);
        Division();

        
    }
}
