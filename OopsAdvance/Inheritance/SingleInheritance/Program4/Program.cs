// See https://aka.ms/new-console-template for more information
using System;
namespace Program4;
class Program 
{
    public static void Main(string[] args)
    {
        BookInfo book=new BookInfo("Ece","B.E","C#","Gurusamy",500);
        book.ShowDetails( );
    }
}
