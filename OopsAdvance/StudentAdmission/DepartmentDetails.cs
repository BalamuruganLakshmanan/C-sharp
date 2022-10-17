using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    
    public enum Department{Default,EEE,CSE,MECH,ECE}
    public class DepartmentDetails
    {
        private static int s_departmentId=101;
        public string DepartmentId { get; }
        public string DepartmentName { get; set; }
       
        public int NumberOfSeats { get; set; }

        public DepartmentDetails(string departmentName,int numberOfSeats)
        {
            DepartmentId="DID"+s_departmentId++;
            DepartmentName=departmentName;
            NumberOfSeats=numberOfSeats;
        }

        public DepartmentDetails(string data)
        {
            string[] values=data.Split(',');
            s_departmentId=int.Parse(values[0].Remove(0,3));
            DepartmentId=values[1];
            DepartmentName=values[2];
            NumberOfSeats=int.Parse(values[3]);
            
        }

    }
}