using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class OrderDetail
    {
        private static int s_orderId=500;
        public string OrderId { get;  }
        public string BookingId { get;  }
        public string ProductId { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }



        public OrderDetail(string bookingId,string productId,int purchaseCount,double priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
    }
}