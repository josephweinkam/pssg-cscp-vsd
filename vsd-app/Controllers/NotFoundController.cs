﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gov.Jag.VictimServices.Public.Authentication;
using Gov.Jag.VictimServices.Public.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Gov.Jag.VictimServices.Public.Controllers
{
    [Route("404")]
    public class NotFoundController : Controller
    {


        public NotFoundController()
        {

        }

        [HttpGet]

        public ActionResult NotFound(string path)
        {
            return NotFound();
        }

    }
    
}
