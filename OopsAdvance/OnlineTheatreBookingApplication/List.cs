using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreBookingApplication
{
    public partial  class List<Type>
    {
         private int _count;//field declaration
        private int _capacity;//field declaration
        
        public int Count { get{return _count; } }//property declaration
        public int Capacity { get{return _capacity;} }// property declaration

        public Type[] Array { get; set; }// property declaration

        public Type this[int i]
        {
            get {return Array[i];  }
            set {Array[i]=value;  }
        }// indexer declaration

        public List( )// default constructor declaration
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }

        public List(int size)// parameterized constructor declaration
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }

        public void Add(Type data)// Add method with definition
        {
            if(_count==_capacity)
            {
                Expand( );
            }
            Array[_count]=data;
            _count++;
        }


        public void Expand( )//Expand method with definition
        {
            _capacity=_capacity*2;
            Type[] Array1=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];

            }
            Array=Array1;
        }

        
    }
}