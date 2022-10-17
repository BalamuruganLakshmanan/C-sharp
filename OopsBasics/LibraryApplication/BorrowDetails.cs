using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public  enum Status{Default,Issued,Returned}
    public class BorrowDetails
    {
        private static int s_borrowId=300;
        public string BorrowId { get;  }
        public string BookId { get; set; }
        public string RegistrationId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public Status Status1 { get; set; }

        public BorrowDetails(string bookId,string registrationId,DateTime borroweddate,Status status1)
        {
            s_borrowId++;
            BorrowId="LB"+s_borrowId;
            RegistrationId=registrationId;
            BorrowedDate=borroweddate;
            Status1=status1;
        }

    }
}