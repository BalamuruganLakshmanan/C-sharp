// See https://aka.ms/new-console-template for more information
using System;
namespace StringSearch;
class Program 
{
    public static void Main(string[] args)
    {
        string[] element={"SF3001","SF3002","SF3003","SF3004","SF3005","SF3006","SF3007","SF3008","SF3009","SF3010"};
        int size=element.Length-1;
        System.Console.WriteLine("Enter the element to search : ");
        string searchElement=Console.ReadLine().ToUpper();
        int count=0,midPoint,start=0,value;
        for(int i=start;i<size;i++)
        {
            midPoint=(start+size)/2;
            value=searchElement.CompareTo(element[midPoint]);
            if(value==0)
            {
                System.Console.WriteLine("Element found at element["+midPoint+"]");
                count=1;
                break;
            }
            else if(value<0)
            {
                size=midPoint-1;
                midPoint=(start+size)/2;
                value=searchElement.CompareTo(element[midPoint]);
                if(value==0)
                {
                    System.Console.WriteLine("Element found at element["+midPoint+"]");
                    count=1;
                    break;
                }
                
            }
            else if(value>0)
            {
                start=midPoint+1;
                midPoint=(start+size)/2;
                value=searchElement.CompareTo(element[midPoint]);
                if(value==0)
                {
                    System.Console.WriteLine("Element found at element["+midPoint+"]");
                    count=1;
                    break;
                }
            }
        }
        if(count==0)
        {
            System.Console.WriteLine("Element not found in this array");
        }
        
    }
}
