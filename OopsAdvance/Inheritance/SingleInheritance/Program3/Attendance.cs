using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program3
{
    public class Attendance
    {
        public DateTime Date { get; set; }
        public double NumberOfHoursWorked { get; set; }


        public Attendance(DateTime date,double noOfHoursWorked)
        {
            Date=date;
            NumberOfHoursWorked=noOfHoursWorked;
        }
    }
}