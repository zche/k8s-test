using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using k8s_test.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace k8s_test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class K8sTestController : ControllerBase
    {
        private readonly ILogger<K8sTestController> _logger;
        private readonly INameContact _nameContact;

        public K8sTestController(ILogger<K8sTestController> logger,INameContact nameContact)
        {
            _logger = logger;
            _nameContact = nameContact;
        }

        [HttpGet]
        public async Task<string> GetAsync()
        {
            return "hello," + await _nameContact.GetNameAsync();
        }
    }
}
