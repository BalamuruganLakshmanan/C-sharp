// See https://aka.ms/new-console-template for more information
using System;
namespace DTime;
class Program
{
    public static void Main(string[] args)
    {
        string word=" ";
        DateTime dob=new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine(dob.Year);
        System.Console.WriteLine(dob.Month);
        System.Console.WriteLine(dob.Day);
        System.Console.WriteLine(dob.Hour);
        System.Console.WriteLine(dob.Minute);
        System.Console.WriteLine(dob.Second);
        //System.Console.WriteLine(dob.ToString("dd/mm/yyyy HH:mm:ss"));
        string dtim1=Console.ReadLine();
        System.Console.WriteLine(dtim1);
        string[] sdtime= dtim1.Split(new string[]{"/"," "," :"},StringSplitOptions.None);
        foreach (char i in dtim1)
        {
            word=word+i;

        } 
        System.Console.WriteLine(word);
    }
}
