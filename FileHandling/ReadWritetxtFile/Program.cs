using System.Net.Mime;
using Microsoft.Win32.SafeHandles;
using System.IO;
// See https://aka.ms/new-console-template for more information
using System;
namespace ReadWritetxtFile;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created");
        }
        else
        {
            System.Console.WriteLine("Folder already created");
        }

        if(!File.Exists("TestFolder/Text.txt"))
        {
            File.Create("TestFolder/Text.txt");
            System.Console.WriteLine("File Created");

        }
        else 
        {
            System.Console.WriteLine("File already created");
        }

        System.Console.WriteLine("Select the option 1.Read file info  2.Write file info ");
        int choice =int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine("Read File Info ");
                string line;
                StreamReader sr=null;
                try           
                {
                    sr=new StreamReader("TestFolder/Text.txt");
                    //read the 1st line of the text
                    line=sr.ReadLine();
                    while(line!=null)
                    {
                        System.Console.WriteLine(line);
                        //to read the next  line 
                        line=sr.ReadLine( );
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception : "+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Executing finally block ");
                        sr.Close( );
                    }

                }
                break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try
                {
                    System.Console.WriteLine("Write File Info ");
                    string[] old=File.ReadAllLines("TestFolder/Text.txt");
                     sw=new StreamWriter("TestFolder/Text.txt");
                    System.Console.WriteLine("Enter the new content to be added ");
                    string info=Console.ReadLine();
                    string old1=" ";
                    foreach(string text in old)
                    {
                        old1=old1+"\n"+text;
                    }
                        old1=old1+"\n"+info;
                        sw.WriteLine(old1);

                    


                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception : ",e.Message);
                }
                finally
                {
                    System.Console.WriteLine("Executing finally block");
                    sw.Close( );
                }
                

                break;
            }
        }

    }
}
