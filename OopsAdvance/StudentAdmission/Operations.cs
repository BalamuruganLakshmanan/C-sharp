using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public delegate void EventManager( );
    public class Operations
    {
        private string _eventName;
        public static event EventManager eventlink=null;// user defined event
        static int i;
        // creating of method
        public static void Subscribe( )
        {
            eventlink +=new EventManager(Files.Create);
            eventlink +=new EventManager(Files.ReadFile);
            eventlink +=new EventManager(Operations.MainMenu);
            eventlink +=new EventManager(Files.WriteToFiles);

        }

        public static void StartEvent( )
        {
            Subscribe( );
            eventlink( );
        }
        private static AdmissionDetails currentStudent=null;
        static List<AdmissionDetails> admissionList=new List<AdmissionDetails>( );
        private static DepartmentDetails currentDepartment=null;
        static List<DepartmentDetails> departmentList=new List<DepartmentDetails>( );
        private static StudentDetails currentUser=null;
        public static List<StudentDetails> studentList=new List<StudentDetails>( );
        public static void MainMenu( )
        {
            string option="yes";
            do 
            {
                System.Console.WriteLine("Select the option 1.Registration 2.Login  3.Departmentwise Seat availability  4.Exit ");
                int choice =int.Parse(Console.ReadLine());
                switch(choice)
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
                        System.Console.WriteLine("Departmentwise Seat Availability ");
                        DepartmentSeatAvailability( );
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Exit");
                        option="no";
                        break;
                    }
                }
            }while(option=="yes");
        }
    
        public static void Registration()
        {
            System.Console.WriteLine("Enter the Student's Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("ENter the Father's Name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your date of birth: ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            System.Console.WriteLine("Enter the gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your physics mark: ");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your chemistry mark: ");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your maths marks: ");
            int maths =int.Parse(Console.ReadLine());
            StudentDetails student1=new StudentDetails(name,fatherName,dob,gender,physics,chemistry,maths);
            studentList.Add(student1);

            System.Console.WriteLine("Your Student Id is : "+student1.StudentId);
            
        }
    
        public static void Login( )
        {
            System.Console.WriteLine("Enter your Student Id : ");
            string studentId=Console.ReadLine().ToUpper();
            foreach(StudentDetails user in studentList)
            {
                if(user.StudentId==studentId)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentUser=user;
                    SubMenu( );
                   
                }
            }
        }


         public static void SubMenu( )
         {
           
            string option1="yes";
            do 
            {
                 System.Console.WriteLine("Select the Sub menu option 1.Check Eligibility 2.Show Details 3.Take Admission 4.Cancel Admission 5.Show Admission Detail 6.Exit" );
                 int choice1=int.Parse(Console.ReadLine());
                switch(choice1)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Check Eligibility");
                        bool eligibility=currentUser.CheckEligibility( );
                        if(eligibility)
                        {
                           System.Console.WriteLine("You are eligible");
                        }
                        else
                        {
                           System.Console.WriteLine("You are not eligible");

                        }
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Show details");
                        currentUser.ShowDetails( );
                        break;

                    }
                    case 3:
                    {
                        System.Console.WriteLine("Take Admission");
                        TakeAdmission( );
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Cancel Admission");
                        CancelAdmission( );
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Show Admission Details ");
                        ShowAdmissionDetail( );
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit");
                        option1="no";
                        break;
                    }
                }
            
            }while(option1=="yes"); 
         }
    
        /*public static void Defaultvalues( )
        {
            StudentDetails student2=new StudentDetails("Ravichandran","Ettaparajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
            studentList.Add(student2);
            StudentDetails student3=new StudentDetails("Baskaran","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95 );
            studentList.Add(student3);


            DepartmentDetails eee=new DepartmentDetails("EEE",29);
            departmentList.Add(eee);
            DepartmentDetails cse=new DepartmentDetails("CSE",29);
            departmentList.Add(cse);
            DepartmentDetails mech=new DepartmentDetails("Mech",30);
            departmentList.Add(mech);
            DepartmentDetails ece=new DepartmentDetails("ECE",30);
            departmentList.Add(ece);
            AdmissionDetails admission1=new AdmissionDetails(student2.StudentId,eee.DepartmentId,new DateTime(2022,05,11),Admission.Booked);
            admissionList.Add(admission1);
            AdmissionDetails admission2=new AdmissionDetails(student3.StudentId,cse.DepartmentId,new DateTime(2022,05,12),Admission.Booked);
            admissionList.Add(admission2);


        }*/

         public static void TakeAdmission( )
        {
            foreach(DepartmentDetails tempdata in departmentList)
            {
                System.Console.WriteLine(tempdata.DepartmentId+"\t"+tempdata.DepartmentName+"\t"+tempdata.NumberOfSeats);
              
            }
            System.Console.WriteLine("Please choose one department Id:");
            string departId1=Console.ReadLine();
            string data1;
             bool canAdmit=true;
            foreach(DepartmentDetails tempId in departmentList)
            {
                if(departId1==tempId.DepartmentId)
                {
                    bool eligibility=currentUser.CheckEligibility( );
                    if(eligibility)
                    {
                        data1="You are eligible";
                        System.Console.WriteLine(data1 + "  Take Admission");
                       
                        foreach(StudentDetails tempdata in studentList)
                        {
                            if(currentUser.StudentId==tempdata.StudentId)
                            {
                               foreach(AdmissionDetails temp in admissionList)
                               {
                                  if(temp.AdmissionStatus==Admission.Booked)
                                  {
                                    System.Console.WriteLine("You are already booked");
                                    canAdmit=false;
                                  }
                                  else
                                  {
                                    System.Console.WriteLine("You are eligible book the seat");
                                    canAdmit=true;
                                  }
                               }
                               

                            }
                        }

                    }
                    else
                    {
                        data1="You are not eligible";
                        System.Console.WriteLine(data1);

                    }
                                                       
                }
                if(canAdmit)
                {
                    tempId.NumberOfSeats=tempId.NumberOfSeats-1;
                }
                AdmissionDetails newAdmission=new AdmissionDetails(currentUser.StudentId,tempId.DepartmentId,DateTime.Now,Admission.Booked);
                admissionList.Add(newAdmission);

            }
            System.Console.WriteLine("“Admission took successfully. Your admission ID – "+currentUser.StudentId);
           
            
            
        }


         public static void CancelAdmission( )
         {
            foreach(AdmissionDetails tempdata in admissionList)
            {
                if(tempdata.StudentId==currentUser.StudentId)
                {
                    if(tempdata.AdmissionStatus==Admission.Booked)
                    {
                        tempdata.AdmissionStatus=Admission.Cancelled;
                        foreach(DepartmentDetails seat in departmentList)
                        {
                            if(tempdata.DepartmentId==seat.DepartmentId)
                            {
                                seat.NumberOfSeats++;
                                System.Console.WriteLine("Admission cancelled successfully");
                            }
                        }

                    }
                    
                    
                    
                  
                }
            }
         }
    
         public static void ShowAdmissionDetail( )
         {
            foreach(AdmissionDetails tempdata2 in admissionList)
            {
                if(tempdata2.StudentId==currentUser.StudentId)
                {
                    System.Console.WriteLine(tempdata2.AdmissionId+"\t"+tempdata2.DepartmentId+"\t"+tempdata2.AdmissionStatus);
                }
            }

         }
    

         public static void DepartmentSeatAvailability( )
         {
            foreach(DepartmentDetails seatAvailabile in departmentList)
            {
                System.Console.WriteLine($"DepartmentId is {seatAvailabile.DepartmentId}\t Department Name is {seatAvailabile.DepartmentName}\t Number of seats{seatAvailabile.NumberOfSeats}");
            }
         }
    }

}