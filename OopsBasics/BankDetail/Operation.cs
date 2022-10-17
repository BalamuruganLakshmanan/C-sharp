using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetail
{
    public static class Operation
    {
        static AccountDetails currentcustomer=null;
        static List<AccountDetails> acountList=new List<AccountDetails>( );
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
            
            
            
                System.Console.WriteLine("select option 1.Registration 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login( );
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
            
        }

        public static void Registration()
        {
            System.Console.WriteLine("Get the datas from customer");
            System.Console.WriteLine("Enter the customer name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the father's name");
            string fathername=Console.ReadLine();
            System.Console.WriteLine("Enter the gender ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the Date of birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            System.Console.WriteLine("Enter the Account type");
            Account accounttype=Enum.Parse<Account>(Console.ReadLine(),true);
            AccountDetails customer1=new AccountDetails(name,fathername,gender,dob,accounttype);
            acountList.Add(customer1);
            System.Console.WriteLine("Your Application Number is:"+customer1.RegisterNumber);
        }        

        public static void Login( )
        {
            System.Console.WriteLine("Enter your Registration Number: ");
            string registerNumber=Console.ReadLine().ToUpper();
            foreach(AccountDetails customer in acountList)
            {
                if(customer.RegisterNumber==registerNumber)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentcustomer=customer;
                    SubMenu( );
                }
            }
        }

        public static void SubMenu( )
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select submenu option ");
                System.Console.WriteLine("1.Show Details, ,2.Deposit,3.Withdraw,4.Balance ,5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show details");
                        currentcustomer.ShowDetails( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Deposit");
                        currentcustomer.Deposit( );
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Withdraw");
                        currentcustomer.Withdraw();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Balance");
                        System.Console.WriteLine(currentcustomer.Balance);
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit Submenu");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
    }
}