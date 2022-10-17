using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public class Files
    {
        /// <summary>
        /// Create Method is used to create a Directory & Files
        /// </summary>
        public static void Create( )
        {
            if(!Directory.Exists("Theatre"))
            {
                System.Console.WriteLine("Create folder");
                Directory.CreateDirectory("Theatre");
            }
            else 
            {
                System.Console.WriteLine("Folder is already created");
            }
            if(!File.Exists("Theatre/Theatredetails.csv"))
            {
                System.Console.WriteLine("create File ");
                File.Create("Theatre/Theatredetails.csv");
            }
            else
            {
                System.Console.WriteLine("File is already created ");
            }
            if(!File.Exists("Theatre/MovieDetails.csv"))
            {
                System.Console.WriteLine("Create File ");
                File.Create("Theatre/MovieDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("File already created ");
            }
            if(!File.Exists("Theatre/ScreaningDetails.csv"))
            {
                System.Console.WriteLine("Create File ");
                File.Create("Theatre/ScreaningDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("File is already created ");
            }
            if(!File.Exists("Theatre/BookingDetails.csv"))
            {
                System.Console.WriteLine("Create File ");
                File.Create("Theatre/BookingDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("File is already created ");
            }
            if(!File.Exists("Theatre/UserDetails.csv"))
            {
                System.Console.WriteLine("Create  File ");
                File.Create("Theatre/UserDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("File is already created");
            }

        }
        
        /// <summary>
        /// ReadFiles Methods are used to read a data from a file and store it in an particular List
        /// </summary>
        public static void ReadFiles( )
        {
            
            string[] theatre=File.ReadAllLines("Theatre/Theatredetails.csv");
            foreach(string theatreData in theatre)
            {
                TheatreDetails theatres=new TheatreDetails(theatreData);
                Operation.theatreList.Add(theatres);
            }

            string[] movie=File.ReadAllLines("Theatre/MovieDetails.csv");
            foreach(string movieData in movie)
            {
                MovieDetails movies=new MovieDetails(movieData);
                Operation.movieList.Add(movies); 
            }

            string[] screen=File.ReadAllLines("Theatre/ScreaningDetails.csv");
            foreach(string screenData in screen)
            {
                screaningDetails screen1=new screaningDetails(screenData);
                Operation.screanList.Add(screen1);
            }

            string[] booking=File.ReadAllLines("Theatre/BookingDetails.csv");
            foreach(string bookingData in booking)
            {
                BookingDetails booking1=new BookingDetails(bookingData);
                Operation.bookingList.Add(booking1);
            }

            string[] user=File.ReadAllLines("Theatre/UserDetails.csv");
            foreach(string userData in user)
            {
                UserDetails user1=new UserDetails(userData);
                Operation.userList.Add(user1);
            }
        }

        /// <summary>
        /// WriteTofiles Methods are used to write a datas from the list to that perticular file
        /// </summary>
    
        public static void WriteToFiles( )
        {
            string[] theatreDetails=new string[Operation.theatreList.Count];
            for(int i=0;i<Operation.theatreList.Count;i++)
            {
                theatreDetails[i]=Operation.theatreList[i].TheatreId+","+Operation.theatreList[i].TheatreName+","+Operation.theatreList[i].TheatreLocation;
            }
            File.WriteAllLines("Theatre/Theatredetails.csv",theatreDetails);


             string[] movieDetails=new string[Operation.movieList.Count];
             for(int i=0;i<Operation.movieList.Count;i++)
             {
                movieDetails[i]=Operation.movieList[i].MovieId+","+Operation.movieList[i].MovieName+","+Operation.movieList[i].Language;
             }
            File.WriteAllLines("Theatre/MovieDetails.csv",movieDetails);

            
            string[] screaningDetails=new string[Operation.screanList.Count];
             for(int i=0;i<Operation.screanList.Count;i++)
             {
                screaningDetails[i]=Operation.screanList[i].MovieId+","+Operation.screanList[i].TheatreId+","+Operation.screanList[i].TicketPrice+","+Operation.screanList[i].NoOfSeats;
             }
            File.WriteAllLines("Theatre/ScreaningDetails.csv",screaningDetails);

            string[] bookingDetails=new string[Operation.bookingList.Count];
             for(int i=0;i<Operation.bookingList.Count;i++)
             {
                bookingDetails[i]=Operation.bookingList[i].BookingId+","+Operation.bookingList[i].UserId+","+Operation.bookingList[i].MovieId+","+Operation.bookingList[i].TheatreId+","+Operation.bookingList[i].SeatCount+","+Operation.bookingList[i].TotalAmount+","+Operation.bookingList[i].BookingStatus1;
             }
            File.WriteAllLines("Theatre/BookingDetails.csv",bookingDetails);


             string[] userDetails=new string[Operation.userList.Count];
             for(int i=0;i<Operation.userList.Count;i++)
             {
                userDetails[i]=Operation.userList[i].UserID+","+Operation.userList[i].Name+","+Operation.userList[i].Age+","+Operation.userList[i].PhoneNumber+","+Operation.userList[i].WalletBalance;
             }
            File.WriteAllLines("Theatre/UserDetails.csv",userDetails);


        }
    
    }
}