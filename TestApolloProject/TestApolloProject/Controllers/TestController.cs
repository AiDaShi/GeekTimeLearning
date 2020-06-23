using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TestApolloProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TestController(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        [HttpGet]
        public string GetENV_ABV2() 
        {
            return _configuration["ENV_ABV2"];
        }
    }
}