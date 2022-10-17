// See https://aka.ms/new-console-template for more information
using System;
namespace Program6;
class Program 
{
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[] list=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the input: ");
            list[i]=int.Parse(Console.ReadLine());
        }
        int temp;
        for(int i=0;i<size;i++)
        {
            for(int j=i+1;j<size;j++)
            {
                
                if(list[i]>list[j])
                {
                    temp=list[i];
                    list[i]=list[j];
                    list[j]=temp;

                }
                
            }
            System.Console.WriteLine(list[i]);
        }
        
    }
    
}