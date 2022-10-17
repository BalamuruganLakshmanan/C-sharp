using System.IO;
// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace ListFileManipulation;
class Program 
{
    public static void Main(string[] args)
    {
         List<StudentDetails> vList=new List<StudentDetails>( );
         vList.Add(new StudentDetails(){Name="Bala",FatherName="Lakshmanan",Gender1=Gender.Male,DOB=new DateTime(2000,11,02),});
         Insert(vList );
         Display( );
        

    }
    static void Insert(List<StudentDetails> vList)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            System.Console.WriteLine("File does not exit,Creating a file");
            
            File.Create("Data.csv");
        }
        else 
        {
            System.Console.WriteLine("File already found ");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var v in vList)
        {
            write.WriteLine(v.Name+","+v.FatherName+","+v.Gender1+","+v.DOB.ToString("dd/MM/yyyy"));

            
        }
        write.Close( );


       
        
    }
     static void Display( )
        {
            StreamReader sr=null;
            List<StudentDetails> student=new List<StudentDetails>( );
            if(File.Exists("Data.csv"))
            {
                sr=new StreamReader(File.OpenRead("Data.csv"));
                while(!sr.EndOfStream)
                {
                    var line =sr.ReadLine( );
                    var values=line.Split(',');
                    if(values[0]!="")
                    {
                        student.Add(new StudentDetails( ){Name=values[0],FatherName=values[1],Gender1=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                    }
                }
            }
            else 
            {
                System.Console.WriteLine("File doesn't exist");
                
            }
            sr.Close( );
                foreach(var data in student)
                {
                    System.Console.WriteLine("Name \t"+data.Name+"Father Name: "+data.FatherName+"Gender\t"+data.Gender1+"DOB\t"+data.DOB);
                }
            
        }
}
