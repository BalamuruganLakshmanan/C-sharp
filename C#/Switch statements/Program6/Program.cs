// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius of the circle");
        int radius=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your choice");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                double area=3.14*radius*radius;
                System.Console.WriteLine("The area is "+area);
                break;
            }
            case 2:
            {
                double perimeter=2*3.14*radius;
                System.Console.WriteLine("The perimeter is "+perimeter);
                break;
            }
            case 3:
            {
                int diameter=2*radius;
                System.Console.WriteLine("The diameter is "+diameter);
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
