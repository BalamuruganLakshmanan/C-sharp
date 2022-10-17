// See https://aka.ms/new-console-template for more information
using System;
namespace CharSearch;
class Program 
{
    public static void Main(string[] args)
    {
        char[] element={'a','b','c','d','e'};
        int size=element.Length-1;
        int start=0,midPoint,count=0;
        char searchElement;
        System.Console.WriteLine("Enter the search element: ");
        searchElement=char.Parse(Console.ReadLine().ToLower());
        for(int i=start;i<size;i++)
        {
            midPoint=(start+size)/2;
            if(searchElement==element[midPoint])
            {
                System.Console.WriteLine("Element found at element["+midPoint+"]");
                count=1;
                break;
            }
            else if(searchElement<element[midPoint])
            {
                size=midPoint-1;
                midPoint=(start+size)/2;
                if(searchElement==element[i])
                {
                    System.Console.WriteLine("ELement found at element["+midPoint+"]");
                    count=1;
                    break;
                }
                    
            }
            else if (searchElement>element[midPoint])
            {
                start=midPoint+1;
                midPoint=(start+size)/2;
                if(searchElement==element[i])
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