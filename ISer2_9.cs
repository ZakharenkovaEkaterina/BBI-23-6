using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2_9.serializers1
{
    internal interface ISer2_9
    {
        public abstract void Write<T>(T obj, string path);
        public abstract T Read<T>(string path);
    }
}
