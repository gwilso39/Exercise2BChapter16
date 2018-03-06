using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B_Chapter_16
{
    class MyDictionary
    {
        private KeyValue[] kv = new KeyValue[32];
        private int storedValues;

        public int this[string key]
        {
                //The `get` property should search the array for the given key 
                //and return the associated value if it exists. If the key does 
                //not exist, the property should throw a KeyNotFoundException.

            get
            {
                int i = Array.IndexOf(this.kv,key);
                if (kv[i].key == key)
                {
                    return kv[i].value;
                }
                throw new KeyNotFoundException("Couldn't find this key");
            }

            set
            {
                //The `set` property should search the array for the given key
                //and replace the KeyValue with a `new KeyValue(...)` if it exists. 
                //If the key does not exist, it should be added as a `new KeyValue(...)`.

                //??foreach value in kv[]

                int i = Array.IndexOf(this.kv, key);
                if (kv[i].key == key)
                {
                    kv[i].value = new value;
                }
                kv[i].key = key;
                kv[i].value = value;
            }
        }
    }
}
