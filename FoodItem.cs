using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    internal class FoodItem
    {

        public string name = "";
        public string category = "";
        public int quantityNum = 0;
        public string quantityUnit = "";
        public string expiration = "";

        //Food item constructor
        public FoodItem (string name1, string category1, int quantityNum1, string quantityUnit1, string expiration1)
        {
            name = name1;
            category = category1;
            quantityNum = quantityNum1;
            quantityUnit = quantityUnit1;
            expiration = expiration1;

        }

    }
}
