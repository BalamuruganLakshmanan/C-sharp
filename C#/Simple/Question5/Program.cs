// See https://aka.ms/new-console-template for more information
using System;
namespace Question5;
class Program 
{
  public static void Main(string[] args)
  {
      double basicsalary=10000;
      double da=10;
      double ha=10;
      double calculation=basicsalary*(da+ha)/100;
      double calculation1=basicsalary+calculation;
      double calculation2=basicsalary*5/100;
      double finalcalculation=(basicsalary+calculation-calculation2)*12;
      System.Console.WriteLine("The annual income is "+finalcalculation);
  }


}
