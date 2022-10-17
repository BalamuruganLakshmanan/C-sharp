using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public partial class List<Type>
    {
        private int _count;
        private int _capacity;
        
        public int Count { get{return _count; } }
        public int Capacity { get{return _capacity;} }

        public Type[] Array { get; set; }

        public Type this[int i]
        {
            get {return Array[i];  }
            set {Array[i]=value;  }
        }

        public List( )
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }

        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }

        public void Add(Type data)
        {
            if(_count==_capacity)
            {
                Expand( );
            }
            Array[_count]=data;
            _count++;
        }


        public void Expand( )
        {
            _capacity=_capacity*2;
            Type[] Array1=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];

            }
            Array=Array1;
        }

        public void AddRange(List<Type> data)
        {
            Type[] Array2=new Type[_capacity+data.Count];
            for(int i=0;i<_count;i++)
            {
                Array2[i]=Array[i];
            }
            for(int i=0; i<data.Count;i++)
            {
                Array2[Count+i]=Array[i];
            }
            _count+=data.Count;
            Array=Array2;

        }
        
    }
}