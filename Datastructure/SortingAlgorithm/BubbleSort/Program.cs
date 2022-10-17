// See https://aka.ms/new-console-template for more information
using System;
namespace BubbleSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] element={18,19,1,5,7,3,20};
        int size=element.Length-1;
        int temp;
        for(int i=0;i<size;i++)
        {
            for(int j=i+1;j<size;j++)
            {
                
                if(element[i]>element[j])
                {
                    temp=element[i];
                    element[i]=element[j];
                    element[j]=temp;

                }
                
            }
            System.Console.WriteLine(element[i]);
        }
        
    }
}
