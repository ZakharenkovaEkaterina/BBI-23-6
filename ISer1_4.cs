using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Serializers
{
    internal interface ISer1_4
    {
            public abstract void Write<T>(T obj, string path);
            public abstract T Read<T>(string path);
    }
}

