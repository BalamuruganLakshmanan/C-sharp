using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBill
{
   
    public class ElectricityDetails
    {
        private static int s_meter=1000;
        public string MeterId { get; set; }
        public string UserName { get; set; }
        public long Phone { get; set; }
        public string MailId{ get; set; }
        public int Unit { get; set; }
       
        public ElectricityDetails(string name,long phone,string mail,int unit)
        {
            s_meter++;
            MeterId="EB"+s_meter;
            UserName=name;
            Phone=phone;
            MailId=mail;
            Unit=unit;

            

        }
        public void ShowDetail( )
        {
            System.Console.WriteLine("User name is "+UserName);
            System.Console.WriteLine("Phone Number  "+Phone);
            System.Console.WriteLine("Mail Id "+MailId);
            System.Console.WriteLine("Unit used "+Unit);
            CalculateAmount( );
        }
        public void CalculateAmount( )
        {
            if(Unit<100)
            {
                System.Console.WriteLine("Free current");
            }
            else if(Unit>100 && Unit<=200)
            {
                System.Console.WriteLine("your bill is "+((Unit-100)*3)+"Rs");
            }
            else if(Unit>200 && Unit<=400)
            {
                System.Console.WriteLine("Your bill is "+((Unit-100)*5)+"Rs");
            }
            else if(Unit>400)
            {
                System.Console.WriteLine("Your bill is "+((Unit-100)*6)+"Rs");
            }
        }

    }
}