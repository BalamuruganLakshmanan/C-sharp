// See https://aka.ms/new-console-template for more information
using System;
namespace DoWhile;
class Program
{
    public static void Main(string[] args)
    {
             
        string con=" ";
        do
        {
            System.Console.WriteLine("Enter the Number:");
            int a=int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                System.Console.WriteLine("Even");
            }
            else
            {
                System.Console.WriteLine("ODD");
            }
            System.Console.WriteLine("Do you want to repeat this process again?:");
            con=Console.ReadLine().ToLower();
            if(con != "no" && con !="yes")
            {
                System.Console.WriteLine("The given input is wrong and please give the valid input");
            }
            
        }while(con=="yes");
    }
}
