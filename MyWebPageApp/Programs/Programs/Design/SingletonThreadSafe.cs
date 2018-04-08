using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{

    //Singleton Implimentation lazy loading
    public class Singleton
    {
        private static Singleton singleInstance;

        private Singleton(){}

        public Singleton SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                   singleInstance = new Singleton();
                }
                return singleInstance;
            }
        }
    }

    //Thread Safe and works almost in all situation.
    //Before any thread runs on it instantiate SingletonThreadSafe class
    public class SingletonThreadSafe
    {
        private static readonly SingletonThreadSafe singleInstance = new SingletonThreadSafe(); //Eager 

        static SingletonThreadSafe(){}
        private SingletonThreadSafe(){}

        public SingletonThreadSafe SingleInstance
        {
            get
            {
                return singleInstance;
            }
        }
    }

    //ThreadSafe singleton by double check locking
    //lock the instantion of the instance so you ensure that only one 
    //thread can instantiate the object when first time enters in critical area.

    public class SingletonThreadSafeV2
    {
        private static SingletonThreadSafeV2 singleInstance;
        private static object lockobj = new object();
        private SingletonThreadSafeV2(){}

        public SingletonThreadSafeV2 SingleInstance
        {
            get
            {
                
                if (singleInstance == null)
                {
                    lock (lockobj)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new SingletonThreadSafeV2();
                        }
                    }
                }
                return singleInstance;
            }
        }
    }
}
