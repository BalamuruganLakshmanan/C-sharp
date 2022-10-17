using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Bookdetail
    {
        private static int s_bookId=100;
        public string BookId { get;  }
        public string BookName { get; set; }
        public string AutherName { get; set; }
        public int NumberOfBook{ get; set; }
        public Bookdetail(string bookName,string autherName,int numberOfBook)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AutherName=autherName;
            NumberOfBook=numberOfBook;
            
        }
            
    }
}