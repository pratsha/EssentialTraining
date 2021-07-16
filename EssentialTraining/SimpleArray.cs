using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] GrocerryList;
        public SimpleArray()
        {
            GrocerryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }

        public override string ToString()
        {
            return "There are " + GrocerryList.Length + " are they are: " + GrocerryList.ToString();
        }
    }
}
