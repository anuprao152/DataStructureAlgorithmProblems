using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackProgram
{
    public class Queue<T>
    {
        private int _frontindex = -1;
        public int frontindex
        {
            get { return _frontindex; }
            set { _frontindex = value;}
        }

        private int _backindex = -1;
        private int backindex
        {
            get { return _backindex; }
            set { _backindex = value; }
        }

        private T[] _elements;
        public T[] elements
        {
            get { return _elements;}
            set { _elements = value; }
        }

        public int length
        {
            get { return frontindex + 1; }
        }

        private int _capacity;
        public int capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public Queue()
        {
            elements = new T[capacity];
        }

        public Queue(int capacity)
        {
            elements = new T[capacity];
        }

        public void enqueue(T element)
        {
            if (length == capacity)
            {
                increaseCapacity();
            }
            frontindex++;
            elements[frontindex] = element;
            
        }

        public void increaseCapacity()
        {
            capacity++;
            capacity *= 2;
            T[] newelements = new T[capacity];
            Array.Copy(elements, newelements, elements.Length);
            elements = newelements;
        }

        public T dequeue()
        {
            if (backindex > frontindex)
            {
                throw new Exception("invalide operation");
            }
            backindex++;
            T element = elements[backindex];
            elements[backindex]= default(T);
            
            return element;
        }
    }
}
