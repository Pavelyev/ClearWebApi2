using System.Collections.Generic;
using System.Web.Http;

namespace ClearWebApi2.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
