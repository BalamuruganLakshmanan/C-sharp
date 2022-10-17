using System;
using System.IO;
namespace FilesAndFolders;
class Progarm 
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\BalamuruganLakshmana\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=path+"/Bala";
        string filePath=path+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found & creating a new folder");
            Directory.CreateDirectory(folderPath);

        }
        else 
        {
            System.Console.WriteLine("Directory found");
        }

        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found & creating a new file");
            File.Create(filePath);
        }
        else 
        {
            System.Console.WriteLine("File found");
        }
        System.Console.WriteLine("Select option 1.Create Folder 2.Create file 3.Delete Folder 4.Delete File");
        int option =int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Create Folder ");
                System.Console.WriteLine("Enter your name you want to create a folder ");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                if(!Directory.Exists(newPath))
                {
                   System.Console.WriteLine("Folder not found & creating a new folder");
                    Directory.CreateDirectory(newPath);

                }
                else 
                {
                    System.Console.WriteLine("Directory found");
                }

                break;
            }
            case 2:
            {
                System.Console.WriteLine("Create File ");
                System.Console.WriteLine("Enter a file name: ");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter your file extension : ");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+extension;
                if(!File.Exists(newPath))
                {
                    System.Console.WriteLine("File not found & creating a new file");
                    File.Create(newPath);
                }
                else 
                {
                   System.Console.WriteLine("File found");
                }
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Delete Folder ");
                foreach(string name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to folder ");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                        try
                        {
                            Directory.Delete(newPath);
                            System.Console.WriteLine("Folder deleted ");

                        }catch(DirectoryNotFoundException e)
                        {
                            System.Console.WriteLine("Directory not found", e);
                        }
                        
                        
                    }
                }
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Delete File");
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete ");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter the file extension you want to delete: ");
                string name2=Console.ReadLine();
                 string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        try
                        {
                            File.Delete(newPath);
                            System.Console.WriteLine("File deleted ");

                        }catch(DirectoryNotFoundException e)
                        {
                            System.Console.WriteLine("Directory not found",e);
                        }
                    }
                }
                break;
            }
        }
    }
}
