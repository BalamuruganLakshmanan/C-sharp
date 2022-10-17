using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public enum Admission{Default,Booked,Cancelled}
   
    public class AdmissionDetails
    { 
        
        private static int s_admissionId=1000;
        public string AdmissionId { get;  }
        public DateTime AdmissionDate { get;  }
        public string StudentId { get; set; }
        public string DepartmentId { get; set; }
        public Admission AdmissionStatus{ get; set; }

        public AdmissionDetails(string StudentId,string DepartmentId,DateTime AdmissionDate,Admission AdmissionStatus)
        {
            s_admissionId++;
            AdmissionId="AID"+s_admissionId;
        }

       public AdmissionDetails(string data)
       {
        string[] values=data.Split(',');
        s_admissionId=int.Parse(values[0].Remove(0,3));
            AdmissionId=values[0];

       }
    }
}