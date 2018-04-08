using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.Interview
{
    public class Localytics
    {
        public class Product
        {
            public string Name;
            public double Sale;
            public string Category;
        }

        public class Category
        {
            public string Name;
            public double totalSale;
        }

        public List<Category> Top5CatBySell()
        {
            Dictionary<String, List<Product>> prodDict = new Dictionary<string,List< Product>>(); // prodDict

            Dictionary<String, double> Sales = new Dictionary<string, double>(); //Sales dictionay

            //Read product File
            string path =string.Empty; // product
            string[] lines = System.IO.File.ReadAllLines(path);

           foreach(var line in lines)
           {
               string item = line.Substring(0,line.LastIndexOf(' '));
               string category = line.Substring(line.LastIndexOf(' '), line.Length - line.LastIndexOf(' '));

               if (prodDict.ContainsKey(category))
               {
                   List<Product> Catproducts = prodDict[category];
                   Catproducts.Add(new Product { Name = item, Sale = getSell(item,Sales), Category = category });
               }
               else
               {
                    List<Product> Catproducts = new List<Product>();
                    Catproducts.Add(new Product { Name = item, Category = category,Sale = getSell(item,Sales) });
                    prodDict.Add(category, Catproducts);
               }
           }
         
           List<Category> cats = new List<Category>();
           foreach(var key in prodDict.Keys)
           {

              List<Product> products =  prodDict[key];

              if (key == "Candy")
              {
                  var topProds = prodDict[key].OrderBy(p => p.Sale).FirstOrDefault();
                  Console.Write(topProds.Name); //Answer top prod by candy
              }

              double sum = products.Sum(s => s.Sale);
              cats.Add( new Category { Name = key, totalSale = sum });
           }



           return cats.OrderBy(c => c.totalSale).Take(5).ToList();   

        }

        public double getSell(string item, Dictionary<String, double> Sales)
        {
            return Sales[item];
        }
    }
}