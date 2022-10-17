using System;
namespace FunctionDeligates;
class Program 
{
    static double Sum(int a,int b ){return a+b ; }
    static double Subtract(int a ,int b){return a-b;}
    public static double Calculator(Func<int,int,double>operation,int x,int y)
    {
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine(Calculator(Sum,10,5));
        System.Console.WriteLine(Calculator(Subtract,4,2));
        
    }
}
