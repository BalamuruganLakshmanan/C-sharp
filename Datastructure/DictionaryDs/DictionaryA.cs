using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDs
{
     public partial class Dictionary<TKey, TValue>
    {
       public bool ContainsKey(TKey key)
       {
           int index=0;
           bool value=true;
           bool temp=LinearSearch(key,out  index);
           if(temp)
           {
               value=true;  
           }
           else
           {
                value=false;
           }
           return value;

       } 


       public bool ContainValue(TValue value)
       {
        bool temp1=true;
         foreach(KeyValue<TKey,TValue> element in Array)
         {
            if(element.Value.Equals(value))
            {
                temp1=true;

            }
            else 
            {
                temp1=false;
            }
           
         }
          return temp1;

       }

       public KeyValue<TKey,TValue> ElementAt(int index)
       {
          KeyValue<TKey,TValue> output=null;
          if(index>-1 && index<Count )
          {
              output=Array[index];
          }
          else 
          {
             System.Console.WriteLine("Index out of range");
          }
         return output;
        }

        public bool Remove(TKey key)
        {
            int index=0;
            bool value=true;
            bool temp=LinearSearch(key,out  index);
             if(temp)
             {
                for(int i=index;i<Count;i++)
                {
                    Array[index]=Array[index+1];
                    _count--;
                    value=true;
                }
             }
             else 
             {
                Array[index]=Array[index];
                value=false;
             }
                return value;
        }


        



    }
}