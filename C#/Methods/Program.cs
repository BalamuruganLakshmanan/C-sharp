// See https://aka.ms/new-console-template for more information
using System;
namespace Methods;
class Program
{
    public static void Main(string[] args)
    {
        string con=" ";
        do
        {
            System.Console.WriteLine("Enter your Option:");
            int option=int.Parse(Console.ReadLine());
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
                return product;
            }
            void Division( )
            {
                int  divisor=number1/number2;
            }
            switch(option)
            {
                case 1:
                {
                   System.Console.WriteLine("Addition"); 
                   int sum1=Addition(number1,number2);
                   System.Console.WriteLine(sum1);
                   break;
                }
                case 2:
                {
                    System.Console.WriteLine("Subtraction");
                    Subtraction(number1,number2);
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Multiplication");
                    int product1=Multiplication();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Division");
                    Division();
                    break;
                }
            }
                System.Console.WriteLine("Do you want to repeat the above operation?:");
                con=Console.ReadLine().ToLower();
                if(con != "no" && con !="yes")
                {
                    System.Console.WriteLine("You entered the Invalid input");
                }
            
        }while(con=="yes");
        
    }
}
