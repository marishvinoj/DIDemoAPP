using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Mvc;

namespace DIDemoAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICalculateManager _CalculateManager { get; }
        private ICountryManager _CountryManager { get; }
        public ValuesController(ICalculateManager calculateManager, ICountryManager countryManager)
        {
            _CalculateManager = calculateManager;
            _CountryManager = countryManager;
        }

        [Route(("Add"))]
        [HttpGet]
        public int Add()
        {
            return _CalculateManager.Add(1, 2);
        }

        [Route(("LoadCountryList"))]
        [HttpGet]
        public IEnumerable<string> CountryList()
        {
            return _CountryManager.GetCountryList();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
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
