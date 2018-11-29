using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FixMe01AsyncAwait.Controllers
{
    public class FixMeController : ApiController
    {
        // GET api/FixMe
        // Deadlock happen
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
