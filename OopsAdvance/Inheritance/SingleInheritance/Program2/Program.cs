using System.Reflection.Emit;
// See https://aka.ms/new-console-template for more information
using System;
namespace Program2;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo user1=new AccountInfo("Bala","Lakshmanan",Gender.Male,87986,new DateTime(2000,11,02),"ghghjgji@mail.com",7868687,"Chennai","cnb1785",70000);
        user1.ShowInfo( );
    }
}
