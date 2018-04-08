using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class stack<T>
    {
        private int _capacity;
        public int capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        private T[] _elements;
        public T[] elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        private int _index = -1;
        public int index
        {
            get { return _index; }
            set { _index = value; }
        }

        public stack()
        {
            elements = new T[capacity];
        }

        public stack(int capacity)
        {
            this.capacity = capacity;
            elements = new T[capacity];
        }

        //private int length;
        public int length
        {
            get { return index + 1; }
            //set { _length = value; }
        }

        public void push(T aelement)
        {
            if (length == capacity)
            {
                increaseCapacity();
            }
            index++;
            elements[index] = aelement;
            Console.WriteLine("Element[" + index + "] = " + elements[index]);
        }

        public T pop()
        {
            if (length < 1)
            {
                throw new Exception("Invalid Operation");
            }


            T aelement = elements[index];
            elements[index] = default(T);
            index--;
            return aelement;
        }

        public void increaseCapacity()
        {
            capacity++;
            capacity *= 2;
            T[] newelement = new T[capacity];
            Array.Copy(elements, newelement, elements.Length);
            elements = newelement;
        }

    }
}
