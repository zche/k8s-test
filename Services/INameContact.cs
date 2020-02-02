using System;
using System.Threading.Tasks;

namespace k8s_test.Services
{
    public interface INameContact
    {
        Task<string> GetNameAsync();
    }
}
