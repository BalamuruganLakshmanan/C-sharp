// See https://aka.ms/new-console-template for more information
using System;
namespace Program5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Physics Mark");
        int physicsMarks=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your maths marks");
        int mathsMarks=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry marks");
        int chemistryMarks=int.Parse(Console.ReadLine());
        int total=physicsMarks+chemistryMarks+mathsMarks;
        int percentage=total/300*100;
        if(percentage>75)
        {
            System.Console.WriteLine("The candidate is eligible for admission");
        }
        else
        {
            System.Console.WriteLine("The candidate is not eligible for admission");
        }
    }
}
