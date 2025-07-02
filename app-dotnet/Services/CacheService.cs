using Microsoft.Extensions.Caching.Memory;
using System;

namespace DevOps2025.Services
{
    public class CacheService
    {
        private readonly IMemoryCache _cache;

        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public T GetOrCreate<T>(string key, Func<T> createItem, TimeSpan duration)
        {
            if (!_cache.TryGetValue(key, out T item))
            {
                item = createItem();
                _cache.Set(key, item, duration);
            }
            return item;
        }
    }
}