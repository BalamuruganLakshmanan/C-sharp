// See https://aka.ms/new-console-template for more information
using System;
namespace Program1;
class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo user1=new PersonalInfo("Bala","Lakshmanan",Gender.Male,87867,new DateTime(2000,11,02),"bala@gmail");
        user1.ShowDetails( );
        ClassTeacher teacher1=new ClassTeacher("Ram","Raja",Gender.Male,989786,new DateTime(2000,11,22),"sgiujghui","ECE","Electronics","B.E",8,new DateTime(2011,02,03));
        teacher1.ShowInfo( );
        StudentInfo student1=new StudentInfo("Arun","Sivakumar",Gender.Male,89779865,new DateTime(2000,11,23),"gmail.com","B.A","English",3);
        student1.ShowInfo( );
        PrincipalInfo principal1=new PrincipalInfo("Ram","Arul",Gender.Male,986756785,new DateTime(1999,02,23),"gfg@gmail","M.E",9,new DateTime(1898,12,12));
        principal1.ShowInfo1( );
    }
}