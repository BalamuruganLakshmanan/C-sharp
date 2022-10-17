// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program
{
    public static void Main(string[] args)
    {
        int n=1;
        int count=0;
        while(n<=100)
        {
            if(n%2==0)
            {
                System.Console.WriteLine("Even Number is "+ n);
            }
            else
            {
                System.Console.WriteLine("Odd Number is "+n);
            }
            n++;
            
        }
        while(n<=100)
        {
            for (int i=n;i<=n;i++)
            {
                if(n%i==0)
                {
                    count=count+1;
                }
                if(count==2)
                {
                    System.Console.WriteLine("prime Number is "+n);
                }
                n++;
            }
        }
    }
}
