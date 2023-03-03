namespace Lesson4.Models
{
    internal class SimpleGenericCache<T>
    {
        private readonly Dictionary<string, CachedValue<T>> _cache = new();

        public void Store(string key, T value, int timeout = 30)
        {
            var cachedValue = new CachedValue<T>
            { 
                CreationTime = DateTime.Now,
                Timeout = timeout,
                Value = value
            };
            _cache[key] = cachedValue;
        }

        internal CachedValue<T>? Fetch(string key) 
        {
            if (_cache.TryGetValue(key, out var value))
            {
                if (value.CreationTime + TimeSpan.FromSeconds(value.Timeout) >= DateTime.Now)
                {   
                    return value;
                }
                _cache.Remove(key);
            }
            return default;
        }
    }
    internal record CachedValue<T>
    {
        public T? Value { get; init; }
        public DateTime CreationTime { get; init; }
        public int Timeout { get; init; }
    }
}


