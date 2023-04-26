using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    public class Data
    {
        public static string name;
        public static string name1;

        public Data()
        {

        }

        public Data(string data,string data1)
        {
            name = data;
            name1 = data1;
        }

        public string getData1()
        {
            return name;
        }
        public string getData2()
        {
            return name1;
        }
     
    }
}
