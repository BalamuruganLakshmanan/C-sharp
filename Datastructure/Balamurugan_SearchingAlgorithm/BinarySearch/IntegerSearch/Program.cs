// See https://aka.ms/new-console-template for more information
using System;
namespace CharSearch;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[] element=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the input: ");
            element[i]=int.Parse(Console.ReadLine());
        }
        // to show the elements in the array
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine(element[i]);
        }
        // TO sort the array
        for(int i =0;i<size;i++)
        {
            for(int j=i+1;j<size;j++)
            {
                if(element[i]>element[j])
                {
                    int temp=element[i];
                    element[i]=element[j];
                    element[j]=temp;

                }
            }
        }
        // TO show the sorted array
         System.Console.WriteLine("The sorted array elements are: ");
        for(int i =0;i<size;i++)
        {
            System.Console.WriteLine(element[i]);
        }
        
        
 
        int start=0,midPoint,searchElement,count=0;
        System.Console.WriteLine("Enter the element to search: ");
        searchElement=int.Parse(Console.ReadLine());
        
        for(int i =0;i<size;i++)
        {
            midPoint=(start+size)/2;
            if(searchElement==element[midPoint])
            {
                System.Console.WriteLine("Element found at "+"element["+midPoint+"]");
                count=1;
                break;
            }
            if(searchElement<element[midPoint])
            {
                size=midPoint-1;
                midPoint=(start+size)/2;
                
                if(searchElement==element[midPoint])
                {
                    System.Console.WriteLine("Element found at "+"element["+midPoint+"]");
                    count=1;
                    break;
                }
                else if(searchElement>element[midPoint])
                {
                   start=midPoint+1;
                   midPoint=(start+size)/2;
                   if(searchElement==element[midPoint])
                   {
                      System.Console.WriteLine("Element found at element["+midPoint+"]");
                      count=1;
                      break;
                    }
                }
 
            }           
            
           

        }
        if(count==0)
        {
            System.Console.WriteLine("Element not found");
        }
    }
}
