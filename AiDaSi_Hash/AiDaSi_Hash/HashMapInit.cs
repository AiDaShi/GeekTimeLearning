using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_Hash
{
    public class HashMapInit<K, V> : HashMapInsterface<K, V>
    {
        public int DEFAULT_BUCKET_COUNT { get; set; } = 128;
        public IEntry<K, V>[] buckets { get; set; }

        public HashMapInit()
        {
            buckets = new Entry<K, V>[DEFAULT_BUCKET_COUNT];
        }

        public V GetV(K key)
        {
            int BucketIndex = IndexFor(key);
            IEntry<K, V> entry = buckets[BucketIndex];
            while (entry != null && !key.Equals(entry._key))
                entry = entry.next;
            return entry != null?entry._value:default(V);
        }

        private int IndexFor(K key)
        {
            return key.GetHashCode() & (buckets.Length - 1);
        }

        public void Put(K key, V value)
        {
            int bucketIndex = IndexFor(key);
            IEntry<K, V> entry = buckets[bucketIndex];
            if (entry != null)
            {
                bool done = false;
                while (!done)
                {
                    if (key.Equals(entry._key))
                    {
                        entry._value = value;
                        done = true;
                    }
                    else if(entry.next == null)
                    {
                        //没找到就增加
                        entry.next = new Entry<K, V>(key, value); 
                        done = true;
                    }
                    entry = entry.next;
                }
            }
            else
            {
                //推进去一个新项目
                buckets[bucketIndex] = new Entry<K, V>(key, value);
            }
        }
    }
}
