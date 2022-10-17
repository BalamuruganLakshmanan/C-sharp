// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo user1=new PersonalInfo("Bala","Lakshmanan",Gender.Male,89786998,new DateTime(2000,11,02),"bala@gmail");
        user1.ShowDetails( );
        StudentInfo student1=new StudentInfo("Bala","Lakshmanan",Gender.Male,89786998,new DateTime(2000,11,02),"bala@gmail","First","ECE","2018");
        
        student1.ShowInfo( );


    }
}