using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    /// <summary>
    /// It is a Interface .It has only a property declaration and method declaration and it does not have constructors and fields 
    /// </summary>
    public interface IWallet
    {
        public double WalletBalance { get; set; }

        void RechargeWallet(double amount);
        
    }
}