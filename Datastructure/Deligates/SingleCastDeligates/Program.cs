// See https://aka.ms/new-console-template for more information
using System;
namespace SingleCastDeligates;
public delegate int Calculator(int number);
class Program 
{
    static int value=10;
    public static int AddNumber(int number){value+=number;return value;}
    public static int MultiplyNumber(int number){value*=number;return value;}
    public static int GetNumber( ){return value;}
    public static void Main(string[] args)
    {
        Calculator nc1=new Calculator(AddNumber);
         Calculator nc2=new Calculator(MultiplyNumber);
        nc1(10);
       System.Console.WriteLine("Value of Number:{0}"+GetNumber());
        nc2(2);
        System.Console.WriteLine("Value of Number:{0}"+GetNumber());

    }
}
