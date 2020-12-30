using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestService.Controllers
{
    [ApiController]
    [Route("api")]
    public class MyController : Controller
    {
        [HttpPost]
        [Route("test")]
        public IEnumerable<int> Test()
        {
            return Enumerable.Range(0, 100);
        }

        [HttpPost]
        [Route("test2")]
        public IEnumerable<int> Test2()
        {
            return Enumerable.Range(0, 100);
        }

        [HttpGet]
        [Route("test3")]
        public IEnumerable<int> Test3()
        {
            return Enumerable.Range(0, 100);
        }

        [HttpGet]
        [Route("test4")]
        public IEnumerable<int> Test4()
        {
            throw new Exception("error!");
            return Enumerable.Range(0, 100);
        }
    }
}
