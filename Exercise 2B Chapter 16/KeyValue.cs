using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2B_Chapter_16
{
    struct KeyValue
    {
        public string key { get; }
        public object value { get; }

        private KeyValue(string key, object value)
        {

        }
    }
}
