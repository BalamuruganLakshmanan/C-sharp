using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Operations
    {
        private static UserDetails currentUser=null;
        static List<UserDetails> userList=new List<UserDetails>( );
        
        
        static List<Bookdetail> defaultList1=new List<Bookdetail>( );
        static List<BorrowDetails> borrowedList=new List<BorrowDetails>( );
        public static void MainMenu()
        {
            string choice="yes";
            do 
            {
                System.Console.WriteLine("Select the options : 1.Registration 2. User Login 3. Exit ");
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
                        System.Console.WriteLine("User Login");
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
            System.Console.WriteLine("Enter the User Name: ");
            string name=Console.ReadLine();                      
            System.Console.WriteLine("Enter the Gender: ");
            string gender=Console.ReadLine();
            System.Console.WriteLine("Enter the Department: ");
            Department department1=Enum.Parse<Department>(Console.ReadLine());
            System.Console.WriteLine("Enter your Mobile number: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mail Id: ");
            string mailId=Console.ReadLine();
            UserDetails user1=new UserDetails(name,gender,department1,mobileNumber,mailId);
            userList.Add(user1);
            System.Console.WriteLine("Your Register Id is: "+user1.RegisterId);
            
            
        }
    
        public static void Login( )
        {
            System.Console.WriteLine("Enter your Resister Id: ");
            string registerId=Console.ReadLine();
            foreach(UserDetails user in userList)
            {
                if(registerId==user.RegisterId)
                {
                    System.Console.WriteLine("Login successful...");
                    currentUser=user;
                    SubMenu( );
                }
                else
                {
                    System.Console.WriteLine("Invalid Register Id");
                }
            }
        }
    
        public static void SubMenu( )
        {
            string choice="yes";
            do 
            {
                System.Console.WriteLine("Select the option : 1.Borrow Book 2.Show Borrowed history  3.Return Books 4.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Borrow Book ");
                        BorrowBook( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Show Borrowed history");
                        BorrowedHistory( );
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Returned Book");
                        ReturnBook();
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
    
        public static void DefaultMethod( )
        {
            UserDetails user2=new UserDetails("Ravichandran","Male",Department.EEE,9938388333,"ravi@gmail.com");
            userList.Add(user2);
            UserDetails user3=new UserDetails("Priyadharshini","Female",Department.CSE,9944444455,"priya@gmail.com");
            userList.Add(user3);
            Bookdetail book1=new Bookdetail("C#","Auther1",3);
            defaultList1.Add(book1);
            Bookdetail book2=new Bookdetail("HTML","Auther2",5);
            defaultList1.Add(book2);
            Bookdetail book3=new Bookdetail("CSS","Auther3",3);
            defaultList1.Add(book3);
            Bookdetail book4=new Bookdetail("JS","Auther4",3);
            defaultList1.Add(book4);
            Bookdetail book5=new Bookdetail("TS","Auther5",2);
            defaultList1.Add(book5);
            BorrowDetails borrow1=new BorrowDetails( "BID101","SF3001",new DateTime(2022,04,10),Status.Issued);
            borrowedList.Add(borrow1);
            BorrowDetails borrow2=new BorrowDetails("BID103","SF3001",new DateTime(2022,04,12),Status.Returned);
            borrowedList.Add(borrow2);
            BorrowDetails borrow3=new BorrowDetails("BID104","SF3001",new DateTime(2022,04,15),Status.Issued);
            borrowedList.Add(borrow3);
            BorrowDetails borrow4=new BorrowDetails("BID102","SF3002",new DateTime(2022,04,11),Status.Returned);
            borrowedList.Add(borrow4);
            BorrowDetails borrow5=new BorrowDetails("BID105","SF3002",new DateTime(2022,04,15),Status.Issued);
            borrowedList.Add(borrow5);

        }
    
        public static void BorrowBook()
        {
            foreach(Bookdetail tempdata in defaultList1)
            {
                System.Console.WriteLine(tempdata.BookId+"\t"+tempdata.BookName+"\t"+tempdata.AutherName+"\t"+tempdata.NumberOfBook);
            }
            System.Console.WriteLine("Enter Book ID to Borrow: ");
            string bookId1=Console.ReadLine();
            DateTime newBorroweddate=new DateTime( );
            int count=0;
            foreach(Bookdetail tempdata1 in defaultList1)
            {
                if(tempdata1.NumberOfBook>1)
                {
                    foreach(UserDetails tempdata3 in userList)
                    {
                        if(currentUser.RegisterId==tempdata3.RegisterId)
                        {
                            foreach(BorrowDetails temdata in borrowedList)
                            {
                                if(temdata.RegistrationId==currentUser.RegisterId)
                                {
                                    count=count+1;
                                }
                                
                            }
                        }
                        
                    }
                    
                }
                else 
                {
                    System.Console.WriteLine("Books are not available for the selected count");
                    foreach(BorrowDetails tempdata in borrowedList)
                    {
                        if(bookId1==tempdata.BookId)
                        {
                            newBorroweddate=tempdata.BorrowedDate.AddDays(15);
                            System.Console.WriteLine("The book will be Availble on "+newBorroweddate);
                        }
                    }
                }
                
            }
            if(count>=3)
            {
                System.Console.WriteLine("Book are already issued");
            }
            else if(count<3)
            {
                BorrowDetails newborrow=new BorrowDetails(bookId1,currentUser.RegisterId,DateTime.Now,Status.Issued);
                borrowedList.Add(newborrow);
                foreach(Bookdetail tempdata4 in defaultList1)
                {
                    if(tempdata4.BookId==bookId1)
                    {
                       tempdata4.NumberOfBook-=1;
                    }
                }
                

            }
            

            
        }

        public static void BorrowedHistory( )
        {
            foreach(BorrowDetails tempdata in borrowedList)
            {
                System.Console.WriteLine(tempdata.BorrowId+"\t"+tempdata.BookId+"\t"+tempdata.RegistrationId+"\t"+tempdata.BorrowedDate+"\t"+tempdata.Status1);
            }
            
        }
    
        public static void ReturnBook( )
        {
            DateTime newborrow=new DateTime( );
            DateTime newborrow2=newborrow.AddDays(1);
            foreach(BorrowDetails tempdata5 in borrowedList)
            {
                if(tempdata5.RegistrationId==currentUser.RegisterId)
                {
                    newborrow=tempdata5.BorrowedDate.AddDays(15);
                    System.Console.WriteLine("Your Return date will be "+newborrow);
                }
                

                
            }
        }
    
    }
}