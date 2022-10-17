using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    public class Box
    {
        private double height;
        private double length;
        private double breadth;
        
        public Box(double height1,double length1,double breadth1)
        {
            height=height1;
            length=length1;
            breadth=breadth1;
        }
        public double CalculateVolume( )
        {
            return height*length*breadth;
        }

        public static Box operator +(Box box1,Box box2)
        {
            Box box=new Box( );
            box.length=box1.length+box2.length;
            box.breadth=box1.breadth+box2.breadth;
            box.height=box1.height+box2.height;
            return box;

         }

         public Box( )
        {
            
        }
        

    }
}