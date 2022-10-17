using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userId=1000;//static field
        public string UserID { get;  }//auto increment property
        public double WalletBalance { get; set; }//interface property declaration

        /// <summary>
        /// constructor declaration 
        /// </summary>
        /// <param name="name">used to store a data in property variable</param>
        /// <param name="age">used to store a data in property variable</param>
        /// <param name="phoneNumber">used to store a data in property variable</param>
        /// <param name="walletBalance">used to store a data in property variable</param>
        /// <returns></returns>
        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base( name, age, phoneNumber)
        {
            s_userId++;
            UserID="UID"+s_userId;
            WalletBalance=walletBalance;

        }
        /// <summary>
        /// constructor declaration
        /// </summary>
        /// <param name="data">datas are separated by split method and values are stored in array</param>

         public UserDetails(string data)
        {
            string[] values=data.Split(",");
            s_userId=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            PhoneNumber=long.Parse(values[3]);
            WalletBalance=double.Parse(values[4]);

        }

        public void RechargeWallet(double amount )//interface method definition
        {
            double walletBalance=0;
            walletBalance=walletBalance+amount;

        }
        
    }
}