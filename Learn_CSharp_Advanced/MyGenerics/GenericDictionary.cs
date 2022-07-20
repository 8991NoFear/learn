using System.Collections.Generic;

namespace MyGenerics
{
    class GenericDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dict;

        public GenericDictionary()
        {
            dict = new Dictionary<TKey, TValue>();
        }

        public bool Add(TKey key, TValue value)
        {
            dict.Add(key, value);
            return true;
        }

        public TValue this[TKey key]
        {
            get
            {
                return dict[key];
            }
        }
    }
}
