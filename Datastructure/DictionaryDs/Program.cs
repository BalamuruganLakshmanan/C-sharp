
using System.Collections.Generic;
using System;
namespace DictionaryDs;
class Program 
{
    public static void Main(string[] args)
    {
        Dictionary<int,string> mydict=new Dictionary<int, string>();
        mydict.Add(0,"hjfkjh");
        mydict.Add(1,"Bala");
        mydict.Add(2,"Arun");
        mydict.ElementAt(2);
        mydict.Remove(1);
        mydict.ContainsKey(0);
        mydict.ContainValue("Bala");
      


    }
}
