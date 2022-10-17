using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IMarkDetails
    {
        //No fields
         int Physics { get; set; }//Only property declaration
         int Chemistry { get; set; }
          int Maths { get; set; }
          int Total{get; set; }
          double Average{ get; set; }
        //no constructors and objects
        //only methods declarations are allowed

        
        
    }
}