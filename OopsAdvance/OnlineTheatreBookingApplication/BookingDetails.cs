using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public enum BookingStatus{Default,Booked,cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=7000;//field element
        public string BookingId { get;  }//autoincrement property
        public string UserId { get; set; }//user Id property declaration
        public string MovieId { get; set; }//Movie Id property declaration
        public string TheatreId { get; set; }//TheatreId property declaration
        public int SeatCount { get; set; }//seat count property declaration
        /// <summary>
        /// Total amount property declaration
        /// </summary>
        /// <value>TotalAmount in double data type</value>
        public double TotalAmount { get; set; }
        /// <summary>
        /// Bookingstatus property declaration
        /// </summary>
        /// <value>Bookingststus1 in Enum </value>
        public BookingStatus BookingStatus1 { get; set; }
        /// <summary>
        /// parameterized constructor declaration
        /// </summary>
        /// <param name="userId">used to store a data  in UserId</param>
        /// <param name="movieId">used to store a data in property variables</param>
        /// <param name="theatreId">used to store a data in property variables</param>
        /// <param name="seatCount">used to store a data in property variables</param>
        /// <param name="totalAmount">used to store a data in property variables</param>
        /// <param name="bookingstatus">used to store a data in property variables</param>

        public BookingDetails(string userId,string movieId,string theatreId,int seatCount,double totalAmount,BookingStatus bookingstatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus1=bookingstatus;
        }
        /// <summary>
        /// constructor declaration used for file manipulation
        /// </summary>
        /// <param name="data">datas are stored in array and the datas are seperated by ","</param>
         public BookingDetails(string data)
        {
            string[] values=data.Split(",");
            s_bookingId=int.Parse(values[0].Remove(0,3));
            BookingId=values[0];
            UserId=values[1];
            MovieId=values[2];
            TheatreId=values[3];
            SeatCount=int.Parse(values[4]);
            TotalAmount=double.Parse(values[5]);
            BookingStatus1=Enum.Parse<BookingStatus>(values[6]);
        }
    }
}