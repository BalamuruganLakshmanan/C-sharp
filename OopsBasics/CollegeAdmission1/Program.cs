// See https://aka.ms/new-console-template for more information
using System;
namespace CollegeAdmission1;
class Program 
{
    public static void Main(string[] args)
    {
        string willinng=" ";
        
        do
        {
            
            System.Console.WriteLine("Get the datas from student");
            StudentDetail student1=new StudentDetail();
            System.Console.WriteLine("Enter the student name");
            string name=Console.ReadLine();
            student1.Name=name;
            System.Console.WriteLine("Enter the father's name");
            student1.FatherName=Console.ReadLine();
            System.Console.WriteLine("Enter the Date of birth");
            student1.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
            System.Console.WriteLine("Enter the gender ");
            student1.Gender=Console.ReadLine();
            System.Console.WriteLine("Enter the phone number");
            student1.Phone =long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mail id ");
            student1.Mail=Console.ReadLine();
            System.Console.WriteLine("Enter your Physics Mark");
            student1.Physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your chemistry Mark ");
            student1.Chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Maths Mark ");
            student1.Maths=int.Parse(Console.ReadLine());
            studentList.Add(student1);
            System.Console.WriteLine("Are you willing to join in this college");
            willing=Console.ReadLine().ToLower();
            
        }while(willing=="yes");
        
    }
}
