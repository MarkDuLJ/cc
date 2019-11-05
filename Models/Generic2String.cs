using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Generic2String
    {
        public string key { get; set; }
        public string value { get; set; }
        public Generic2String()
        {
            key = "";
            value = "";
        }

        public Generic2String(string _key,string _value)
        {
            key = _key;
            value = _value;
        }
    }
}
