using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Used to process the college admission using this application
/// </summary>

namespace CollegeAdmission
{
    /// <summary>
    /// Used to select student's gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// class <see cref="StudentDetail"/> used to collect student's  details for the admisson process
    /// </summary>
    public class StudentDetail
    {
        /// <summary>
        /// Field used to increment the Register Number of the student
        /// </summary>
        private static int s_registerNumber=3000;
        //public string Name { get{return _name;} set{_name=value;} }
        /// <summary>
        /// Property used to Provide the register number of the student in object of <see cref="StudentDetail" />
        /// </summary>
        
        public string RegisterNumber { get; }
        /// <summary>
        /// property used to provide the name of the student in object of<see cref="StudentDetail" />
        /// </summary>
       
        
        public string Name { get; set; }
        /// <summary>
        /// Property used to provide the fathername of the student<see cref="StudentDetail"/>
        /// </summary>
        
        public string FatherName { get; set; }
        /// <summary>
        /// Property used to provide the date of birth of the student<see cref="StudentDetail"/>
        /// </summary>
        
        public DateTime DOB { get; set; }
        /// <summary>
        /// Property used to provide the gender of the student<see cref="StudentDetail"/>
        /// </summary>
        
        public Gender Gender { get; set; }
        /// <summary>
        /// property used to provide the number of the student<see cref="StudentDetail"/>
        /// </summary>
        
        public long Phone { get; set; }
        /// <summary>
        /// Property used to provide the MailId of the student<see cref="StudentDetail"/>
        /// </summary>
        
        public string Mail { get; set; }
        /// <summary>
        /// Property used to provide the physics mark of the student<see cref="StudentDetail"/>
        /// </summary>
      
        public int Physics { get; set; }
        /// <summary>
        /// Property used to provide the chemistry mark of the student<see cref="StudentDetail"/>
        /// </summary>
        
        public int Chemistry { get; set; }
        /// <summary>
        /// Property used to provide the maths mark of the student<see cref="StudentDetail"/>
        /// </summary>
        /// <value></value>
        public int Maths { get; set; } 
        /*public StudentDetail()
        {
            Name="Your name";
            FatherName="Your father Name";
        } */
        /// <summary>
        /// Constructor is used to assign the values to the property variables<see cref="StudentDetail"/>
        /// </summary>
        /// <param name="name">name is used to initialize the Name of the student</param>
        /// <param name="fathername">fathername is used to initialize the Father name of the student</param>
        /// <param name="dob">It is used to initialize the DOB of the student</param>
        /// <param name="gender">It is used to initialize the Gender of the student</param>
        /// <param name="phone">It is used to initialize the Phone number of the student</param>
        /// <param name="physics">It is used to initialize the physics mark of the student</param>
        /// <param name="chemistry">It is used to initialize the chemistry mark of the student</param>
        /// <param name="maths">It is used to initialize the maths mark of the student</param>
        public StudentDetail(string name,string fathername,DateTime dob,Gender gender,long phone,int physics,int chemistry,int maths)
        {
            s_registerNumber++;
            RegisterNumber ="SF"+s_registerNumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            Mail=Mail;
            Phone=phone;
            Chemistry=chemistry;
            Physics=physics;
            Maths=maths;
        }
        public void ShowDetails( )
        {
            System.Console.WriteLine("Enter your name " +Name);
            System.Console.WriteLine("Enter the father's name "+FatherName);
            System.Console.WriteLine("Enter the Date of birth "+DOB.ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Enter the gender "+Gender);
            System.Console.WriteLine("Enter the phone number "+Phone);
            System.Console.WriteLine("Enter the mail id "+Mail);
            System.Console.WriteLine("Enter your physics Mark "+Physics);
            System.Console.WriteLine("Enter your Chemistry Mark "+Chemistry);
            System.Console.WriteLine("Enter your Maths Mark "+Maths);
            System.Console.WriteLine("Register number is "+RegisterNumber);
            bool eligible=CheckEligiblity( );
            if(eligible)
            {
                System.Console.WriteLine("You are eligible");
            }
            else
            {
                System.Console.WriteLine("You are not eligible");

            }
        }
        public bool CheckEligiblity( )
        {
            double cutoff=75;
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if(average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}