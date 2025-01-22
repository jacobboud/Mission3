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
        public string quantity = "";
        public string expiration = "";

        public FoodItem (string name1, string category1, string quantity1, string expiration1)
        {
            name = name1;
            category = category1;
            quantity = quantity1;
            expiration = expiration1;

        }

    }
}
