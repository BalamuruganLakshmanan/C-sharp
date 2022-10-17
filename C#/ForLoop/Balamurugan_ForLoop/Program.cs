// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise1;
class Program
{
    public static void Main(string[] args)
    {
        for(int i=0;i<=25;i++)
        {
            if(i%2==0)
            {
                System.Console.WriteLine("Even number is:"+i);
            }
        }
        System.Console.WriteLine("Enter the initiallimit");
        int initiallimit=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the final limit");
        int finallimit=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=initiallimit;i<=finallimit;i++)
        {
            int squaring=i*i;
            sum=sum+squaring;
        }
        System.Console.WriteLine("sum of square of the number is:" +sum);

        
    }
}
