using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B_Chapter_16
{
    class MyDictionary<T>
    {

        public KeyValue<T>[] kv = new KeyValue<T>[32];
        private int storedValues = 0;

        public T this[string key]
        {
                //The `get` property should search the array for the given key 
                //and return the associated value if it exists. If the key does 
                //not exist, the property should throw a KeyNotFoundException.

            get
            {
                for (int i = 0; i < storedValues; i++)
                {
                    if (kv[i].key == key)
                    {
                        return kv[i].value;
                    }
                }
                throw new KeyNotFoundException("Couldn't find this key");
            }

            set
            {
                //The `set` property should search the array for the given key
                //and replace the KeyValue with a `new KeyValue(...)` if it exists. 
                //If the key does not exist, it should be added as a `new KeyValue(...)`.

                bool found = false;

                for (int i = 0; i < storedValues; i++)
                {
                    if (kv[i].key == key)
                    {
                        found = true;

                        kv[i] = new KeyValue<T>(key, value);
                    }
                }

                if (!found)
                {
                    kv[storedValues++] = new KeyValue<T>(key, value);
                }
            }
        }
    }
}
