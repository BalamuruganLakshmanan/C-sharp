// See https://aka.ms/new-console-template for more information
using System;
namespace Program7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[,] matrix=new int[size,size];
        for(int i=0;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                System.Console.WriteLine("Enter the input: ");
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for(int i=0 ;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                System.Console.Write(matrix[i,j]+" ");
            }
            System.Console.Write("\n");

        }


    }
}
