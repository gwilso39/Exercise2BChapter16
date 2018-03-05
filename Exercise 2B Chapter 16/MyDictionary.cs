using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B_Chapter_16
{
    class MyDictionary
    {
        private KeyValue[] myArray;
        private int storedValues;

        KeyValue kv = new KeyValue();

        kv["cat"] = 42;
        kv["dog"] = 17;

        kv["cat"];

        public MyDictionary()
        {
            int initialSize = 0;
            this.used = 0;
        }

        public object this[string key]
        {

            //The `get` property should search the array for the given key 
            //and return the associated value if it exists. If the key does 
            //not exist, the property should throw a KeyNotFoundException.
            get
            {
                if (myArray.Contains(key))
                {
                    return key;
                }
                else
                {
                    throw new KeyNotFoundException("Couldn't find this key");
                }
            }
            //The `set` property should search the array for the given key
            //and replace the KeyValue with a `new KeyValue(...)` if it exists. 
            //If the key does not exist, it should be added as a `new KeyValue(...)`.
            set
            {
                if (myArray[KeyValue].Contains(key))
                {
                    KeyValue = key;
                }
                else
                {
                    myArray[KeyValue].add(key);
                }
            }

        }return value;
    }
}
