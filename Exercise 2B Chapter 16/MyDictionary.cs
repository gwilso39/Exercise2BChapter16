using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B_Chapter_16
{
    class MyDictionary
    {
        private Array[KeyValue] myArray = new Array[32];
        private int storedValues;

        public object this[string key]
        {

            //The `get` property should search the array for the given key 
            //and return the associated value if it exists. If the key does 
            //not exist, the property should throw a KeyNotFoundException.
            get { ; }
            //The `set` property should search the array for the given key
            //and replace the KeyValue with a `new KeyValue(...)` if it exists. 
            //If the key does not exist, it should be added as a `new KeyValue(...)`.
            set { foreach val in myArray; }

        }return value;
    }
}
