using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public delegate void EventManager();    
       
    
    public class Operation
    {
        private string _eventName;
        public static event EventManager eventlink=null;
        static int i;

        public static void Subscribe( )
        {
            eventlink +=new EventManager(Files.Create);
            eventlink +=new EventManager(Files.ReadFiles);
            eventlink +=new EventManager(Operation.MainMenu);
            eventlink +=new EventManager(Files.WriteToFiles);

        }

        public static void StartEvent()
        {
            Subscribe( );
            eventlink( );
        }
        
        private static UserDetails currentUser=null;
        public static  List<UserDetails> userList=new List<UserDetails>( );
        public static List<TheatreDetails> theatreList=new List<TheatreDetails>( );
        public static List<BookingDetails> bookingList=new List<BookingDetails>( );
        public static List<MovieDetails> movieList=new List<MovieDetails>( );
        public static List<screaningDetails> screanList=new List<screaningDetails>( );
        public static void MainMenu( )
        {
            string choice="yes";
            do 
            {
                System.Console.WriteLine("Main Menu");
                System.Console.WriteLine("Select the option : 1.User Registration  2. Login 3.Main Menu Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        UserRegistration( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine(" Login ");
                        Login( );
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine(" Exit ");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
            
        }
   
        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter the Name :");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Wallet Balance: ");
            double walletBalance=double.Parse(Console.ReadLine());
            UserDetails user1=new UserDetails(name,age,phoneNumber,walletBalance);
            userList.Add(user1);


            System.Console.WriteLine("Your User Id is:  "+user1.UserID);
        }
   
        public static void Login( )
        {
            System.Console.WriteLine("Enter your User Id : ");
            string userId1=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(userId1==user.UserID)
                {
                    System.Console.WriteLine("Login successful...");
                    currentUser=user;
                    SubMenu( );
                }
                else 
                {
                    System.Console.WriteLine("Invalid user Id");
                }
                
            }
            
        }
   
         
        public static void SubMenu( )
        {
            string choice="yes";
            do 
            {
                System.Console.WriteLine("Select the option : 1.Ticket Booking 2.Ticket Cancellation 3.Booking History 4.Wallet Recharge 5.Sub Menu Exit");
                int option =int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Ticket Booking ");
                        TicketBooking( );
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Ticket Cancellation ");
                        TicketCancellation( );
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Booking History ");
                        BookingHistory( );
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Wallet Recharge ");
                        System.Console.WriteLine("Enter the amount to be recharged: ");
                        double amount=int.Parse(Console.ReadLine());
                        currentUser.RechargeWallet(amount);
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Sub Menu Exit");
                        choice ="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
   
   
         public static void TicketBooking( )
         {
            ShowTheatreDetail( );
            System.Console.WriteLine("select a Theatre using Theatre ID: ");
            string theatreId1=Console.ReadLine();
            foreach(TheatreDetails theatre in theatreList)
            {
                if(theatreId1==theatre.TheatreId)
                {
                    foreach(screaningDetails movie in screanList)
                    {
                        if(theatreId1==movie.MovieId)
                        {
                            System.Console.WriteLine(movie.MovieId);
                            foreach(MovieDetails movieData in movieList)
                            {
                                if(movie.MovieId==movieData.MovieId)
                                {
                                    System.Console.WriteLine(movie.MovieId+"\t"+movieData.MovieName+"\t"+movieData.Language);
                                }
                            }
                        }

                    }
                }
            }
            System.Console.WriteLine("Select a movie from list of screened movies using MovieID");
            string movieId1=Console.ReadLine();
            System.Console.WriteLine("Enter the count you wish to book");
            int count=int.Parse(Console.ReadLine());
            double totalAmount=0;
            int tempSeat=0;
            foreach(screaningDetails screendata in screanList)
            {
                if(movieId1==screendata.MovieId && count<=screendata.NoOfSeats)
                {
                    totalAmount=count*screendata.TicketPrice+0.18;
                    tempSeat=screendata.NoOfSeats;
                }
                else 
                {
                    System.Console.WriteLine("Required seat count is not available.");
                    System.Console.WriteLine("Currently availble seat is : "+screendata.NoOfSeats);
                }
            }
            if(totalAmount>=currentUser.WalletBalance)
            {
                currentUser.WalletBalance=currentUser.WalletBalance-totalAmount;
                tempSeat=tempSeat-count;

            }
            else 
            {
                System.Console.WriteLine("Insufficient wallet balance .Please recharge your wallet ");
            }
            BookingDetails booking2=new BookingDetails(currentUser.UserID,movieId1,theatreId1,count,totalAmount,BookingStatus.Booked);
            bookingList.Add(booking2);
            
            
         }

         public static void ShowTheatreDetail( )
         {
            foreach(TheatreDetails theatre in theatreList)
            {
                System.Console.WriteLine(theatre.TheatreId+"\t"+theatre.TheatreName+"\t"+theatre.TheatreLocation);
            }
         }
   
         public static void TicketCancellation( )
         {
            BookingHistory( );
            System.Console.WriteLine("Enter the booking Id you  have to cancel: ");
            string bookingId1=Console.ReadLine().ToUpper( );
            int count1=0;
            string tempMovieId="";
            string tempTheatreId="";
            double tempAmount=0;
            foreach(BookingDetails bookingData in bookingList)
            {
                if(bookingId1==bookingData.BookingId && bookingData.BookingStatus1==BookingStatus.Booked)
                {
                    count1=bookingData.SeatCount;
                    tempAmount=bookingData.TotalAmount-20;
                    tempTheatreId=bookingData.TheatreId;
                    tempMovieId=bookingData.MovieId;
                }
            }
            foreach(screaningDetails screen in screanList)
            {
                if(screen.MovieId==tempMovieId)
                {
                    screen.NoOfSeats+=count1;
                  
                }
            }
            currentUser.RechargeWallet(tempAmount);
            BookingDetails booking4=new BookingDetails(currentUser.UserID,tempMovieId,tempTheatreId,0,tempAmount,BookingStatus.cancelled);
            bookingList.Add(booking4);
            

         }

         public static void BookingHistory()
         {
            foreach(BookingDetails booking in bookingList)
            {
                if(currentUser.UserID==booking.UserId)
                {
                    System.Console.WriteLine(booking.BookingId+"\t"+booking.UserId+"\t"+booking.MovieId+"\t"+booking.TheatreId+"\t"+booking.SeatCount+"\t"+booking.TotalAmount+"\t"+booking.BookingStatus1);

                }
            }
         }
   
   
   }
}