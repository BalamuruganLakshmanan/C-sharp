using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public enum Gender{Default,Male,Female}
    public class CustomerDetails
    {
        private static int s_customerId=1000;
        public string CustomerId { get;  }
        public string CustomerName { get; set; }
        public string CustomerFatherName { get; set; }
        public long PhoneNumber { get; set; }
        public Gender Gender1 { get; set; }



        public CustomerDetails(string name,string fatherName,long phoneNumber,Gender gender)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            CustomerName=name;
            CustomerFatherName=fatherName;
            PhoneNumber=phoneNumber;
            Gender1=gender;

        }

    }
}