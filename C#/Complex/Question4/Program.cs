// See https://aka.ms/new-console-template for more information
using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        string words=" ";
        
        System.Console.WriteLine("Enter the input");
        string input=Console.ReadLine();
        
        char[] temps= input.ToCharArray();
        int size=temps.Length;
        foreach(char i in temps)
        {
            words=" ";
            char[] temps2=words.ToCharArray();
            for(int j=0;j<temps2.Length;j++)
            {
                if(i!=temps2[j])
                {
                     words=words+i;
                    
                }
               
            }
            
        }
        System.Console.WriteLine(words);
        
        
        
            
            
           


       
        
       

        
        
    }
    
}
