using System;
using StackExchange.Redis;
using StackExchange.Redis.Extensions.Core;
using StackExchange.Redis.Extensions.Newtonsoft;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RedisViewer.Services
{
    public class RedisService: IDisposable
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _db;

        public RedisService(string configurationString, int databaseNumber = 0)
        {
            _redis = ConnectionMultiplexer.Connect(configurationString);
            _db = _redis.GetDatabase(databaseNumber);
        }

        public void Dispose()
        {
            _redis?.Dispose();
        }


        public IList<string> GetAllKeys(int maxCount = 10000)
        {
            var endPoint = ConfigurationOptions.Parse(_redis.Configuration).EndPoints.First();
            return _redis.GetServer(endPoint).Keys().Take(maxCount).Select(k => k.ToString()).ToList();
        }

        public string GetValue(string key)
        {
            return _db.StringGet(key);
        }

        public async Task<IEnumerable<string>> FindByKey(string keyPart)
        {
            var serializer = new NewtonsoftSerializer();
            var cacheClient = new StackExchangeRedisCacheClient(_redis, serializer);
            return await cacheClient.SearchKeysAsync($"*{keyPart}*");
        }

        public async Task<IList<string>> FindByValue(string valuePart)
        {
            var endPoint = ConfigurationOptions.Parse(_redis.Configuration).EndPoints.First();

            var items = new List<string>();
            await Task.Run(() =>
            {
                foreach (var key in _redis.GetServer(endPoint).Keys())
                {
                    var value = GetValue(key);
                    if (value.Contains(valuePart))
                    {
                        items.Add(key);
                    }
                }
            });

            return items;
        }
    }
}