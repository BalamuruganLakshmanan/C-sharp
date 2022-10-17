// See https://aka.ms/new-console-template for more information
using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number1");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Number2");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your choice:");
        char choice=char.Parse(Console.ReadLine());
        switch(choice)
        {
            case '+':
            {
                int sum=number1+number2;
                System.Console.WriteLine("Result value:" +sum);
               break;
            }
            case '-':
            {
                int  subtraction=number1-number2;
                System.Console.WriteLine("Result value:" +subtraction);
                break;
            }
            case '*':
            {
                int multiplication=number1*number2;
                System.Console.WriteLine("Result value:" +multiplication);
                break;
            }
            case '/':
            {
                int division=number1/number2;
                System.Console.WriteLine("Result value:" +division);
                break;
            }
            case '%':
            {
                int modulus=number1%number2;
                System.Console.WriteLine("Result value:"+modulus);
                break;
            }
            default :
            System.Console.WriteLine("invalid");
            break;
        }

    }
}
