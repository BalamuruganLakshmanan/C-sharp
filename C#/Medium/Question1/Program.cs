// See https://aka.ms/new-console-template for more information
using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the basic salary");
        double salary=double.Parse(Console.ReadLine());
        System.Console.WriteLine("");
        int tax=6,insurance=1;
        if( salary <= 10000 )
        {
            int HRA=20,DRA=80;
            double temp=salary*(HRA+DRA)/100;
            double total=(salary+temp)*12;
            double value=total*(tax+insurance)/100;
            double final=total-value;
            System.Console.WriteLine(final);
        }
         if( salary>10000 && salary <= 20000 )
        {
            int HRA=25,DRA=90;
            double temp=salary*(HRA+DRA)/100;
            double total=(salary+temp)*12;
            double value=total*(tax+insurance)/100;
            double final=total-value;
            System.Console.WriteLine(final);
        }
         if( salary > 20000 )
        {
            int HRA=30,DRA=95;
            double temp=salary*(HRA+DRA)/100;
            double total=(salary+temp)*12;
            double value=total*(tax+insurance)/100;
            double final=total-value;
            System.Console.WriteLine(final);
        }
        
    }
}
