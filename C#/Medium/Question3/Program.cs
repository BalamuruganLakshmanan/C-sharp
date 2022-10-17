// See https://aka.ms/new-console-template for more information
using System;
namespace Question3;
class Program  
{
    public static void Main(string[] args)
    {
        int sum=0,numbers;
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());
        int temp=number;
        while(number !=0)
        {
           numbers=number%10;
           sum=(sum*10+numbers);
           number=number/10;
           
                
            
        }
       
        if(sum==temp)
       {
        
         System.Console.WriteLine(sum+" It is palindrome");
       }
       else
       {
         System.Console.WriteLine("It is not a palindrome");
       }

    }
}
