using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemoAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ICountryManager _CountryManager { get; }
        public HomeController(ICountryManager countryManager)
        {
            _CountryManager = countryManager;
        }

        [Route(("LoadCountryList"))]
        [HttpGet]
        public IList<string> CountryList()
        {
            var res =  _CountryManager.GetCountryList();
            return res;
        }

    }
}