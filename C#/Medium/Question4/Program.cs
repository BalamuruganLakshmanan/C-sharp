// See https://aka.ms/new-console-template for more information
using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        string number="";
        int size=0,output=1,number1=1;
        while(number1<=1000)
        {
            number=number1.ToString();
            size=number.Length;
            for(int i=number1;i<=size;i++)
            {
                output=output*i;
                
            }
            if(output==number1)
            {
                System.Console.WriteLine(output);
            }
            number1++;
           
        }
        
    }
}
