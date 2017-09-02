using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_sample
{
    namespace JsonNodeHoge
    {
        public class Huga
        {
            public List<string> piyo { get; set; }
        }
    }
    public class Hoge
    {
        public string stringField { get; set; }
        public int numField { get; set; }
        public double floatField { get; set; }
        public bool boolField { get; set; }
        public JsonNodeHoge.Huga huga { get; set; }
    }

    public class RootObject
    {
        public string title { get; set; }
        public string author { get; set; }
        public Hoge hoge { get; set; }
        public List<string> tags { get; set; }
        public List<object> valiableTags { get; set; }
        public List<int> intArray { get; set; }
        public List<double> floatArray { get; set; }
        public string date { get; set; }
        public string year { get; set; }
    }
}
