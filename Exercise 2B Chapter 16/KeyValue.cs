using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B_Chapter_16
{
    struct KeyValue
    {
        public readonly string key;
        public readonly object value;

        public KeyValue (string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
