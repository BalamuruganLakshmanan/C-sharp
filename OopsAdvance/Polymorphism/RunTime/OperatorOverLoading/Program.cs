// See https://aka.ms/new-console-template for more information
using System;
namespace OperatorOverLoading;
class Program 
{
    public static void Main(string[] args)
    {
        Box box1=new Box(20,2,2);
        double volume1= box1.CalculateVolume( );
        System.Console.WriteLine("box1 volume is "+volume1);
        Box box2=new Box(2,2,2);
        double volume2= box2.CalculateVolume( );
       System.Console.WriteLine("Box2 volume is : " +volume2);
       Box box3;

       box3=box1+box2;
       double volume3=box3.CalculateVolume( );
       System.Console.WriteLine("box3 volume is "+volume3);


    }

    
}
