using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetail
    {
        private static int s_BookingId=100;
        public string BookingId { get;  }
        public string CustomerId { get;  }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus1 { get; set; }



        public BookingDetail(string customerId,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_BookingId++;
            BookingId="BID"+s_BookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus1=bookingStatus;
        }


        public void ShowBookingdetails( )
        {
            System.Console.WriteLine(BookingId+"\t"+CustomerId+"\t"+TotalPrice+"\t"+DateOfBooking+"\t"+BookingStatus1);
        }


        
        
    }
}