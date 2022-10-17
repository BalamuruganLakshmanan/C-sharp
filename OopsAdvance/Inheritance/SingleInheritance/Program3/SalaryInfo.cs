using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program3
{
    public class SalaryInfo
    {
        public int Leave{ get; set; }
        public int Month { get; set; }

        public SalaryInfo( int month,int leave )
        {
            Month=month;
            Leave=leave;
        }




         public void SalaryCalculation( )
            {
                int basic=500;
                int total=Month-Leave;
                int final=total*basic;
                System.Console.WriteLine("Your salary is "+final);
            }
    }
}