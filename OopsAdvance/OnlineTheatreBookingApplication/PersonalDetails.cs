using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public class PersonalDetails
    {
        public string Name { get; set; }//property declaration
        public int Age { get; set; }//property declaration
        public long PhoneNumber { get; set; }//property declaration

        /// <summary>
        /// parameterized constructor declaration  
        /// </summary>
        /// <param name="name">used to store a data in property variable</param>
        /// <param name="age">used to store a data in property variable</param>
        /// <param name="phoneNumber">used to store a data in propert variable</param>
        public PersonalDetails(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }

          public PersonalDetails( )//default  constructor declaration
        {
           
        }
    }
}