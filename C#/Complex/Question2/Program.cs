// See https://aka.ms/new-console-template for more information
using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        double number1=Factorial(2);
        double number2=Factorial(3);
        double number3=Factorial(4);
        double number4=Factorial(5);
        
        double number5=Factorial(6);
        double number6=Factorial(7);
        double number7=Factorial(8);
        

        int Factorial( double number )
        {
            
            int fact=1;
            for(int i=1;i<=number;i++)
            {
                fact=fact*i;
                
            }
            return fact;
        }
        double result1=(2*2)/number1;
        double result2=(2*2*2)/number2;
        double result3=((2*2*2*2)/number3);
        double result4=((2*2*2*2*2)/number4);
        double result5=((2*2*2*2*2*2)/number5);
        double result6=((2*2*2*2*2*2*2)/number6);
        double result7=((2*2*2*2*2*2*2*2)/number7);
        double output=1+2+result1+result2+result3+result4+result5+result6+result7;
        System.Console.WriteLine("Output : "+output);
    }
}
