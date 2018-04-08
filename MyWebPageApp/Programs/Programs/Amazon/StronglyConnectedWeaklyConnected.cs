using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Amazon
{
    //https://www.careercup.com/question?id=5705110748397568

//    A company is looking for algorithm to show item recommendations. 
//If a customer bought A and B items and another buys A item, B should come as recommendations. 
//There are two types of recommendations based on the connections 
//1) Two items are strongly connected if a customer buys those items. 
//2) Two items are weakly connected if each items are strongly/weakly connected to another third item. 

//Provided the sample input 
//ABC 
//10 
//first:ABC 
//first:HIJ 
//sec:HIJ 
//sec:KLM 
//third:NOP 
//fourth:ABC 
//fourth:QRS 
//first:DEF 
//fifth:KLM 
//fifth:TUV 

//first, sec, third.. represents the customer names 
//ABC, HIJ... represents the item codes 

//For the Input item Id "ABC", since "ABC" is strongly connected to HIJ, DEF, QRS 
//and whereas ABC is weakly connected to KLM and TUV 

//the output should be count of strong and weak connection i.e., [3,2]
    public class StronglyConnectedWeaklyConnected
    {
        //strong connection
        public void FindStrongWeakConnection(string itemId, String[] purchases)
        {
            Dictionary<string, string> stronglyConnected = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, string>> cus_itemsDict = new Dictionary<string,Dictionary<string, string>>();
            
            // Customer who purchase ABC item with other itmes are strongly connected with same purchase
            for (int i = 0; i < purchases.Length; i++)
            {
                var purchase = purchases[i];
                string[] cus_item = purchases[i].Split(':');
                var cus = cus_item[0];
                var item = cus_item[1];

                //if customer exist check itme is there or not.
                if (cus_itemsDict.ContainsKey(cus))
                {
                    //get all items and add item if it is not there.
                    Dictionary<string, string> items = cus_itemsDict[cus];

                    if (!items.ContainsKey(item))
                        items.Add(item, item);
                }
                else
                {
                    Dictionary<string, string> items = new Dictionary<string, string>();
                    items.Add(item, item);

                    cus_itemsDict.Add(cus, items);
                }
            }

            // we have cust_items dictionary ready
            // strongly connected item
            foreach (var keyValuePair in cus_itemsDict)
            {
                Dictionary<string, string> items = keyValuePair.Value;
                if(items.ContainsKey(itemId))
                {
                    foreach(var item in items)
                    {
                        if (!stronglyConnected.ContainsKey(item.Value))
                            stronglyConnected.Add(item.Value, item.Value);
                    }
                }
            }

            foreach (var keyValuePair in cus_itemsDict)
            {
                Dictionary<string, string> items = keyValuePair.Value;

                if (!items.ContainsKey(itemId))
                {
                    foreach (var item in items)
                    {
                        if (stronglyConnected.ContainsKey(item.Value))
                            stronglyConnected.Add(item.Value, item.Value);
                    }
                }
            }
            
            
        }

        //if (items.ContainsKey(itemId))
        //{
        //    if (item != itemId)
        //        stronglyConnected.Add(item, item);

        //    if(items.ContainsKey(item))
        //}
        //else
        //{
        //    if (item == itemId)
        //        stronglyConnected.Add(item,item);
        //    else
        //    items.Add(item,item)
        //}
    }
}
