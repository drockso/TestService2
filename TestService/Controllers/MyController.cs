﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
