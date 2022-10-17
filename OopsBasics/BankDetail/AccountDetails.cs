using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetail
{
    public enum Gender{Default,Male,female,transgender}
    public enum Account{Default,FD,SB,RD}
    public class AccountDetails
    {
        private static int s_registerNumber=3000;
        public string RegisterNumber { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender  Gender { get; set; }
        public DateTime DOB { get; set; }
        public Account  AccountType { get; set; }
        public double Balance { get; set; }
        public AccountDetails(string name,string fathername,Gender gender,DateTime dob,Account accounttype)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fathername;
            Gender=gender;
            DOB=dob;
            AccountType=accounttype;
            
        }

        public void ShowDetails( )
        {
             System.Console.WriteLine("Name of the Account holder "+Name);
            System.Console.WriteLine("Father name of the Account holder "+FatherName);
            System.Console.WriteLine("Gender of the Account holder "+Gender);
            System.Console.WriteLine("DOB of Account holder "+DOB.ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Account type :"+AccountType);
           // System.Console.WriteLine("Available Balance :");
            System.Console.WriteLine("Application Number is:"+RegisterNumber);
            Deposit();
            Withdraw();            
           
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
    }
}