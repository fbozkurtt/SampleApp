using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebService.Models;

namespace SampleWebService.Controllers
{
    [Produces("application/json")]
    [Route("[action]")]
    [ApiController]
    [Authorize]
    public class DefaultController : ControllerBase
    {
        [HttpPost]
        public IActionResult Test([FromBody] TestModel model)
        {
            return new JsonResult(new
            {
                success = true,
                model.Id,
                model.Name
            });
        }
    }
}
