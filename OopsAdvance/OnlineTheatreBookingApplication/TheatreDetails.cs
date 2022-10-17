using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public class TheatreDetails
    {
        private static int s_theatreId=300;//static field
        public string TheatreId { get;  }//auto increment property
        public string TheatreName { get; set; }//property declaration
        public string TheatreLocation { get; set; }//property declaration

        /// <summary>
        /// parameterized constructor declaration
        /// </summary>
        /// <param name="theatreName">values are used to store a data in property variable</param>
        /// <param name="theatreLocation">values are used to store a data in property variable</param>
        public TheatreDetails(string theatreName,string theatreLocation)
        {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }
        /// <summary>
        /// constructor declaration is used for inherited class
        /// </summary>
        /// <param name="theatreId"></param>
        /// <param name="theatreName"></param>
        /// <param name="theatreLocation"></param>
          public TheatreDetails(string theatreId,string theatreName,string theatreLocation)
        {
           
            TheatreId=theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }
        /// <summary>
        /// constructor declaration 
        /// </summary>
        /// <param name="data">datas are seperated by split method and datas are stored in array</param>
        
          public TheatreDetails(string data)
        {
            string[] value=data.Split(","); 
            s_theatreId= int.Parse(value[0].Remove(0,3));         
            TheatreId=value[0];
            TheatreName=value[1];
            TheatreLocation=value[2];
        }


        
    }
}