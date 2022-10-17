// See https://aka.ms/new-console-template for more information
using System;
namespace StudentDetails;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the student's Name");
        string myName=Console.ReadLine();
        Console.WriteLine("Enter the student's Father Name");
        string fatherName=Console.ReadLine();
        Console.WriteLine("Enter the student's Mail id");
        string mailId=Console.ReadLine();
        Console.WriteLine("Enter the student's phone number");
        long phoneNumber=long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the student's age");
        int age=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the gender");
        string gender=Console.ReadLine();
        Console.WriteLine("Enter the Maths mark");
        float mathsMark=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the physics Mark");
        float physicsMark=float.Parse(Console.ReadLine());
        Console.WriteLine("Enyter the chemistry marks");
        float chemistryMark=float.Parse(Console.ReadLine());
        float sum=mathsMark+physicsMark+chemistryMark;
        float average= sum/3;
        Console.WriteLine("average value is: "+average);
        float percent= (sum/600)*100;
        Console.WriteLine("percent value is" +percent +"%");
        Console.WriteLine("Students name:"+myName);
        Console.WriteLine("Father's Name:" +fatherName);
        Console.WriteLine("Mail id:" +mailId);
        Console.WriteLine("Phone Number:" +phoneNumber);
        Console.WriteLine("Age :" +age);
        Console.WriteLine("Gender:" +gender);
        Console.WriteLine("Chemistry Mark:" +chemistryMark);
        Console.WriteLine("physics Mark:" +physicsMark);
        Console.WriteLine("Maths Mark" +mathsMark);
        Console.WriteLine("Average is:" +average);
        Console.WriteLine("percentage is:" +percent);
        Console.ReadLine();



    }
}
