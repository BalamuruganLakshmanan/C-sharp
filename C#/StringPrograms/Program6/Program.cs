// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program 
{
    public static void Main(string[] args)
    {
        int sum1=0,sum2=0,sum3=0;
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine();
        char[] temp=word.ToCharArray();
        foreach(char i in temp)
        {
            if(i=='1' || i=='2' || i=='3'|| i=='4' || i=='5'|| i=='6' || i=='7'|| i=='8' || i=='9' || i=='0' )
            {
                sum1+=1;
            }
            else if(i=='!' || i=='@' || i=='#' || i=='$' || i=='%' || i=='^' || i=='&' || i=='*'|| i==' ' || i=='.')
            {
                sum2+=1;
            }
            else
            {
                sum3+=1;
            }

        }
        System.Console.WriteLine("Number of Alphabets in the string is"+sum3 );
        System.Console.WriteLine("Number of Digits in the string is : "+sum1);
        System.Console.WriteLine("Number of Special characters in the string is :"+sum2);
    }
}
