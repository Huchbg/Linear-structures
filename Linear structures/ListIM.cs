using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Linear_structures
{
    internal class ListIM<Type>
    {
        private Type[] array;
        public int Count { get; set; }

        public ListIM()
        {
            array = new Type[4];
            Count = 0;
        }
        public void Add(Type element)
        {
            if (Count == array.Length)
            {
                Resize();
            }
            array[Count] = element;
            Count++;
        }
        public Type this[int index] 
        { 
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new OutOfRangeException("Index is outside the bounds of the array");
                }
                return array[index];
            } 
            set 
            {
                if (index < 0 || index >= Count)
                {
                    throw new OutOfRangeException("Index is outside the bounds of the array");
                }
                else{
                    array[index] = value;
                }
            } 
        }

        private void Resize()
        {
            Type[] newArray = new Type[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}
