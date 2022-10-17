using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentAdmission
{
    
    public static class Files
    {
        public static void Create( )
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            else 
            {
                System.Console.WriteLine("File allready created");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("Files are already created");
            }

            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/DepartmentDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("Files are already created");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/AdmissionDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("Files are already created");
            }
        }

        public static void ReadFile( )
        {
            string[] students=File.ReadAllLines("College/Studentdetails.csv");
            foreach(string  data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.studentList.Add(student);
            }
        }
        

        public static void WriteToFiles( )
        {
            string[] studentDetails=new string[Operations.studentList.Count];
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].StudentId+","+Operations.studentList[i].Name+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy",null) + ","+Operations.studentList[i].Gender1+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry+","+Operations.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);
        }
        
    }
}