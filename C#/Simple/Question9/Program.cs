// See https://aka.ms/new-console-template for more information
using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the name of the month");
        string month=Console.ReadLine();
        int salary=500;
        switch(month)
        {
            case "January":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*31-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "Febraury":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*28-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "March":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*31-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "April":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*30-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "May":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*30-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "June":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*30-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "July":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*31-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "August":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*30-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "September":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*31-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "October":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*30-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "November":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*31-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            case "December":
            {
                System.Console.WriteLine("number of leaves taken");
                double leave=double.Parse(Console.ReadLine());
                double total=salary*30-(leave*salary);
                System.Console.WriteLine("Total salary "+total +"Per month");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;

            }
        }
    }
}
