using System;
using System.Collections.Generic;
using System.Text;

namespace AiDaSi_Hash
{
    public interface IEntry<K, V>
    {
         Entry<K, V> next { get; set; }
         K _key { get; set; }
         V _value { get; set; }
    }
}
