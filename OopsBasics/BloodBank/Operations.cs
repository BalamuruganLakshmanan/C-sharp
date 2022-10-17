using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Operations
    {
        private static Donar currentDonar=null;
        
        static List<Donar> donarList=new List<Donar>( );
        public static void MainMenu( )
        {
            
             string option="yes";
            do 
            {
                System.Console.WriteLine("Select the option 1.Registration 2.User Login  3.Fetch Donor Details   4.Exit");
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
                        System.Console.WriteLine("User Login");
                        Login( );
                        SubMenu( );
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Fetch Donor Details");
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
        
    
        public static void Registration( )
        {
            System.Console.WriteLine("Enter the donar name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your age");
            int age =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mobile number");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Blood group");
            string bloodGroup=Console.ReadLine();
            System.Console.WriteLine("Enter the Last Donation :");
            DateTime lastDonation = DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
           
            Donar donar1=new Donar(name,age,mobile,bloodGroup,lastDonation);
            donarList.Add(donar1);
            System.Console.WriteLine("Your Donar id is : "+donar1.DonarId);
        }
    
        public static void Login( )
        {
            System.Console.WriteLine("Enter your Donar ID ");
            string donarId=Console.ReadLine().ToUpper();
            foreach(Donar user in donarList)
            {
                if(user.DonarId==donarId)
                {
                    System.Console.WriteLine("Login Successfully");
                    currentDonar=user;
                  
                }
            }
        }
    

          public static void SubMenu( )
          {

            string option="yes";
            do 
            {
                System.Console.WriteLine("Select the option 1.Donate Blood  2.Donation History  3.Next Eligible Date   4.Exit");
                int choice =int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Donate Blood ");
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Donation History");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Next Eligible Date");
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
    
         public static void  DonateBlood( )
         {
            System.Console.WriteLine("Enter your weight: ");
            int weight=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Blood pressure");
            int bloodPressure=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your hemoglobin count ");
            int hemoglobinCount=int.Parse(Console.ReadLine());
            DateTime lastDonation1=new DateTime();
            DateTime lastDonation2=new DateTime();
            foreach(Donar tempdonar in donarList)
            {
                lastDonation1=tempdonar.LastDonation.AddDays(60);
                lastDonation2=lastDonation1.AddDays(1);
            }
            if(weight>50 && bloodPressure<130 && hemoglobinCount>13 && lastDonation2>lastDonation1 )
            {
                System.Console.WriteLine("You are eligible to donate");
                
            }
            else 
            {
                System.Console.WriteLine("Your are not not eligible to donate");
            }
            
            

            
            

         } 
    
         
    }
}