using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
{
    public class circularQueue<T>
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

        private int _frontindex = -1;
        public int frontindex
        {
            get { return _frontindex; }
            set { _frontindex = value; }
        }

        private int _backindex = -1;
        private int backindex
        {
            get { return _backindex; }
            set { _backindex = value; }
        }

        public int length
        {
            get { return frontindex + 1; }
        }

        public circularQueue(int capacity)
        {
            this.capacity = capacity;
            elements = new T[capacity];
        }

        //public void increaseCapacity()
        //{
        //    capacity++;
        //    capacity *= 2;
        //    T[] newelements= new T[capacity];
        //    Array.Copy(elements, newelements, elements.Length);
        //    elements = newelements;
        //}

        public void enqueue(T element)
        {
            if (length == capacity)
            {
                frontindex = -1;
            }

            frontindex++;
            elements[frontindex] = element;

        }

        public T dequeu()
        {
            if (backindex > frontindex)
            {
                backindex = -1;
            }

            backindex++;
            T element = elements[backindex];
            elements[backindex] = default(T);
            return element;
        }

    }
}
