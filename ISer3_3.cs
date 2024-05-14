using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_3_3.Serializers2
{
    internal interface ISer3_3
    {
        public abstract void Write<T>(T obj, string path);
        public abstract T Read<T>(string path);
    }
}
