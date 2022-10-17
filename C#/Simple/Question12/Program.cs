// See https://aka.ms/new-console-template for more information
using System;
namespace Question12;
class Program 
{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=1;i<=99;i++)
        {
            if(i%2 !=0)
            {
                sum=sum+(i*i);
            }
            

        }
        System.Console.WriteLine(sum);
    }
}
