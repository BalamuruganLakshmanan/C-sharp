using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Files
    {
        public static void Create( )
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Directory");
            }
            else 
            {
                System.Console.WriteLine("File allready created");
            }
            if(!File.Exists("College/StudentDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            else 
            {
                System.Console.WriteLine("Files are already created");
            }
        }
        
    }
}