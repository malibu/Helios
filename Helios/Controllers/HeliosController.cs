using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Helios.Controllers
{
    public class HeliosController : ApiController
    {
        // GET api/helios
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/helios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/helios
        public void Post([FromBody]string value)
        {
        }

        // PUT api/helios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/helios/5
        public void Delete(int id)
        {
        }
    }
}
