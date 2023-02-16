using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models
{
    internal class SimpleGenericCache<T>
    {
        private readonly Dictionary<string, T?> _cache = new();

        internal void Store(string key, T value)
        {
            _cache[key] = value;
        }

        internal T? Fetch(string key)
        {
            if (_cache.TryGetValue(key, out var value))
            {
                return value;
            }

            return default;
        }
    }
}
// Проверка хождения по веткам
