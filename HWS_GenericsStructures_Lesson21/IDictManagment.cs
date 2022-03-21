using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_GenericsStructures_Lesson21
{
    internal interface IDictManagment<TKey,TValue>
    {
        public int Count { get; }
        bool HaveThisValue(TKey key);
        List<TValue> GetAll();
        TValue Get(TKey key);
        bool Add(TValue value);
        void Update(TKey key, TValue value);
        void Delete(TKey key);
        void Clear();
    }
}
