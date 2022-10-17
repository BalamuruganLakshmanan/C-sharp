// See https://aka.ms/new-console-template for more information
using System;
namespace Enumerated;
public enum Gender{Default,Male,Female,Transgender}
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("select the gender options Male,female,Transgender");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender1);
        System.Console.WriteLine("select the gender options Male,female,Transgender");
        Gender gender2=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        while(!temp || ((int)gender2<4 &&(int)gender2>0))
        {
            System.Console.WriteLine("Invalid gender \n Enter again");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),out gender2);
        }
        System.Console.WriteLine(gender2);
    }
}