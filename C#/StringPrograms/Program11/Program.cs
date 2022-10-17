// See https://aka.ms/new-console-template for more information
using System;
namespace Program11;
class Program 
{
    public static void Main(string[] args)
    {
        string temp1="";
        System.Console.WriteLine("Enter the string ");
        string word=Console.ReadLine();
        int size=word.Length;
        char[] temp2=temp1.ToCharArray();
        char[] temp=word.ToCharArray();
        foreach(char words in temp)
        {
            for(int j=0;j<temp2.Length;j++)
            {
                if(words!=temp2[j])
                {
                    temp1+=words;
                }
            }

            
        }
        System.Console.WriteLine(temp1);
    }
}
