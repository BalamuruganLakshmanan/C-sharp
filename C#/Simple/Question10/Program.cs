// See https://aka.ms/new-console-template for more information
using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the character");
        char character=char.Parse(Console.ReadLine().ToLower());
        switch(character)
        {
            case 'a':
            {
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case 'e':
            {
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case 'i':
            {
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case 'o':
            {
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case 'u':
            {
                System.Console.WriteLine("It is a vowel");
                break;
            }
            default:
            {
                System.Console.WriteLine("Not a vowel");
                break;
            }
            
        }
    }
}
