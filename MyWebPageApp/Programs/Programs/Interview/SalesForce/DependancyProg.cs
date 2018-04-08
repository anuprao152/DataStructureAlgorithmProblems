using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview.SalesForce
{
    public class DependancyProg
    {

        public class Item
        {
            public String Name;
            public List<Item> DependOn = new List<Item>();
            public Dictionary<Item, Item> DependUpon = new Dictionary<Item,Item>();

            public Boolean IsInstalled;
        }

        //you also need to write dependupon
 
        Dictionary<Item,Boolean> InstalledItems = new Dictionary<Item,Boolean>();

        public void List()
        {
            foreach(var kv in InstalledItems)
            {
                if (kv.Value)
                    Console.WriteLine(kv.Value);
            }
        }

        public void DependOn(Item Itm, Item[] Items)
        {
            String Output = "Depend " + Itm.Name;

            foreach (var i in Items)
            {
                Itm.DependOn.Add(i);
                Output += " " + i.Name;

                //also this item dependupon on input Item
                if (!i.DependUpon.ContainsKey(Itm))
                    i.DependUpon.Add(Itm, Itm);
            }

            Console.WriteLine(Output);


        }

        public void Install(Item Item)
        {
            if (InstalledItems.ContainsKey(Item)) //if (!Item.IsInstalled)
            {
                Console.WriteLine(Item.Name + "is Already Installed");
                return;
            }

            //If not Installed, Recursivley install dependOn Items
            IntstallRecursively(Item);

            Console.WriteLine(Item.Name + "is Already Installed");
        }

        // Post order DFS , Topological sorting algo
        private void IntstallRecursively(Item Item)
        {
            if (!InstalledItems.ContainsKey(Item))     //if (!Item.IsInstalled)
            {
                foreach(var item in Item.DependOn)
                {
                    IntstallRecursively(item);
                }

                //Item.IsInstalled = true;
                InstalledItems.Add(Item, true);
                Console.WriteLine("Installing" + Item.Name);
            }
        }

        public void Remove(Item Item)
        {
            if (!InstalledItems.ContainsKey(Item))   //if (!Item.IsInstalled)
            {
                Console.WriteLine(Item.Name + "Is not Installed");
                return;
            }

            if(Item.DependUpon.Count<=0)
            {
                Console.WriteLine(Item.Name + "Is still Needed");
            }

            // Below are the Items you may need to UnInstall
            Dictionary<Item,Boolean> UnInstalled = new Dictionary<Item,Boolean>();
            RemoveRecursively(Item, UnInstalled);

            //check if they actuall get removed or not, if not make it false
            foreach(var kv in UnInstalled)
            {
                var item = kv.Key;
               
                foreach (var du in item.DependUpon.Keys)
                {
                    if (!UnInstalled.ContainsKey(du)) // if you find outside dependupon Item
                    {
                        UnInstalled[item] = false; // you can't delete this item and make it false in hashmap
                        break;
                    }
                }
            }

            //Now Print all the deleted items, loop through uninstalled dictionary and delete those items
            // where you have flag true
            foreach (var kv in UnInstalled)
            {
                if (kv.Value)
                {
                    Console.WriteLine("Removing " + kv.Key.Name);
                    if (InstalledItems.ContainsKey(kv.Key))
                    {
                        InstalledItems[kv.Key] = false;
                        //kv.Key.IsInstalled = false;
                    }
                }
            }

        }

        //pre order 
        private Dictionary<Item,Boolean> RemoveRecursively(Item Item, Dictionary<Item,Boolean> UnInstalled)
        {
            if(UnInstalled.ContainsKey(Item))
                    return UnInstalled;

            UnInstalled.Add(Item,true);

            foreach(var itm in Item.DependOn)
            {
                RemoveRecursively(itm, UnInstalled);
            }

            return UnInstalled;
        }



        

    }
}
