using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBill
{
    
    public static class Operation
    {
        static ElectricityDetails currentUser=null;
        static List<ElectricityDetails> userList=new List<ElectricityDetails>( );
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
                        Login();
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
    
     
         public static void Registration( )
        {
            System.Console.WriteLine("Enter the user name ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your phone number");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail id");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Unit used");
            int unit=int.Parse(Console.ReadLine());
            ElectricityDetails user1=new ElectricityDetails(name,phone,mail,unit );
            userList.Add(user1);
            System.Console.WriteLine("Your meter id is "+user1.MeterId);
        }
    

        public static void Login( )
        {
            System.Console.WriteLine("Enter your Registration Number: ");
            string meterId=Console.ReadLine().ToUpper();
            foreach(ElectricityDetails user in userList)
            {
                if(user.MeterId==meterId)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentUser=user;
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
                System.Console.WriteLine("1.Show Details, ,2.No.Of units,3.Calculate tarrif 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show details");
                        currentUser.ShowDetail( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("No.Of units "+currentUser.Unit);
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Calculate tarrif");
                        currentUser.CalculateAmount( );
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                    
                }
            }while(choice=="yes");
        }
    
    }

}