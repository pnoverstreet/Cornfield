using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cornfield.Controllers
{
    public class StalkController : ApiController
    {
        // GET: api/Stalk
        public IEnumerable<string> Get()
        {
            List<string> list = new List<string>();
            for (int index = 0; index < 10; index++)
                list.Add(String.Format("Ear {0:D2}", (index + 1)));
            return list;
        }

        // GET: api/Stalk/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stalk
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Stalk/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stalk/5
        public void Delete(int id)
        {
        }
    }
}
