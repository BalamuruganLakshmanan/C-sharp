// See https://aka.ms/new-console-template for more information
using System;
namespace ByType;
class Program 
{
     static void Display( int number)
        {
            System.Console.WriteLine("int type "+number);
        }

    static void Display(string name)
    {
        
        System.Console.WriteLine("string type: "+name);

    }
    public static void Main(string[] args)
    {
        Display(89);
        Display("Ram");
        
    }
}
