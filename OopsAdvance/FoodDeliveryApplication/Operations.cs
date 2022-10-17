using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public class Operations
    {
        private static CustomerDetails currentUser=null;

        static List<CustomerDetails> customerList=new List<CustomerDetails>( );
        public static void MainMenu( )
        {
            string choice="yes";
            do 
            {
                System.Console.WriteLine("Select the option 1.Customer Registration  2.	Customer Login  3.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Customer Registration ");
                        CustomerRegistration( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Customer Login ");
                        CustomerLogin( );
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
   
         public static void CustomerRegistration( )
         {
            System.Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your father name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            CustomerDetails customer1=new CustomerDetails(name,fatherName,phoneNumber,gender);
            customerList.Add(customer1);

            System.Console.WriteLine("Your customer Id is : "+customer1.CustomerId);
            

         }
   
        
          public static void CustomerLogin( )
          {
            System.Console.WriteLine("Enter your Customer Id : ");
            string customerId1=Console.ReadLine();
            
            foreach(CustomerDetails user in customerList)
            {
                if(customerId1==user.CustomerId)
                {
                    System.Console.WriteLine("Login Successful...");
                    currentUser=user;
                    SubMenu( );

                }
                else 
                {
                    System.Console.WriteLine("Invalid Customer ID .Please enter the correct Customer Id ");
                }
            }
          }

           public static void SubMenu( )
           {
            string choice ="yes";

            do 
            {
                System.Console.WriteLine("Select the option : 1.Show Food Item Details  2.Order Food 3.Cancel order 4.Cancel Booking 5.Order History 6.Recharge wallet 7.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Food Item Details ");
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Order Food");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel order ");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Cancel Booking ");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Order History ");
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Recharge wallet   ");
                        break;
                    }
                    case 7:
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