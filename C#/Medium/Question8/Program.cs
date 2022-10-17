// See https://aka.ms/new-console-template for more information
using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        string word=" ";
        System.Console.WriteLine("Enter the input");
        string name=Console.ReadLine();
        foreach(char i in name)
        {
            if( i=='1' || i=='2' || i=='3' || i=='4'|| i=='5'|| i=='6' || i=='7' || i=='8' || i=='9' ||i=='0')
            {
                word=word+i;

            }
          

        }
        int word1=int.Parse(word);
        if(word1%2==0)
        {
            System.Console.WriteLine(word1+" is even number");
        }
        else
        {
            System.Console.WriteLine(word1+" is odd number");
        }
    }
}