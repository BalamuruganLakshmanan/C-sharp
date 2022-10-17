using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information
using System;
namespace MultiLevelInheritance;
class Program 
{
    public static void Main(string[] args)
    {
       PersonalDetails user1=new PersonalDetails("Balamurugan","Lakshmanan",Gender.Male,8925057600); 
       PersonalDetails user2=new PersonalDetails("Rathin","Balaji",Gender.Male,6383249742);
       user1.ShowDetails( );
       
       StudentDetail student1=new StudentDetail("634876","Bala","Lakshmanan",Gender.Male,8927867,Department.ECE,"Final");
       student1.ShowStudent( );
       student1.Calculate();
       student1.GetMark(90,90,90);
       student1.ShowMarks( );
       EmployementDetails employee1=new EmployementDetails("SID3001","986798","Krishna","Subramaniyan",Gender.Male,7904665508,Department.ECE);
       employee1.ShowEmployementDetail( );
       employee1.ShowStudent( );
      

       CustomerDetails customer1=new CustomerDetails("787897987","Bala","Lakshmanan",Gender.Male,9878678567);
       customer1.ShowCustomer( );

       
    }
}
