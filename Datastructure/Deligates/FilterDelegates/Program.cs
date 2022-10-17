using System.Collections.Generic;
using System;
namespace FilterDelegates;
class Program 
{
    public static void Main(string[] args)
    {
        Person person1=new Person( ){Name="John",Age=10};
        Person person2=new Person( ){Name="Bala",Age=26};
        Person person3=new Person( ){ Name ="Krishna ",Age=53};
        Person person4=new Person ( ){Name ="Arun ",Age=21}; 
        Person person5=new Person( ){Name="Arjun",Age=26};
        Person person6=new Person( ){Name="Raja ",Age=28};
        List<Person> people=new List<Person>{person1,person2,person3,person4,person5,person6};
        DisplayPerson("Children ",people,Ischild);
         DisplayPerson("Adults ",people,IsAdult);
          DisplayPerson("Voter ",people,IsVoter);
           DisplayPerson("Children ",people,IsSenior);
       
    }
    static void DisplayPerson(string title,List<Person> people,FilterDelegate filter)
    {
        System.Console.WriteLine("People in  "+title+" list are ");
        foreach(Person p in people)
        {
            if(filter(p))
            {
                System.Console.WriteLine("{0} , is {1} old ",p.Name,p.Age);
            }
        }
        
    }

    static bool Ischild(Person p){  return p.Age<15 ;}
    static bool IsVoter(Person p){ return p.Age>=18;}
    static bool IsAdult(Person p){if(p.Age>=18 && p.Age <50){return true;} else{return false;}}
    static bool IsSenior(Person p){return p.Age>=50;}
}