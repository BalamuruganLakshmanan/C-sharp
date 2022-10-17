using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class CustomerDetail:PersonalDetails,IBalance
    {
        private static int s_customerID=1000;
        public string CustomerID { get;  }
        public double Balance { get; set; }

        public CustomerDetail(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mailId):base(name,fatherName, gender,mobileNumber, dob,mailId)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
        }
         
          public CustomerDetail(string data)
        {
            string[] value=data.Split(",");
            s_customerID=int.Parse(value[0].Remove(0,3));
            CustomerID=value[0];
            Name=value[1];
            FatherName=value[2];
            Gender1=Enum.Parse<Gender>(value[3]);
            MobileNumber=long.Parse(value[4]);
            DOB=DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            MailId=value[6];
        }


        public void ShowCustomerDetails( )
        {
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Father Name: "+FatherName);
            System.Console.WriteLine("Gender: "+Gender1);
            System.Console.WriteLine("Mobile Number: "+MobileNumber);
            System.Console.WriteLine("DOB: "+DOB);
            System.Console.WriteLine("Mail Id : "+MailId);
            System.Console.WriteLine("Your available Balance is : "+Balance);
            System.Console.WriteLine("Your Customer Id is "+CustomerID);
            
        }


        public void WalletRecharge( )
        {
            System.Console.WriteLine("Enter the amount to be recharged: ");
            double amount=double.Parse(Console.ReadLine());
            Balance+=amount;
        }
        
    }
}