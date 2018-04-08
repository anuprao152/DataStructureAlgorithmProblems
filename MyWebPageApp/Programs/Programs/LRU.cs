using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs
{
    public class Page
    {
        public int pageId;
        public Page Next;
        public Page Prev;
    }

    public class LRU
    {
        private int size;

        public LRU(int size)
        {
            this.size = size;
        }

        Dictionary<int, Page> Pages;

        private Page front;
        private Page rear;

        private int count;

        public void Add(Page p)
        {
            if (count < size)
                Pages.Add(p.pageId, p);
            else
            {
                if (Pages.ContainsKey(p.pageId))
                {
                    //Remove and put it in a front;
                    Remove(p);


                    p.Next = front;
                    p.Prev = null;

                    if (front != null)
                        front.Prev = p;

                    front = p;
                    
                }
                else
                {
                    //new page, remove last page and add that new page in front
                    Remove(rear);

                    p.Next = front;
                    p.Prev = null;

                    if (front != null)
                        front.Prev = p;

                    front = p;
                }
            }



        }

        public void Remove(Page p)
        {
            
        }
    }
}
