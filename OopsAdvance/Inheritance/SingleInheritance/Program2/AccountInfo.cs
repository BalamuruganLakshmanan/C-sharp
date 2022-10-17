using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program2
{
    public class AccountInfo:PersonalInfo
    {
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string  IFSCCode { get; set; }
        public double  Balance { get; set; }


        public AccountInfo(string name,string fatherName,Gender gender,long phoneNumber,DateTime dob,string mail,int accountNumber,string branchName,string ifscCode,double balance):base( name, fatherName,gender,phoneNumber, dob, mail)
        {
            AccountNumber=accountNumber;
             BranchName=branchName;
             IFSCCode=ifscCode;
             Balance=balance;
        }

         public void Deposit( )
        {
            System.Console.WriteLine("Deposit the amount : ");
            double deposit=int.Parse(Console.ReadLine());
            Balance=Balance+deposit;
            System.Console.WriteLine("Your available balance is "+Balance);
            
        }
        public void Withdraw( )
        {
            System.Console.WriteLine("Withdraw the amount : ");
            double withdraw=int.Parse(Console.ReadLine());
            if(withdraw>=Balance)
            {
                Balance=Balance-withdraw;
                System.Console.WriteLine("your balance is "+Balance);
            }
            else
            {
                System.Console.WriteLine("Insufficient fund");
            }
        }

        public void ShowInfo( )
        {
            ShowDetails();
            Deposit( );
            Withdraw( );
            System.Console.WriteLine("Account Number: "+AccountNumber);
            System.Console.WriteLine("BranchName : "+BranchName);
            System.Console.WriteLine("IFSCCode : "+IFSCCode);
            System.Console.WriteLine("Balance : "+Balance);

        }
    }
}