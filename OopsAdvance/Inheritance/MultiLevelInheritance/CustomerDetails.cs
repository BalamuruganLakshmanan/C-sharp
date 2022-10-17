using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerId=1000;
        public string CustomerId { get;  }
        public double Balance { get; set; }


        public CustomerDetails(string aID,string name,string fatherName,Gender gender,long phoneNumber ):base( aID,name,fatherName,gender, phoneNumber)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
        }

        public void Recharge( )
        {
            System.Console.WriteLine("Enter the amount to recharge: ");
             Balance+=double.Parse(Console.ReadLine());
             System.Console.WriteLine("Balance is : "+Balance);
        }

        public void ShowCustomer( )
        {
            System.Console.WriteLine("Customer Id is "+CustomerId);
            ShowDetails();
            Recharge( );
        }

    }
}