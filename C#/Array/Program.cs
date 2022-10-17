// See https://aka.ms/new-console-template for more information
using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array");
        int size=int.Parse(Console.ReadLine());
        string[] names=new string[size];
        for (int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter the name:");
            names[i]=Console.ReadLine();          
        }
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine(names[i]);
        }
        System.Console.WriteLine("Enter the name that you have to search:");
        string searchName=Console.ReadLine();
        System.Console.WriteLine("Name from user to search: "+searchName);
        int temp=0;
        for(int i=0; i<size;i++)
        {
            if(names[i]==searchName)
            {
                System.Console.WriteLine("The name is present in an array and the position is:"+ i);
                temp++;
            }
        }
        if(temp==0)
        {
            System.Console.WriteLine("The name is not present in an array");
        }
        int tem1=0;
        foreach(string word in names)
        {
            if(word==searchName)
            {
                System.Console.WriteLine("The name is present in an array ");
                tem1++;
            }
        }
        if(tem1==0)
        {
            System.Console.WriteLine("The name is not present in an array");
        }
            
              
    }
}
