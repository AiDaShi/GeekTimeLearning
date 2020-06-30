using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_Hash
{
    public interface HashMapInsterface<K,V>
    {
        int DEFAULT_BUCKET_COUNT { get; set; }

        IEntry<K, V>[] buckets { get; set; }


        V GetV(K key);
        void Put(K key, V value);

    }
}
