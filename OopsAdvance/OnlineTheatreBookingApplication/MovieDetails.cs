using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public class MovieDetails
    {
        public string MovieId { get; set; }// property declaration
        public string MovieName { get; set; }//property declaration
        public string Language { get; set; }//property declaration

        /// <summary>
        /// parameterized constructor declaration
        /// </summary>
        /// <param name="movieId">used to store a data in property variable</param>
        /// <param name="movieName">used to store a data in a property variable</param>
        /// <param name="language">used to store a data in property variable</param>

        public MovieDetails(string movieId,string movieName,string language)
        {
            MovieId=movieId;
            MovieName=movieName;
            Language=language;
        }
        /// <summary>
        /// constructor declaration used for file manipulation
        /// </summary>
        /// <param name="data">datas are separated by split method and stored in array</param>
        public MovieDetails(string data)
        {
            string[] values=data.Split(",");
            MovieId=values[0];
            MovieName=values[1];
            Language=values[2];
        }
    }
}