using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public class screaningDetails
    {
        /// <summary>
        /// Movie Id property declared 
        /// </summary>
        /// <value>values are string data types</value>
        public string MovieId { get; set; }
        /// <summary>
        /// TheatreId  property declared
        /// </summary>
        /// <value>values are string </value>
        public string TheatreId { get; set; }
        /// <summary>
        /// No of seats property declared
        /// </summary>
        /// <value>values are in integer</value>
        public int NoOfSeats { get; set; }
        /// <summary>
        /// Ticket Price Property are declared
        /// </summary>
        /// <value>values are in double</value>
        public double TicketPrice { get; set; }

        /// <summary>
        /// Constructor declaration
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="theatreId"></param>
        /// <param name="noOfSeats"></param>
        /// <param name="ticketPrice"></param>
        public screaningDetails(string movieId,string theatreId,int noOfSeats,double ticketPrice)
        {
            MovieId=movieId;
            TheatreId=theatreId;
            NoOfSeats=noOfSeats;
            TicketPrice=ticketPrice;
        }
        /// <summary>
        /// Constructor is used for file Manipulation
        /// </summary>
        /// <param name="data"></param>
          public screaningDetails(string data)
        {
            string[] values=data.Split(",");
            MovieId=values[0];
            TheatreId=values[1];
            NoOfSeats=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }

    }
}