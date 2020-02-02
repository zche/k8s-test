using System;
using Flurl.Http;
using System.Threading.Tasks;

namespace k8s_test.Services
{
    public class NameService : INameContact
    {
        private readonly string _serviceUrl = "http://name-api/api/name";

        public async Task<string> GetNameAsync()
        {
            try
            {
                var result = await _serviceUrl.WithTimeout(TimeSpan.FromSeconds(5)).GetStringAsync();
                return result;
            }
            catch
            {
                return "请求nameapi服务5秒后超时！";
            }
            
        }
    }
}
