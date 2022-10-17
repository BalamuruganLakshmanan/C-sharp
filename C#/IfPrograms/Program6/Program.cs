// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Temperature in centigrade");
        int temperature=int.Parse(Console.ReadLine());
        if(temperature < 0 )
        {
            Console.WriteLine("Freezing weather ");
        }
        else if(temperature>0 && temperature<10)
        {
            System.Console.WriteLine("Very Cold weather");
        }
        else if(temperature>=10 && temperature<20)
        {
            System.Console.WriteLine("Cold weather");
        }
        else if(temperature>=20 && temperature<30)
        {
            System.Console.WriteLine("Normal in Temperature");
        }
        else if(temperature>=30 && temperature<40)
        {
            System.Console.WriteLine("Its Hot ");
        }
        else if(temperature >=40 )
        {
            System.Console.WriteLine("Its Very Hot " );
        }

    }
}