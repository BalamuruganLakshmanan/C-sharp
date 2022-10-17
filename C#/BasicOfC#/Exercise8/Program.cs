// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the length in meter");
        int meter=int.Parse(Console.ReadLine());
        int cM=meter*100;
        int mM=cM*10;
        double inch=39.3*meter;
        double foot=12*meter;
        double mile=0.0006213715277778*meter;
        System.Console.WriteLine("CM="+cM);
        System.Console.WriteLine("MM="+mM);
        System.Console.WriteLine("Inch="+inch);
        System.Console.WriteLine("foot="+foot);
        System.Console.WriteLine("Mile="+mile);
    }
}
