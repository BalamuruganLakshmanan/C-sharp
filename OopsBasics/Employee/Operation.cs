using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{
    
    
    public static  class Operation
    {
        static PayrollDetails currentUser=null;
        static List<PayrollDetails> payrollList=new List<PayrollDetails>( );
        public static void MainMenu()
        {
            string choice=" ";
            do
            {
                  
               System.Console.WriteLine("select option 1.Registration 2.Login 3.Exit");
               int option=int.Parse(Console.ReadLine());
               switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
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
             System.Console.WriteLine("Enter the Employee Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the role: ");
            string role=Console.ReadLine();
            System.Console.WriteLine("Enter the worklocation ");
            Location place1=Enum.Parse<Location>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the Team name ");
            string team=Console.ReadLine();
            System.Console.WriteLine("Enter Your DOJ");
            DateTime doj=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);  
            System.Console.WriteLine("No of working days in month ");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("No of leave taken");
            int leave=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
             PayrollDetails employee1=new PayrollDetails(name,role,place1,team,doj,month,leave,gender);
            payrollList.Add(employee1);  
            System.Console.WriteLine("Your Employee Id is"+employee1.EmployeeId);
        }  


        public static void Login( )
        {
            System.Console.WriteLine("Enter your Registration Number: ");
            string employeeId=Console.ReadLine().ToUpper();
            foreach(PayrollDetails user in payrollList)
            {
                if(user.EmployeeId==employeeId)
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
                System.Console.WriteLine("1.Show Details, ,2.No.Of leaves,3.No.of working days,4.calculate salary 5.Exit");
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
                        System.Console.WriteLine("No.Of leaves "+currentUser.Leave);
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("No.of working days"+currentUser.Month);
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("calculate salary");
                        currentUser.SalaryCalculation( );
                        break;
                    }
                    case 5:
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