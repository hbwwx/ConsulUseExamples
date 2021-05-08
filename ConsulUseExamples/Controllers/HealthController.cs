using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsulUseExamples.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public string Get()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            return "ok";
        }
    }
}
