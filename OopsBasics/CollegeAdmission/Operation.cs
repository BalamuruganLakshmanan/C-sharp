using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Operation
    {
        static StudentDetail  currentStudent=null;
        static List<StudentDetail> studentList=new List<StudentDetail>( );
         public static void MainMenu( )
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
                        Registration( );
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
    
        public static void Registration( )
        {
            
            System.Console.WriteLine("Get the datas from student");
           
            System.Console.WriteLine("Enter the student name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the father's name");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter the Date of birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            System.Console.WriteLine("Enter the gender ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            System.Console.WriteLine("Enter the phone number");
            long phone =long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mail id ");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Enter your Physics Mark");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your chemistry Mark ");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Maths Mark ");
            int maths=int.Parse(Console.ReadLine());
             StudentDetail student1=new StudentDetail(name,fatherName,dob,gender,phone,physics,chemistry,maths);
            studentList.Add(student1);
            System.Console.WriteLine("Your Application Number is:"+student1.RegisterNumber);
        }


         public static void Login( )
        {
            System.Console.WriteLine("Enter your Registration Number: ");
            string registerNumber=Console.ReadLine().ToUpper();
            foreach(StudentDetail customer in studentList)
            {
                if(customer.RegisterNumber==registerNumber)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentStudent=customer;
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
                System.Console.WriteLine("1.Show Details, ,2.Check eligibility,3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show details");
                        currentStudent.ShowDetails( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Check Eligibility");
                         bool eligible=currentStudent.CheckEligiblity( );
                        if(eligible)
                        {
                           System.Console.WriteLine("You are eligible");
                        }
                        else
                        {
                           System.Console.WriteLine("You are not eligible");

                        }
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
    }
}