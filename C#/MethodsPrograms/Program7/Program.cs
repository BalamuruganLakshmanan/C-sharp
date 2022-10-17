// See https://aka.ms/new-console-template for more information
using System;
namespace Program7;
class Program 
{
    public static void Main(string[] args)
    {
        Palindrome( );
        void Palindrome( )
        {
            string temp=" ";
            string name="eye is";
            foreach(char i in name)
            {
                temp=i+temp;
            }
            if(temp==name)
            {
                System.Console.WriteLine("The string is Palindrome.");
            }
        }
    }
}
