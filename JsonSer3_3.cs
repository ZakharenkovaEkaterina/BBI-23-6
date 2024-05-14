using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab9_3_3.Serializers2
{
        public class JsonSer3_3 : ISer3_3
        {
            public void Write<T>(T obj, string path)
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    JsonSerializer.Serialize<T>(fs, obj);
                }
            }
            public T Read<T>(string path)
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    return JsonSerializer.Deserialize<T>(fs);
                }
            }
        }
}
