using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsStore.Domain.Entities
{
    public class ZipData
    {
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
    }

    public static class ZipHelper
    {
        public static string WhatsMyCity(string Zip)
        {
            string city=null;
            //Returns a string representing the City for the Zip provided
            //Returns null if string is not a zip or not found in database
            return city;
        }
        public static string WhatsMyState(string Zip)
        {
            string state=null;
            //Returns a string representing the State for the Zip provided
            //Returns null if string is not a zip or not found in database
            return state;
        }
    }

}
