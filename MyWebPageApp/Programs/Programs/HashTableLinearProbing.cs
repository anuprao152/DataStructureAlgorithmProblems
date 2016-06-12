using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class HashTableLinearProbing
    {
         public class Entry
         {
             public object key;
             public object value;
             public Entry(object key, object value)
             {
                 this.key = key;
                 this.value = value;
             }
         }

         //Default
         static int tableSize =100;
         Entry[] Entries;

         public HashTableLinearProbing()
         {
             Entries = new Entry[tableSize];
         }
         public HashTableLinearProbing(int size)
         {
             tableSize = size;
             Entries = new Entry[tableSize];
         }

         private int getIndex(object key)
         {
             return key.GetHashCode() % tableSize;
         }

         public void Put(object key, object value)
         {
             int index = getIndex(key);

             if (Entries[index] == null)
             {
                 Entries[index] = new Entry(key, value); 
             }
             else // collision
             {
                 //Same key - update the value at the index
                 if (Entries[index].key.Equals(key))
                 {
                     Entries[index].value = value;
                 }
                 else // find next available slot
                 {
                     while (index < tableSize)
                     {
                         if (Entries[index] == null)
                         {
                             Entries[index] = new Entry(key, value);
                             return;
                         }
                         index++;
                     } 

                     if (index == tableSize)
                     {
                         //double the tablesize
                         DoubleTableSize();
                         Put(key, value);
                     }
                 }
             }
         }

         public object Get(object key)
         {
             int index = getIndex(key);

             //if key matches 
             if (Entries[index].key == key)
                 return Entries[index].value;

             // find it in consecutive slots
             while (index < tableSize)
             {
                 if (Entries[index].key == key)
                     return Entries[index].value;
                 index++;
             }

             return null; // key doesn't exist, so no value
         }

         public void Remove(object key)
         {
             int index = getIndex(key);

             
             //if key matches 
             if (Entries[index] != null && Entries[index].key.Equals(key))
             {
                 Entries[index] = null;
                 return;
             }

             // find it in consecutive slots
             while (index < tableSize)
             {
                 if (Entries[index] != null && Entries[index].key.Equals(key))
                 {
                     Entries[index]= null;
                     return;
                 }
                 index++;
             }
         }

         private void DoubleTableSize()
         {
             tableSize = tableSize * 2;
             Entry[] NewEntries = new Entry[tableSize];

             Array.Copy(Entries, NewEntries, Entries.Length);
             Entries = NewEntries;
         }

    }
}
