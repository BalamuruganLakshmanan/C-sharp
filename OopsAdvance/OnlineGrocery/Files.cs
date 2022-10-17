using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class Files
    {
        public static void Create( )
        {
            if(!Directory.Exists("Grocery"))
            {
                System.Console.WriteLine("Creating Folder ");
                Directory.CreateDirectory("Grocery");
            }
            else 
            {
                System.Console.WriteLine("Folder is already created ");
            }
            if(!File.Exists("Grocery/CustomerDetails.csv"))
            {
                System.Console.WriteLine(" create a file ");
                File.Create("Grocery/CustomerDetails.csv");
                
            }
            else 
            {
                System.Console.WriteLine("File is already created ");
            }
            if(!File.Exists("Grocery/ProductDetail.csv"))
            {
                System.Console.WriteLine("Create a file");
                File.Create("Grocery/ProductDetail");
            }
            else 
            {
                System.Console.WriteLine("File is already created ");
            }
            if(!File.Exists("Grocery/BookingDetails.csv"))
            {
                System.Console.WriteLine("Create a file");
                File.Create("Grocery/BookingDetail.csv");
            }
            else 
            {
                System.Console.WriteLine("File is already created ");
            }
            if(!File.Exists("grocery/Orderdetails.csv"))
            {
                System.Console.WriteLine("Create a file");
                File.Create("Grocery/OrderDetail.csv");
            }
        }
   
        public static void ReadFile()
        {
            string[] customer=File.ReadAllLines("Grocery/CustomerDetail.csv");
            foreach(string  data in customer)
            {
                CustomerDetail user=new CustomerDetail(data);
                Operation.customerList.Add(user);
            }

            
        }

    }
}