using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information
using System;
namespace SingleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
       PersonalDetails user1=new PersonalDetails("Balamurugan","Lakshmanan",Gender.Male,8925057600); 
       PersonalDetails user2=new PersonalDetails("Rathin","Balaji",Gender.Male,6383249742);
       user1.ShowDetails( );
       
       StudentDetail student1=new StudentDetail("634876","Bala","Lakshmanan",Gender.Male,8927867,Department.ECE,"Final");
       student1.ShowStudent( );
    }
}
