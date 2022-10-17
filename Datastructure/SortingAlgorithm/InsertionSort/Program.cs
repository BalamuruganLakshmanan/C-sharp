// See https://aka.ms/new-console-template for more information
using System;
namespace InsertionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] element={18,19,1,5,7,3,20};
        int size =element.Length;
        int key,temp,j,i;
        for( i=1;i<size;i++)
        {
            key=element[i];
            for(j=i-1;j>=0 ;j--)
            {
                if(key<element[j])
                {
                    
                    temp=element[j];
                    element[j]=element[j+1];
                    element[j+1]=temp;

                }
                
               
            }
            
        }
        for(i=0;i<size;i++)
        {
            System.Console.WriteLine(element[i]);
        }
    }
}
