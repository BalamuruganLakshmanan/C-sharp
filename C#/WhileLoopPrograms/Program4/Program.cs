// See https://aka.ms/new-console-template for more information
using System;
namespace Program4;
class Program
{
    public static void Main(string[] args)
    {
        bool word;
        int number;
        int n=1;
        while(n<5)
        {
            System.Console.WriteLine("Please enter the Number");
            word=int.TryParse(Console.ReadLine(),out number);
            n++;
            if(word==true)
            {
                System.Console.WriteLine("valid input");
            }
            else
            {
                System.Console.WriteLine("invalid input enter again");
            }
        }
    }
}
