using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspPatterns.Chap2.Service
{
    public class NullObjectCache: ICacheStorage
    {

        public void Remove(string key)
        {
            // do nothing
        }

        public void Store(string key, object data)
        {
            // do nothing
        }

        public T Retrieve<T>(string key)
        {
            return default(T);
        }
    }
}
