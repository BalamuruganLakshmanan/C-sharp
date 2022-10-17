// See https://aka.ms/new-console-template for more information
using System;
namespace AbstractClasses;
class  Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Syncfusion employees: ");
        Syncfusion job1=new Syncfusion( );
        job1.Name="Developer";
        job1.Salary(30);


        System.Console.WriteLine("TCS employees:  ");
        TCS job2=new TCS( );
        job2.Name="Developer";
        job2.Salary(30);
    }
}
