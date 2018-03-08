using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B_Chapter_16
{
    struct KeyValue<T>
    {
        public readonly string key;
        public readonly T value;

        public KeyValue (string key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }

    //struct KeyValue
    //{
    //    public readonly string key;
    //    public readonly object value;

    //    public KeyValue(string key, object value)
    //    {
    //        this.key = key;
    //        this.value = value;
    //    }
    //}
}
