using System;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDs
{
    public  partial class KeyValue<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        
    }

    public partial class Dictionary<TKey, TValue>
    {
        private int _count=0;
        public int _capacity=0;
        private int Count{get{return _count;}}
   
        public int Size{get{return _capacity;}}




        public KeyValue<TKey,TValue>[] Array{ get;set;}


        public TValue this[TKey key]//Indexer
        {
            get 
            {
                TValue output=default(TValue);
                int index=0;
                bool temp=LinearSearch(key,out  index);
                if(temp)
                {
                    output=Array[index].Value;

                }
                else 
                {
                    System.Console.WriteLine("Invalid Key ");
                }
                return output;

            }
            set
            {
                int position=0; 
                bool temp=LinearSearch(key,out  position);
                if(temp)
                {
                    Array[position].Value=value;
                }
                else 
                {
                    System.Console.WriteLine(" Invalid Key ");
                }

            }
        }


        public Dictionary(int _capacity )
        {
            if(_capacity==0)
            {
                _capacity=4;_count=0;
                Array=new KeyValue<TKey,TValue>[_capacity];

            }
            else if(_capacity>0)
            {
                Array =new KeyValue<TKey,TValue>[_capacity*2];

            }
        }
         public Dictionary( )
        {
           
                _capacity=4;_count=0;
                Array=new KeyValue<TKey,TValue>[_capacity];

            
        }

        public void Add( TKey key,TValue value)
        {
            if(_capacity==_count)
            {
                Expand( );
            }
           
            bool temp =LinearSearch(key,out int index);
            if(temp==true)
            {
                System.Console.WriteLine("Duplicate value ");
            }
            else 
            {
                 KeyValue<TKey,TValue> entry=new KeyValue<TKey, TValue>( );
               entry.Key=key;entry.Value=value;
               Array[_count]=entry;
               _count++;

            }

            



        }

        public void Expand( )
        {
            _capacity=_capacity*2;
            KeyValue<TKey,TValue>[] temp=new KeyValue<TKey, TValue>[_capacity];
            for(int i=0;i<Count;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }

        public bool LinearSearch(TKey key,out int index )
        {
             bool value=true;
             index=0;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Key.Equals(key))
                {
                    index=i;
                    value=true;
                }
                else 
                {
                    index=i;
                    value= false;
                }
            }
            return value;
           

        }




    }
}