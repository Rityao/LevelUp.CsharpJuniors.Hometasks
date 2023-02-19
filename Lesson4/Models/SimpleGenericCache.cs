using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models
{
    internal class SimpleGenericCache<T> // для каждого типа кеша будет создаваться свой экземпляр
    {
        private readonly Dictionary<string, T?> _cache = new();

        internal void Store(string key, T value)
        {
            _cache[key] = value;
        }

        internal T? Fetch(string key) // тип, на который мапается T будет создаваться с экземпляром класса
        { // T с ? - может храниться NULLable значение
            if (_cache.TryGetValue(key, out var value))
            {
                return value;
            }

            return default;
        }
    }
}


