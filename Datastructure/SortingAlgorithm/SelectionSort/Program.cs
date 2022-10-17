// See https://aka.ms/new-console-template for more information
using System;
namespace SelectionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] list={18,19,1,5,7,3,20};
        int size=list.Length-1;
        int minimum,temp,minIndex=0,j;
        for(int i=0;i<size;i++)
        {
            minimum=list[i];
            for(j=i;j<size;j++)
            {
                if(list[j]<minimum)
                {
                    minimum=list[j];
                    minIndex=j;
                }
            }
            if(minimum<list[i])
            {
                temp=list[i];
                list[i]=list[minIndex];
                list[minIndex]=temp;
            }
            
        }
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine(list[i]);
        }
        
    }
}
