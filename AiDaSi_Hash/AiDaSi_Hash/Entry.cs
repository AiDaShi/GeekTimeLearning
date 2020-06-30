using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_Hash
{
    public class Entry<K, V> : IEntry<K, V>
    {
        public Entry<K, V> next { get; set; }
        public K _key { get; set; }
        public V _value { get; set; }

        public Entry(K key, V value)
        {
            this._key = key;
            this._value = value;
        }
    }
}
