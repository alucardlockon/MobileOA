using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MobileOA.API.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Response.Headers.Add("Access-Control-Allow-Headers",
                "Origin, X-Requested-With, Content-Type, Accept,city_region_id,RegistradionID,Authorization");
            Response.Headers.Add("Access-Control-Allow-Methods","GET, PUT, POST, DELETE, OPTIONS");
            Response.Headers.Add("Access-Control-Allow-Origin","*");
            return new string[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}