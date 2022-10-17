using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program4
{
    public class BookInfo:Departmentdetails
    {
        private static int s_bookId=100;
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string  AuthorName { get; set; }
        public int Price { get; set; }


        public BookInfo(string departmentName,string degree,string bookName,string authorName,int price):base(departmentName, degree)
        {
            s_bookId++;
            BookID="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void ShowDetails( )
        {
            ShowInfo( );
            System.Console.WriteLine("BookID : "+BookID);
            System.Console.WriteLine(" BookName : "+ BookName);
            System.Console.WriteLine("AuthorName : "+AuthorName);
            System.Console.WriteLine("Price : "+Price);
        }
    }
}