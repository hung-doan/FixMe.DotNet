using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FixMe01AsyncAwait.DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixMeController : ControllerBase
    {
        // GET api/FixMe
        // No Deadlock
        public int Get()
        {
            return GetDataAsync().Result;
        }

        private async Task<int> GetDataAsync()
        {
            await Task.Delay(1000);
            return 1;
        }
    }
}